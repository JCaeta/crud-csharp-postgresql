using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories
{
    public class EntityBRepository<EntityB> : IRepository<EntityB>
    where EntityB : template_csharp_postgresql.Entities.EntityB, new()
    {
        private NpgsqlConnection connection;
        public EntityBRepository(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public EntityB create(EntityB item)
        {
            string query = "insert into entities_b(name) values('" + item.Name + "') returning id;";
            NpgsqlCommand executor = new NpgsqlCommand(query, this.connection);
            System.Int32 result = (System.Int32)executor.ExecuteScalar();
            item.Id = result;
            return item;
        }

        public bool delete(EntityB item)
        {
            string query = "delete from entities_b where id=" + item.Id + ";";
            try
            {
                NpgsqlCommand executor = new NpgsqlCommand(query, this.connection);
                executor.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<EntityB> find(EntityB item)
        {
            List<EntityB> entitiesB = new List<EntityB>();
            string query = "select ";
            if (item.Id == -1 && item.Name == "")
            {
                query += " * from entities_b;";
            }

            NpgsqlCommand executor = new NpgsqlCommand(query, this.connection);
            NpgsqlDataReader result = executor.ExecuteReader();

            while (result.Read())
            {
                System.Int32 id = result.GetInt32(0);
                string name = result.GetString(1);
                EntityB entityB = new EntityB();
                entityB.Id = id;
                entityB.Name = name;
                entitiesB.Add(entityB);
            }

            return entitiesB;
        }

        public EntityB findOne(EntityB item)
        {
            throw new NotImplementedException();
        }

        public bool update(EntityB item)
        {
            string query = "update entities_b set name = '" + item.Name + "' where id=" + item.Id + ";";
            NpgsqlCommand executor = new NpgsqlCommand(query, this.connection);
            try
            {
                executor.ExecuteReader();
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
    }
}
