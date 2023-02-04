using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories
{
    public class EntityARepository<EntityA> : IRepository<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA
    {
        private NpgsqlConnection connection;
        //NpgsqlTransaction transaction;
        private IFindStrategy<EntityA> findStrategy;

        public EntityARepository(NpgsqlConnection connection)
        {
            this.connection = connection;
            //this.transaction = transaction;
        }

        public EntityA create(EntityA item)
        {
            using (var transaction = connection.BeginTransaction())
            //{
                try
                {
                    //using (var command = new NpgsqlCommand("INSERT INTO entities_a (name) VALUES (@name) returning id;", connection, this.transaction))
                    using (var command = new NpgsqlCommand("INSERT INTO entities_a (name) VALUES (@name) returning id;", connection, transaction))
                    {
                        command.Parameters.AddWithValue("@name", item.Name);
                        item.Id = System.Int32.Parse(command.ExecuteScalar().ToString());
                    }

                    if (item.EntitiesB != null)
                    {
                        foreach (var entityB in item.EntitiesB)
                        {
                            using (var command = new NpgsqlCommand("INSERT INTO rel_entities_a_entities_b (id_entity_a, id_entity_b) VALUES (@id_entity_a, @id_entity_b);", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@id_entity_a", item.Id);
                                command.Parameters.AddWithValue("@id_entity_b", entityB.Id);
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    return item;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            //}
        }

        public bool delete(EntityA item)
        {
            throw new NotImplementedException();
        }

        public void setFindStrategy(IFindStrategy<EntityA> findStrategy)
        {
            this.findStrategy = findStrategy;
        }


        public List<EntityA> find(EntityA filter)
        {
            return this.findStrategy.find(this.connection);
        }

        public EntityA findOne(EntityA filter)
        {
            throw new NotImplementedException();
        }

        public bool update(EntityA item)
        {
            throw new NotImplementedException();
        }
    }
}
