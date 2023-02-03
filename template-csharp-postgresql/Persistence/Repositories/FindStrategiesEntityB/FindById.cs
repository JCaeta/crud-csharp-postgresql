using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Persistence.Repositories;

namespace template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityB
{
    public class FindById<EntityB> : IFindStrategy<EntityB>
    where EntityB : template_csharp_postgresql.Entities.EntityB, new()
    {
        List<int> ids; 
        public List<EntityB> find(NpgsqlConnection connection, NpgsqlTransaction transaction)
        {
            List<EntityB> entitiesB = new List<EntityB>();
            if (this.ids.Count > 0)
            {
                // 1) Execute query
                string query = this.buildQuery();
                NpgsqlDataReader result;
                using(NpgsqlCommand executor = new NpgsqlCommand(query, connection, transaction))
                {
                    result = executor.ExecuteReader();
                }
  
                // 2) Extract data
                while (result.Read())
                {
                    EntityB entityB = new EntityB();
                    entityB.Id = result.GetInt32(0);
                    entityB.Name = result.GetString(1);
                    entitiesB.Add(entityB);
                }
                return entitiesB;
            }
            else
            {
                throw new Exception("FindById<EntityB>.find() -> There are no ids to find");
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
            return "select distinct * from entities_b where id in " + ids + ";" ;
        }
    }
}
