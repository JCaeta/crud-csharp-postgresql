using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Persistence.Repositories;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelB
{
    public class ReadById<EntityB> : IReadStrategy<EntityB>
    where EntityB : template_csharp_postgresql.Models.ModelB, new()
    {
        List<int> ids; 
        public List<EntityB> read(NpgsqlConnection connection)
        {
            List<EntityB> modelsB = new List<EntityB>();
            if (this.ids.Count > 0)
            {
                // 1) Execute query
                string query = this.buildQuery();
                NpgsqlDataReader result;
                using(NpgsqlCommand executor = new NpgsqlCommand(query, connection))
                {
                    result = executor.ExecuteReader();
                }
  
                // 2) Extract data
                while (result.Read())
                {
                    EntityB modelB = new EntityB();
                    modelB.Id = result.GetInt32(0);
                    modelB.Name = result.GetString(1);
                    modelsB.Add(modelB);
                }
                return modelsB;
            }
            else
            {
                throw new Exception("ReadById<EntityB>.find() -> There are no ids to find");
            }
        }

        public void setIds(List<int> ids)
        {
            this.ids = ids;
        }

        private string buildQuery()
        {
            string ids = "(" + this.ids[0];

            for (int i = 1; i < this.ids.Count; i++)
            {
                ids += ", " + this.ids[i];
            }

            ids += ")";
            return "select distinct * from models_b where id in " + ids + ";" ;
        }
    }
}
