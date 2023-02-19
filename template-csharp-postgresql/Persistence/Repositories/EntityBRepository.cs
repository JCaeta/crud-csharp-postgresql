using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;
//using Npgsql;

namespace template_csharp_postgresql.Persistence.Repositories
{
    public class EntityBRepository<EntityB> : IRepository<EntityB>
    where EntityB : template_csharp_postgresql.Entities.EntityB, new()
    {
        private NpgsqlConnection connection;
        private IReadStrategy<EntityB> readStrategy;
        public EntityBRepository(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public EntityB create(EntityB item)
        {
            string query = "insert into entities_b(name) values('" + item.Name + "') returning id;";
            NpgsqlCommand executor = new NpgsqlCommand(query, this.connection);
            int result = int.Parse(executor.ExecuteScalar().ToString());
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

        public List<EntityB> read(EntityB filter)
        {
            return this.readStrategy.read(this.connection);
        }

        public EntityB readOne(EntityB item)
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

        public void setReadStrategy(IReadStrategy<EntityB> readStrategy)
        {
            this.readStrategy = readStrategy;
        }
    }
}
