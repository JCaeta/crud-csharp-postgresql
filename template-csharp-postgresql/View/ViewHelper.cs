using System;
using System.Collections.Generic;
using System.Text;
using template_csharp_postgresql.View.Mappers;
using template_csharp_postgresql.Models;

namespace template_csharp_postgresql.View
{
    public class ViewHelper
    {
        private FormMain ui; // User interface
        private ViewMapModelA viewMapModelA;
        private ViewMapModelB viewMapModelB;
        private int widthColumns = 155;
        public ViewHelper(FormMain ui)
        {
            this.ui = ui;
            this.viewMapModelA = new ViewMapModelA();
            this.viewMapModelB = new ViewMapModelB();
        }
        public void initializeForm()
        {
            this.initializeGridSearchModelB();
            this.initializeGridSearchModelA();
            this.initializeGridModelsBAssociatedModelsA();
        }

        private void initializeGridSearchModelA()
        {
            this.ui.gridReadModelA.Columns.Add("id", "Id");
            this.ui.gridReadModelA.Columns["Id"].Visible = false;
            this.ui.gridReadModelA.Columns.Add("name", "Name");
            this.ui.gridReadModelA.Columns["name"].Width = this.widthColumns;
        }

        private void initializeGridSearchModelB()
        {
            this.ui.gridReadModelB.Columns.Add("id", "Id");
            this.ui.gridReadModelB.Columns["id"].Visible = false;
            this.ui.gridReadModelB.Columns.Add("name", "Name");
            this.ui.gridReadModelB.Columns["name"].Width = this.widthColumns;
        }

        private void initializeGridModelsBAssociatedModelsA()
        {
            this.ui.gridModelsBAssociatedModelsA.Columns.Add("id", "Id");
            this.ui.gridModelsBAssociatedModelsA.Columns["Id"].Visible = false;
            this.ui.gridModelsBAssociatedModelsA.Columns.Add("name", "Name");
            this.ui.gridModelsBAssociatedModelsA.Columns["name"].Width = this.widthColumns;
        }

        public void setModelsA(List<ModelA> modelsA)
        {
            this.ui.gridReadModelA.Rows.Clear();
            this.ui.gridModelsBAssociatedModelsA.Rows.Clear();
            this.viewMapModelA.Clear();

            int count = 0;
            List<ModelB> modelsB = new List<ModelB>();
            foreach (ModelA modelA in modelsA)
            {
                this.ui.gridReadModelA.Rows.Add();
                this.ui.gridReadModelA.Rows[count].Cells["id"].Value = modelA.Id;
                this.ui.gridReadModelA.Rows[count].Cells["name"].Value = modelA.Name;
                this.viewMapModelA.addModelA(modelA, count);
                //modelsB.AddRange(modelA.ModelsB);
                count++;
            }
        }

        public void setModelsB(List<ModelB> modelsB)
        {
            // This method set the ModelB object that are on the UI
            this.viewMapModelA.setAllModelsB(modelsB);
            this.setModelsBGrid(modelsB);
            this.setModelsBListbox(modelsB);
        }

        public void setModelsBGrid(List<ModelB> modelsB)
        {
            // This method set only the grid ModelB objects
            this.ui.gridReadModelB.Rows.Clear();
            this.viewMapModelB.clearGrid();

            int count = 0;
            foreach (ModelB modelB in modelsB)
            {
                this.ui.gridReadModelB.Rows.Add();
                this.ui.gridReadModelB.Rows[count].Cells["id"].Value = modelB.Id;
                this.ui.gridReadModelB.Rows[count].Cells["name"].Value = modelB.Name;
                this.viewMapModelB.addModelBGrid(modelB, count);
                count++;
            }
        }

        private void setModelsBListbox(List<ModelB> modelsB)
        {
            // This method set only the listbox ModelB objects
            this.ui.checkedListBoxModelsB.Items.Clear();
            this.viewMapModelB.clearListbox();
            int count = 0;
            foreach (ModelB modelB in modelsB)
            {
                this.ui.checkedListBoxModelsB.Items.Add(modelB.Name, false);
                this.viewMapModelB.addModelBListbox(modelB, count);
                count++;
            }
        }

