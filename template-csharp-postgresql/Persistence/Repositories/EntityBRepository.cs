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
        private IFindStrategy<EntityB> findStrategy;
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

        public List<EntityB> find(EntityB filter)
        {
            return this.findStrategy.find(this.connection);
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

        public void setFindStrategy(IFindStrategy<EntityB> findStrategy)
        {
            this.findStrategy = findStrategy;
        }
    }
}
