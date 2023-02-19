using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;
using Npgsql;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesEntityA
{

    public class Helper<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA, new()
    {
        public List<EntityA> convertNpgsqlDataReaderToListEntityA(NpgsqlDataReader result)
        {
            Dictionary<int, EntityA> dictEntitiesA = new Dictionary<int, EntityA>();
            List<EntityA> entitiesA = new List<EntityA>();
            while (result.Read())
            {
                // If there are at least 1 EntityA
                if (!result.IsDBNull(0))
                {
                    int entAId = result.GetInt32(0);

                    if (!dictEntitiesA.ContainsKey(entAId))
                    {
                        string entAName = result.GetString(1);
                        EntityA entityA = new EntityA();
                        entityA.Id = entAId;
                        entityA.Name = entAName;
                        dictEntitiesA.Add(entAId, entityA);
                    }

                    // If there are at least 1 EntityB
                    if (!result.IsDBNull(2))
                    {
                        int entBId = result.GetInt32(2);
                        string entBName = result.GetString(3);
                        EntityB entityB = new EntityB();
                        entityB.Id = entBId;
                        entityB.Name = entBName;
                        dictEntitiesA[entAId].EntitiesB.Add(entityB);
                    }
                }
            }

            foreach (var entA in dictEntitiesA)
            {
                entitiesA.Add(entA.Value);
            }

            return entitiesA;
        }
    }
}


