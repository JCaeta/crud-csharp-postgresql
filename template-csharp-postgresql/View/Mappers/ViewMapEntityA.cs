using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.View.Mappers
{
    public class ViewMapEntityA
    {
        Dictionary<int, EntityA> dictIdEntityA;
        Dictionary<int, EntityA> dictIndexGridEntityA; // key: grid index | value: EntityA
        Dictionary<int, int> dictIdIndex; // key: EntityA id| value: grid index
        Dictionary<int, EntityB> dictAllEntitiesB;

        public ViewMapEntityA()
        {
            this.dictIdEntityA = new Dictionary<int, EntityA>();
            this.dictIndexGridEntityA = new Dictionary<int, EntityA>();
            this.dictIdIndex = new Dictionary<int, int>();
            this.dictAllEntitiesB = new Dictionary<int, EntityB>();
        }

        public void Clear()
        {
            this.dictIdEntityA.Clear();
            this.dictIndexGridEntityA.Clear();
            this.dictIdIndex.Clear();
            this.dictAllEntitiesB.Clear();
        }

        public void addEntityA(EntityA entityA, int indexGrid)
        {
            this.dictIdEntityA.Add(entityA.Id, entityA);
            this.dictIndexGridEntityA.Add(indexGrid, entityA);
            this.dictIdIndex.Add(entityA.Id, indexGrid);
        }

        public void updateEntityA(EntityA entityA)
        {
            this.dictIdEntityA[entityA.Id] = entityA;
            this.dictIndexGridEntityA[this.dictIdIndex[entityA.Id]] = entityA;
        }

        public List<EntityB> getEntitiesB(int indexGrid)
        {
            return this.dictIndexGridEntityA[indexGrid].EntitiesB;
        }


        public void deleteEntityA(int id)
        {
            this.dictIdEntityA.Remove(id);
            this.dictIndexGridEntityA.Remove(this.dictIdIndex[id]);
            this.dictIdIndex.Remove(id);
        }

        public int getIndexGrid(int id)
        {
            return this.dictIdIndex[id];
        }

        public EntityA getEntityA(int indexGrid)
        {
            return this.dictIndexGridEntityA[indexGrid];
        }

        public void setAllEntitiesB(List<EntityB> entitiesB)
        {
            this.dictAllEntitiesB.Clear();
            foreach(EntityB entityB in entitiesB)
            {
                this.dictAllEntitiesB.Add(entityB.Id, entityB);
            }
        }

        public List<EntityB> getNoAssocEntitiesB(EntityA entityA)
        {
            Dictionary<int, EntityB> copyDict = this.copyEntitiesBDictionary();
            foreach(EntityB entityB in entityA.EntitiesB)
            {
                copyDict.Remove(entityB.Id);
            }
            return this.convertEntitiesBDictToList(copyDict);

        }

        private Dictionary<int, EntityB> copyEntitiesBDictionary()
        {
            Dictionary<int, EntityB> newDictionary = new Dictionary<int, EntityB>();
            foreach (KeyValuePair<int, EntityB> entry in this.dictAllEntitiesB)
            {
                newDictionary.Add(entry.Key, entry.Value);
            }

            return newDictionary;
        }

        private List<EntityB> convertEntitiesBDictToList(Dictionary<int, EntityB> dict)
        {
            List<EntityB> entitiesB = new List<EntityB>();
            foreach (KeyValuePair<int, EntityB> entry in dict)
            {
                entitiesB.Add(entry.Value);
            }
            return entitiesB;
        }

    }
}