        public ModelB getModelBToDelete()
        {
            int rowIndex = this.ui.gridReadModelB.CurrentCell.RowIndex;
            return this.viewMapModelB.getModelBByIndexGrid(rowIndex);
        }

        public ModelB getModelBToUpdate()
        {
            int rowIndex = this.ui.gridReadModelB.CurrentCell.RowIndex;
            return this.viewMapModelB.getModelBByIndexGrid(rowIndex);
            //int id = int.Parse(this.ui.gridReadModelB.Rows[row_index].Cells["id"].Value.ToString());
            //ModelB modelB = this.viewMapModelB.get

            //string name = this.ui.gridReadModelB.Rows[row_index].Cells["name"].Value.ToString();

        }


        public void deleteModelB(int id)
        {
            // To prevent loading all models every time an ModelB is deleted,
            // we'll use the viewMapModelB to selectively delete the model from the
            // checked listbox and grid.

            // 1) Remove from grid
            this.ui.gridReadModelB.Rows.RemoveAt(this.viewMapModelB.getGridIndex(id));

            // 2) Remove from checked listbox;
            this.ui.checkedListBoxModelsB.Items.RemoveAt(this.viewMapModelB.getListboxIndex(id));

            // 3) Remove from viewMapEntiyB and viewMapEntityA
            this.viewMapModelB.deleteModelB(id);
            this.viewMapModelA.deleteModelB(id);
        }

        public void createModelA(ModelA modelA)
        {
            int gridIndex = this.ui.gridReadModelA.Rows.Count;
            this.ui.gridReadModelA.Rows.Add();
            this.ui.gridReadModelA.Rows[gridIndex].Cells["id"].Value = modelA.Id;
            this.ui.gridReadModelA.Rows[gridIndex].Cells["name"].Value = modelA.Name;
            this.viewMapModelA.addModelA(modelA, gridIndex);

            this.ui.textBoxNameModelA.Text = "";
            foreach (int index in this.ui.checkedListBoxModelsB.CheckedIndices)
            {
                this.ui.checkedListBoxModelsB.SetItemChecked(index, false);
            }
        }

        public void loadModelsBAssociatedModelsA(int selectedRow)
        {
            this.ui.gridModelsBAssociatedModelsA.Rows.Clear();
            List<ModelB> modelsB = this.viewMapModelA.getModelsB(selectedRow);

            int count = 0;
            foreach (ModelB modelB in modelsB)
            {
                this.ui.gridModelsBAssociatedModelsA.Rows.Add();
                this.ui.gridModelsBAssociatedModelsA.Rows[count].Cells["id"].Value = modelB.Id;
                this.ui.gridModelsBAssociatedModelsA.Rows[count].Cells["name"].Value = modelB.Name;
                count++;
            }
        }

        public ModelA getModelAToCreate()
        {
            string name = this.ui.textBoxNameModelA.Text;
            List<ModelB> associatedModelsB = this.getCheckedModelsB();
            return new ModelA(name, associatedModelsB);
        }

        private List<ModelB> getCheckedModelsB()
        {
            // Get checked models B when an ModelA will be created
            List<ModelB> associatedModelsB = new List<ModelB>();

            foreach (int index in this.ui.checkedListBoxModelsB.CheckedIndices)
            {
                // Get the checked models B ids
                ModelB modelB = this.viewMapModelB.getModelBByIndexListbox(index);
                associatedModelsB.Add(modelB);

            }
            return associatedModelsB;
        }

        public int getSelectedModelAId()
        {
            int rowIndex = this.ui.gridReadModelA.CurrentCell.RowIndex;
            return int.Parse(this.ui.gridReadModelA.Rows[rowIndex].Cells["id"].Value.ToString());

        }

