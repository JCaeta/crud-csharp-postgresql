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
        private IReadStrategy<EntityA> readStrategy;

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
            bool result = false;
            using (NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                try
                {
                    string query1 = "delete from rel_entities_a_entities_b where id_entity_a = " + item.Id;
                    string query2 = "delete from entities_a where id = " + item.Id;
                    string fullQuery = query1 + ";" + query2 + ";";
                    NpgsqlCommand executor = new NpgsqlCommand(fullQuery, this.connection, transaction);
                    var reader = executor.ExecuteReader();
                    reader.Close();
                    transaction.Commit();
                    result = true;
                }catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            return result;
        }

        public void setReadStrategy(IReadStrategy<EntityA> readStrategy)
        {
            this.readStrategy = readStrategy;
        }


        public List<EntityA> read(EntityA filter)
        {
            return this.readStrategy.read(this.connection);
        }

        public EntityA readOne(EntityA filter)
        {
            throw new NotImplementedException();
        }

        public bool update(EntityA item)
        {
            bool result = false;

            // Create queries
            string query1 = "delete from rel_entities_a_entities_b where id_entity_a = " + item.Id + ";";
            string query2 = "update entities_a set name = '" + item.Name + "' where id = " + item.Id + ";";
            string query3 = "";
            foreach(EntityB entityB in item.EntitiesB)
            {
                string qry = "insert into rel_entities_a_entities_b(id_entity_a, id_entity_b) values (" + item.Id + ", " + entityB.Id + ");";
                query3 += qry;
            }
            
            using(NpgsqlTransaction transaction = this.connection.BeginTransaction())
            {
                try
                {
                    NpgsqlCommand executor = new NpgsqlCommand(query1 + query2 + query3, this.connection, transaction);
                    NpgsqlDataReader r = executor.ExecuteReader();
                    r.Close();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            return result;
        }
    }
}
