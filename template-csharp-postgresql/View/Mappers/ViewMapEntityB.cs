using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql.View.Mappers
{
    public class ViewMapEntityB
    {
        Dictionary<int, EntityB> dictIdEntitiesB;
        Dictionary<int, int> dictListEntitiesBTracking; // key: entB id | value: index listEntitiesB
        List<EntityB> listEntitiesB;
        Dictionary<int, EntityB> dictIndexGridEntitiesB;
        Dictionary<int, int> dictIdGridIndex;
        Dictionary<int, int> dictIdListboxIndex;
        Dictionary<int, EntityB> dictIndexListboxEntitiesB;

        public ViewMapEntityB()
        {
            this.dictIdEntitiesB = new Dictionary<int, EntityB>();
            this.listEntitiesB = new List<EntityB>();
            this.dictListEntitiesBTracking = new Dictionary<int, int>();
            this.dictIndexGridEntitiesB = new Dictionary<int, EntityB>();
            this.dictIdGridIndex = new Dictionary<int, int>();
            this.dictIdListboxIndex = new Dictionary<int, int>();
            this.dictIndexListboxEntitiesB = new Dictionary<int, EntityB>();
        }
        
        public void addEntityB(EntityB entityB, int indexGrid, int indexListbox)
        {
            this.dictIdEntitiesB.Add(entityB.Id, entityB);
            this.listEntitiesB.Add(entityB);
            this.dictIndexGridEntitiesB.Add(indexGrid, entityB);
            this.dictListEntitiesBTracking.Add(entityB.Id, this.listEntitiesB.Count - 1);
            this.dictIdGridIndex.Add(entityB.Id, indexGrid);
            this.dictIdListboxIndex.Add(entityB.Id, indexListbox);
            this.dictIndexListboxEntitiesB.Add(indexListbox, entityB);
        }

        public List<EntityB> getEntitiesB()
        {
            return this.listEntitiesB;
        }

        public void deleteEntityB(EntityB entityB)
        {
            this.dictIdEntitiesB.Remove(entityB.Id);
            this.listEntitiesB.RemoveAt(this.dictListEntitiesBTracking[entityB.Id]);
            this.dictListEntitiesBTracking.Remove(entityB.Id);
            this.dictIndexGridEntitiesB.Remove(this.dictIdGridIndex[entityB.Id]);
            this.dictIdGridIndex.Remove(entityB.Id);
            this.dictIdListboxIndex.Remove(entityB.Id);
            this.dictIndexListboxEntitiesB.Remove(entityB.Id);
        }

        public void deleteEntityB(int id)
        {
            this.dictIdEntitiesB.Remove(id);
            this.listEntitiesB.RemoveAt(this.dictListEntitiesBTracking[id]);
            this.dictListEntitiesBTracking.Remove(id);
            this.dictIndexGridEntitiesB.Remove(this.dictIdGridIndex[id]);
            this.dictIdGridIndex.Remove(id);
            this.dictIdListboxIndex.Remove(id);
            this.dictIndexListboxEntitiesB.Remove(id);
        }

        public EntityB getEntityBByIndexGrid(int indexGrid)
        {
            return this.dictIndexGridEntitiesB[indexGrid];
        }

        public EntityB getEntityBByIndexListbox(int indexListbox)
        {
            return this.dictIndexListboxEntitiesB[indexListbox];
        }

        public int getGridIndex(int id)
        {
            return this.dictIdGridIndex[id];
        }

        public int getListboxIndex(int id)
        {
            return this.dictIdListboxIndex[id];
        }
    }
}
