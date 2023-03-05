using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Models;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB
{
    public class ReadByName<ModelB> : IReadStrategy<ModelB>
    where ModelB : template_csharp_postgresql.Models.ModelB, new()
    {
        private string name;
        private Helper<ModelB> helper;

        public ReadByName()
        {
            this.helper = new Helper<ModelB>();
        }
        public List<ModelB> read(NpgsqlConnection connection)
        {
            string query = this.buildQuery();
            NpgsqlCommand executor = new NpgsqlCommand(query, connection);
            executor.Parameters.AddWithValue("@name", this.name);
            NpgsqlDataReader result = executor.ExecuteReader();
            return this.helper.convertNpgsqlDataReaderToListModelB(result);
        }

        public void setName(string name)
        {
            this.name = name;
        }

        private string buildQuery()
        {
            return "select * from models_b where name = @name";
        }
    }
}