        public void deleteModelA(int id)
        {
            int indexGrid = this.viewMapModelA.getIndexGrid(id);
            this.ui.gridReadModelA.Rows.RemoveAt(indexGrid);
            this.viewMapModelA.deleteModelA(id);
            this.ui.gridModelsBAssociatedModelsA.Rows.Clear();
        }

        public void openFormUpdateModelA(Controller controller)
        {
            int rowIndex = this.ui.gridReadModelA.CurrentCell.RowIndex;
            ModelA modelA = this.viewMapModelA.getModelA(rowIndex);
            List<ModelB> noAssocModelsB = this.viewMapModelA.getNoAssocModelsB(modelA);
            FormUpdateModelA uiUpdateModelA = new FormUpdateModelA(this, controller, modelA, noAssocModelsB);
            uiUpdateModelA.ShowDialog();
        }

        public void updateModelA(ModelA modelA)
        {
            this.viewMapModelA.updateModelA(modelA);
        }

        public void clearModelAGrid()
        {
            this.ui.textBoxNameFilterA.Text = "";
            this.ui.textBoxModBNameFilterA.Text = "";
            this.ui.gridModelsBAssociatedModelsA.Rows.Clear();
            this.ui.gridReadModelA.Rows.Clear();
        }

        public void clearModelBGrid()
        {
            this.ui.textBoxNameFilterB.Text = "";
            this.ui.gridReadModelB.Rows.Clear();
        }

        public string getNameToFilterModelB()
        {
            return this.ui.textBoxNameFilterB.Text;
        }

        public void createModelB(ModelB modelB)
        {
            // To prevent loading all models every time a new ModelB is created,
            // we'll add only the new model to the checked listbox and grid.

            // 1) Create row and get index
            this.ui.gridReadModelB.Rows.Add();
            int row_index = this.ui.gridReadModelB.Rows.Count - 1;

            // 2) Load on the grid
            this.ui.gridReadModelB.Rows[row_index].Cells["id"].Value = modelB.Id;
            this.ui.gridReadModelB.Rows[row_index].Cells["name"].Value = modelB.Name;

            // 3) Load on the checked listbox
            this.ui.checkedListBoxModelsB.Items.Add(modelB.Name, false);

            // 4) Update the viewMapModelB and the viewMapModelA
            this.viewMapModelB.addModelB(modelB, row_index, this.ui.checkedListBoxModelsB.Items.Count - 1);
            this.viewMapModelA.addModelB(modelB);

            // 5) Clear textbox
            this.ui.textBoxNameModelB.Clear();
        }

        public string getNameToCreateModelB()
        {
            return this.ui.textBoxNameModelB.Text;

        }

        public void openFormUpdateModelB(Controller controller)
        {
            ModelB modelB = this.getModelBToUpdate();
            FormUpdateModelB formUpdateModelB = new FormUpdateModelB(modelB, controller, this);
            formUpdateModelB.ShowDialog();
        }

        public void updateModelB(ModelB modelB)
        {
            this.viewMapModelB.updateModelB(modelB);
            int gridIndex = this.viewMapModelB.getGridIndex(modelB.Id);
            int listboxIndex = this.viewMapModelB.getListboxIndex(modelB.Id);
            this.ui.gridReadModelB.Rows[gridIndex].Cells["name"].Value = modelB.Name;
            this.ui.checkedListBoxModelsB.Items[listboxIndex] = modelB.Name;

            this.viewMapModelB.updateModelB(modelB);
        }

        //public void loadModelAOnUi(ModelA modelA)
        //{
        //    int index = this.gridReadModelA.Rows.Count;
        //    this.gridReadModelA.Rows.Add();
        //    this.gridReadModelA.Rows[index].Cells["id"].Value = modelA.Id;
        //    this.gridReadModelA.Rows[index].Cells["name"].Value = modelA.Name;
        //    this.viewMapModelA.addModelA(modelA, index);
        //}
    }
}
