using System;
using System.Collections.Generic;
using System.Text;
using crud_csharp_postgresql.Models;

namespace crud_csharp_postgresql.View.Mappers
{
    public class ViewMapModelA
    {
        private Dictionary<int, ModelA> dictIdModelA;
        private Dictionary<int, ModelA> dictIndexGridModelA; // key: grid index | value: ModelA
        private Dictionary<int, int> dictIdGridIndex; // key: ModelA id| value: grid index
        private Dictionary<int, ModelB> dictAllModelsB; // key: ModelB id | value: ModelB

        public ViewMapModelA()
        {
            this.dictIdModelA = new Dictionary<int, ModelA>();
            this.dictIndexGridModelA = new Dictionary<int, ModelA>();
            this.dictIdGridIndex = new Dictionary<int, int>();
            this.dictAllModelsB = new Dictionary<int, ModelB>();
        }

        public void Clear()
        {
            this.dictIdModelA.Clear();
            this.dictIndexGridModelA.Clear();
            this.dictIdGridIndex.Clear();
            this.dictAllModelsB.Clear();
        }

        public void addModelA(ModelA modelA, int indexGrid)
        {
            this.dictIdModelA.Add(modelA.Id, modelA);
            this.dictIndexGridModelA.Add(indexGrid, modelA);
            this.dictIdGridIndex.Add(modelA.Id, indexGrid);
        }

        public void updateModelA(ModelA modelA)
        {
            this.dictIdModelA[modelA.Id] = modelA;
            this.dictIndexGridModelA[this.dictIdGridIndex[modelA.Id]] = modelA;
        }

        public List<ModelB> getModelsB(int indexGrid)
        {
            return this.dictIndexGridModelA[indexGrid].ModelsB;
        }

        public void addModelB(ModelB modelB)
        {
            this.dictAllModelsB.Add(modelB.Id, modelB);
        }

        public void deleteModelA(int id)
        {
            // 1) Delete model id
            this.dictIdModelA.Remove(id);

            // 2) Delete from grid dictionaries
            int gridIndex = this.dictIdGridIndex[id];
            this.dictIndexGridModelA.Remove(gridIndex);
            this.dictIdGridIndex.Remove(id);

            // 3) Update indexes in the grid dictionaries
            this.updateIndexesGrid(gridIndex);
        }

        private void updateIndexesGrid(int gridIndex)
        {
            // 1) Get keys and values to change
            List<int> listKeys = new List<int>();
            List<ModelA> listValues = new List<ModelA>();
            foreach (int key in this.dictIndexGridModelA.Keys)
            {
                if (key > gridIndex)
                {
                    listValues.Add(this.dictIndexGridModelA[key]);
                    listKeys.Add(key);
                }
            }

            // 2) Remove old keys
            for (int i = 0; i < listKeys.Count; i++)
            {
                this.dictIndexGridModelA.Remove(listKeys[i]);
                this.dictIdGridIndex.Remove(listValues[i].Id);
            }

            // 3) Insert new keys
            for (int i = 0; i < listKeys.Count; i++)
            {
                this.dictIndexGridModelA.Add(listKeys[i] - 1, listValues[i]);
                this.dictIdGridIndex.Add(listValues[i].Id, listKeys[i] - 1);
            }
        }

        public int getIndexGrid(int id)
        {
            return this.dictIdGridIndex[id];
        }

        public ModelA getModelA(int indexGrid)
        {
            return this.dictIndexGridModelA[indexGrid];
        }

        public void setAllModelsB(List<ModelB> modelsB)
        {
            this.dictAllModelsB.Clear();
            //this.modelsB = modelsB;
            foreach(ModelB modelB in modelsB)
            {
                this.dictAllModelsB.Add(modelB.Id, modelB);
            }
        }

        public List<ModelB> getAllModelsB()
        {
            return this.convertModelsBDictToList(this.dictAllModelsB);
        }

        public void deleteModelB(int id)
        {
            this.dictAllModelsB.Remove(id);
        }

        public List<ModelB> getNoAssocModelsB(ModelA modelA)
        {
            /*
            This method takes a ModelA object as input and 
            returns a list of ModelB objects that are not 
            associated with it. 
            
            It used to give the list of not associated ModelB objects to
            the FormUpdateModelA
            */

            // 1) Create a deep copy of the dict
            // The dict is necessary to locate the modelB by ModelA id wihtout using if
            // statement
            Dictionary<int, ModelB> copyDict = this.copyModelsBDictionary();
            foreach (ModelB modelB in modelA.ModelsB)
            {
                copyDict.Remove(modelB.Id);
            }

            // 2) Return a list
            return this.convertModelsBDictToList(copyDict);
        }

        private Dictionary<int, ModelB> copyModelsBDictionary()
        {
            Dictionary<int, ModelB> newDictionary = new Dictionary<int, ModelB>();
            foreach (KeyValuePair<int, ModelB> entry in this.dictAllModelsB)
            {
                newDictionary.Add(entry.Key, entry.Value);
            }

            return newDictionary;
        }

        private List<ModelB> convertModelsBDictToList(Dictionary<int, ModelB> dict)
        {
            List<ModelB> modelsB = new List<ModelB>();
            foreach (KeyValuePair<int, ModelB> entry in dict)
            {
                modelsB.Add(entry.Value);
            }
            return modelsB;
        }
    }
}
