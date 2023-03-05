using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Models;
using Npgsql;

namespace template_csharp_postgresql.Persistence.Repositories.ReadStrategiesModelA
{

    public class Helper<ModelA>
    where ModelA : template_csharp_postgresql.Models.ModelA, new()
    {
        public List<ModelA> convertNpgsqlDataReaderToListModelA(NpgsqlDataReader result)
        {
            Dictionary<int, ModelA> dictModelsA = new Dictionary<int, ModelA>();
            List<ModelA> modelsA = new List<ModelA>();
            while (result.Read())
            {
                // If there are at least 1 ModelA
                if (!result.IsDBNull(0))
                {
                    int modAId = result.GetInt32(0);

                    if (!dictModelsA.ContainsKey(modAId))
                    {
                        string modAName = result.GetString(1);
                        ModelA modelA = new ModelA();
                        modelA.Id = modAId;
                        modelA.Name = modAName;
                        dictModelsA.Add(modAId, modelA);
                    }

                    // If there are at least 1 ModelB
                    if (!result.IsDBNull(2))
                    {
                        int modBId = result.GetInt32(2);
                        string modBName = result.GetString(3);
                        ModelB modelB = new ModelB();
                        modelB.Id = modBId;
                        modelB.Name = modBName;
                        dictModelsA[modAId].ModelsB.Add(modelB);
                    }
                }
            }

            foreach (var modA in dictModelsA)
            {
                modelsA.Add(modA.Value);
            }

            return modelsA;
        }
    }
}


