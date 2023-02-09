using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.Persistence.Repositories.FindStrategiesEntityA
{
    public class FindAllEntitiesA<EntityA> : IFindStrategy<EntityA>
    where EntityA : template_csharp_postgresql.Entities.EntityA, new()
    {
        private Helper<EntityA> helper;
        public FindAllEntitiesA()
        {
            this.helper = new Helper<EntityA>();
        }

        public List<EntityA> find(NpgsqlConnection connection)
        {
            List<EntityA> entitiesA = new List<EntityA>();
            string query = this.buildQuery();
            NpgsqlDataReader result;
            using (NpgsqlCommand executor = new NpgsqlCommand(query, connection))
            {
                result = executor.ExecuteReader();
            }

            return this.helper.convertNpgsqlDataReaderToListEntityA(result);


            //return this.helper.convertNpgsqlDataReaderToListEntityA(result);

            //Dictionary<int, EntityA> dictEntitiesA = new Dictionary<int, EntityA>();

            //while (result.Read())
            //{
            //    int entAId = result.GetInt32(0);
            //    int entBId = result.GetInt32(2);
            //    string entBName = result.GetString(3);
            //    EntityB entityB = new EntityB();
            //    entityB.Id = entBId;
            //    entityB.Name = entBName;

            //    if (!dictEntitiesA.ContainsKey(entAId))
            //    {
            //        string entAName = result.GetString(1);
            //        EntityA entityA = new EntityA();
            //        entityA.Id = entAId;
            //        entityA.Name = entAName;
            //        dictEntitiesA.Add(entAId, entityA);
            //    }
            //    dictEntitiesA[entAId].EntitiesB.Add(entityB);
            //}

            //foreach(var entA in dictEntitiesA)
            //{
            //    entitiesA.Add(entA.Value);
            //}

            //return entitiesA;
        }

        private string buildQuery()
        {
            return
            "select " +
                "entities_a.id as ent_a_id, " +
                "entities_a.name as ent_a_name, " +
                "entities_b.id as ent_b_id, " +
                "entities_b.name as ent_b_name " +
                "from entities_a " +
                "join rel_entities_a_entities_b on entities_a.id = rel_entities_a_entities_b.id_entity_a " +
                "join entities_b on entities_b.id = rel_entities_a_entities_b.id_entity_b";
        }

    }
}
