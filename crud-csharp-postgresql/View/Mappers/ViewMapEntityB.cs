using System;
using System.Collections.Generic;
using System.Text;
using crud_csharp_postgresql.Models;

namespace crud_csharp_postgresql.View.Mappers
{
    public class ViewMapModelB
    {
        private Dictionary<int, ModelB> dictIdModelsB;
        private Dictionary<int, ModelB> dictIndexGridModelB; // key: grid index | value: ModelB object
        private Dictionary<int, int> dictIdGridIndex; // key: ModelB id | value: grid index 
        private Dictionary<int, int> dictIdListboxIndex; // key: ModelB id | value: listbox index
        private Dictionary<int, ModelB> dictIndexListboxModelsB; // key: listbox index | value: ModelB object

        public ViewMapModelB()
        {
            this.dictIdModelsB = new Dictionary<int, ModelB>();
            this.dictIndexGridModelB = new Dictionary<int, ModelB>();
            this.dictIdGridIndex = new Dictionary<int, int>();
            this.dictIdListboxIndex = new Dictionary<int, int>();
            this.dictIndexListboxModelsB = new Dictionary<int, ModelB>();
        }
        
        public void addModelB(ModelB modelB, int indexGrid, int indexListbox)
        {
            this.dictIdModelsB.Add(modelB.Id, modelB);
            this.dictIndexGridModelB.Add(indexGrid, modelB);
            this.dictIdGridIndex.Add(modelB.Id, indexGrid);
            this.dictIdListboxIndex.Add(modelB.Id, indexListbox);
            this.dictIndexListboxModelsB.Add(indexListbox, modelB);
        }

        public void addModelBGrid(ModelB modelB, int indexGrid)
        {
            this.dictIdModelsB.Add(modelB.Id, modelB);
            this.dictIndexGridModelB.Add(indexGrid, modelB);
            this.dictIdGridIndex.Add(modelB.Id, indexGrid);
        }

        public void addModelBListbox(ModelB modelB, int indexListbox)
        {
            this.dictIdListboxIndex.Add(modelB.Id, indexListbox);
            this.dictIndexListboxModelsB.Add(indexListbox, modelB);
        }

        public void deleteModelB(ModelB modelB)
        {
            // 1) Delete model id
            this.dictIdModelsB.Remove(modelB.Id);

            // 2) Delete from grid dictionaries
            int gridIndex = this.dictIdGridIndex[modelB.Id];
            this.dictIndexGridModelB.Remove(gridIndex);
            this.dictIdGridIndex.Remove(modelB.Id);
            this.updateIndexesGrid(gridIndex);

            // 3) Delete from listbox dictionaries
            int listboxIndex = this.dictIdListboxIndex[modelB.Id];
            this.dictIndexListboxModelsB.Remove(listboxIndex);
            this.dictIdListboxIndex.Remove(modelB.Id);
            this.updateIndexesListbox(listboxIndex);
        }

        private void updateIndexesGrid(int gridIndex)
        {
            // 1) Get keys and values to change
            List<int> listKeys = new List<int>();
            List<ModelB> listValues = new List<ModelB>();
            foreach (int key in this.dictIndexGridModelB.Keys)
            {
                if (key > gridIndex)
                {
                    listValues.Add(this.dictIndexGridModelB[key]);
                    listKeys.Add(key);
                }
            }

            // 2) Remove old keys
            for (int i = 0; i < listKeys.Count; i++)
            {
                this.dictIndexGridModelB.Remove(listKeys[i]);
                this.dictIdGridIndex.Remove(listValues[i].Id);
            }

            // 3) Insert new keys
            for (int i = 0; i < listKeys.Count; i++)
            {
                this.dictIndexGridModelB.Add(listKeys[i] - 1, listValues[i]);
                this.dictIdGridIndex.Add(listValues[i].Id, listKeys[i] - 1);
            }
        }

        public void updateModelB(ModelB modelB)
        {
            // 1) Update model id dictionary
            this.dictIdModelsB[modelB.Id] = modelB;

            // 2) Update listbox dictionary
            int listboxIndex = this.dictIdListboxIndex[modelB.Id];
            this.dictIndexListboxModelsB[listboxIndex] = modelB;

            // 3) Update grid dictionary
            int gridIndex = this.dictIdGridIndex[modelB.Id];
            this.dictIndexGridModelB[gridIndex] = modelB;
        }

        private void updateIndexesListbox(int listboxIndex)
        {
            List<int> listKeys = new List<int>();
            List<ModelB> listValues = new List<ModelB>();
            foreach (int key in this.dictIndexListboxModelsB.Keys)
            {
                if (key > listboxIndex)
                {
                    listValues.Add(this.dictIndexListboxModelsB[key]);
                    listKeys.Add(key);
                }
            }

            for (int i = 0; i < listKeys.Count; i++)
            {
                this.dictIndexListboxModelsB.Remove(listKeys[i]);
                this.dictIndexListboxModelsB.Add(listKeys[i] - 1, listValues[i]);

                this.dictIdListboxIndex.Remove(listValues[i].Id);
                this.dictIdListboxIndex.Add(listValues[i].Id, listKeys[i] - 1);
            }
        }

        public void deleteModelB(int id)
        {
            // 1) Remove model id
            this.dictIdModelsB.Remove(id);

            // 2) Remove from grid dictionaries
            int gridIndex = this.dictIdGridIndex[id];
            this.dictIndexGridModelB.Remove(gridIndex);
            this.dictIdGridIndex.Remove(id);
            this.updateIndexesGrid(gridIndex);

            // 3) Remove from listbox dictionaries
            int listboxIndex = this.dictIdListboxIndex[id];
            this.dictIndexListboxModelsB.Remove(listboxIndex);
            this.dictIdListboxIndex.Remove(id);
            this.updateIndexesListbox(listboxIndex);
            
        }

        public ModelB getModelBByIndexGrid(int indexGrid)
        {
            return this.dictIndexGridModelB[indexGrid];
        }

        public ModelB getModelBByIndexListbox(int indexListbox)
        {
            return this.dictIndexListboxModelsB[indexListbox];
        }

        public int getGridIndex(int id)
        {
            return this.dictIdGridIndex[id];
        }

        public int getListboxIndex(int id)
        {
            return this.dictIdListboxIndex[id];
        }

        public void clearGrid()
        {
            this.dictIndexGridModelB.Clear();
            this.dictIdGridIndex.Clear();
            this.dictIdModelsB.Clear();
        }

        public void clearListbox()
        {
            this.dictIdListboxIndex.Clear();
            this.dictIndexListboxModelsB.Clear();
        }
    }
}
