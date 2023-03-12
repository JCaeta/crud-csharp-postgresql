using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using crud_csharp_postgresql.Models;
//using Npgsql;

namespace crud_csharp_postgresql.Persistence.Repositories
{
    public class ModelBRepository<ModelB> : IRepository<ModelB>
    where ModelB : crud_csharp_postgresql.Models.ModelB, new()
    {
        private NpgsqlConnection connection;
        private IReadStrategy<ModelB> readStrategy;
        public ModelBRepository(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public ModelB create(ModelB item)
        {
            string query = "insert into models_b(name) values('" + item.Name + "') returning id;";
            NpgsqlCommand executor = new NpgsqlCommand(query, this.connection);
            int result = int.Parse(executor.ExecuteScalar().ToString());
            item.Id = result;
            return item;
        }

        public bool delete(ModelB item)
        {
            string query = "delete from models_b where id=" + item.Id + ";";
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

        public List<ModelB> read(ModelB filter)
        {
            return this.readStrategy.read(this.connection);
        }

        public ModelB readOne(ModelB item)
        {
            throw new NotImplementedException();
        }

        public bool update(ModelB item)
        {
            string query = "update models_b set name = '" + item.Name + "' where id=" + item.Id + ";";
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

        public void setReadStrategy(IReadStrategy<ModelB> readStrategy)
        {
            this.readStrategy = readStrategy;
        }
    }
}
