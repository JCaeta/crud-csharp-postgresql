using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using template_csharp_postgresql.Entities;
using template_csharp_postgresql.View.Mappers;

namespace template_csharp_postgresql
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private ViewMapEntityA viewMapEntityA;
        private ViewMapEntityB viewMapEntityB;

        private int widthColumns = 155;

        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.viewMapEntityA = new ViewMapEntityA();
            this.viewMapEntityB = new ViewMapEntityB();
            this.initializeGridSearchEntityB();
            this.initializeGridSearchEntityA();
            this.initializeGridEntitiesBAssociatedEntitiesA();
            this.loadData();
        }

        private void initializeGridSearchEntityA()
        {
            this.gridReadEntityA.Columns.Add("id", "Id");
            this.gridReadEntityA.Columns["Id"].Visible = false;
            this.gridReadEntityA.Columns.Add("name", "Name");
            this.gridReadEntityA.Columns["name"].Width = this.widthColumns;
        }

        private void initializeGridSearchEntityB()
        {
            this.gridReadEntityB.Columns.Add("id", "Id");
            this.gridReadEntityB.Columns["id"].Visible = false;
            this.gridReadEntityB.Columns.Add("name", "Name");
            this.gridReadEntityB.Columns["name"].Width = this.widthColumns;
        }

        private void initializeGridEntitiesBAssociatedEntitiesA()
        {
            this.gridEntitiesBAssociatedEntitiesA.Columns.Add("id", "Id");
            this.gridEntitiesBAssociatedEntitiesA.Columns["Id"].Visible = false;
            this.gridEntitiesBAssociatedEntitiesA.Columns.Add("name", "Name");
            this.gridEntitiesBAssociatedEntitiesA.Columns["name"].Width = this.widthColumns;
        }
        
        public void deleteEntityAFromUi(int id)
        {
            int indexGrid = this.viewMapEntityA.getIndexGrid(id);
            this.gridReadEntityA.Rows.RemoveAt(indexGrid);
            this.viewMapEntityA.deleteEntityA(id);
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
        }

        //public void loadEntitiesA()
        //{
        //    this.gridReadEntityA.Rows.Clear();
        //    this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
        //    List<EntityA> entitiesA = this.controller.getAllEntitiesA();

        //    int count = 0;
        //    foreach (EntityA entityA in entitiesA)
        //    {
        //        this.gridReadEntityA.Rows.Add();
        //        this.gridReadEntityA.Rows[count].Cells["id"].Value = entityA.Id;
        //        this.gridReadEntityA.Rows[count].Cells["name"].Value = entityA.Name;
        //        this.viewMapEntityA.addEntityA(entityA, count);
        //        count++;
        //    }
        //}

        //private void loadEntitiesB()
        //{
        //    // This method loads entitiesB in gridReadEntityB and checkedListBoxEntitiesB
        //    List<EntityB> entitiesB = this.controller.getAllEntitiesB();

        //    int count = 0;
        //    this.gridReadEntityB.Rows.Clear();
        //    this.checkedListBoxEntititesB.Items.Clear();
        //    foreach (EntityB entityB in entitiesB)
        //    {
        //        this.viewMapEntityB.addEntityB(entityB, count, count);

        //        // Load read entity B grid
        //        this.gridReadEntityB.Rows.Add();
        //        this.gridReadEntityB.Rows[count].Cells["id"].Value = entityB.Id;
        //        this.gridReadEntityB.Rows[count].Cells["name"].Value = entityB.Name;

        //        // Load associated entity b checkbox in entityA create section
        //        this.checkedListBoxEntititesB.Items.Add(entityB.Name, false);
        //        count += 1;
        //    }

        //    this.viewMapEntityA.setAllEntitiesB(entitiesB);
        //}


        private void setEntitiesB(List<EntityB> entitiesB)
        {
            // This method loads entitiesB in gridReadEntityB and checkedListBoxEntitiesB

            int count = 0;
            this.gridReadEntityB.Rows.Clear();
            this.checkedListBoxEntititesB.Items.Clear();
            foreach (EntityB entityB in entitiesB)
            {
                this.viewMapEntityB.addEntityB(entityB, count, count);

                // Load read entity B grid
                this.gridReadEntityB.Rows.Add();
                this.gridReadEntityB.Rows[count].Cells["id"].Value = entityB.Id;
                this.gridReadEntityB.Rows[count].Cells["name"].Value = entityB.Name;

                // Load associated entity b checkbox in entityA create section
                this.checkedListBoxEntititesB.Items.Add(entityB.Name, false);
                count += 1;
            }

            this.viewMapEntityA.setAllEntitiesB(entitiesB);
        }


        public void setEntitiesA(List<EntityA> entitiesA)
        {
            this.gridReadEntityA.Rows.Clear();
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
            this.viewMapEntityA.Clear();

            int count = 0;
            foreach (EntityA entityA in entitiesA)
            {
                this.gridReadEntityA.Rows.Add();
                this.gridReadEntityA.Rows[count].Cells["id"].Value = entityA.Id;
                this.gridReadEntityA.Rows[count].Cells["name"].Value = entityA.Name;
                this.viewMapEntityA.addEntityA(entityA, count);
                count++;
            }

            this.viewMapEntityA.setAllEntitiesB(this.viewMapEntityB.getEntitiesB());
        }

        private void loadData()
        {
            List<EntityA> entitiesA = this.controller.getAllEntitiesA();
            this.setEntitiesA(entitiesA);

            List<EntityB> entitiesB = this.controller.getAllEntitiesB();
            this.setEntitiesB(entitiesB);
            //this.loadEntitiesA();
            //this.loadEntitiesB();
        }

        private void createEntityB(object sender, EventArgs e)
        {
            string name = this.textBoxNameEntityB.Text;
            this.controller.createEntityB(this, name);

            // Clear entry
            this.textBoxNameEntityB.Clear();
        }

        public void loadEntityBOnUi(EntityB entityB)
        {
            // To prevent loading all entities every time a new EntityB is created,
            // we'll add only the new entity to the checked listbox and grid.

            // 1) Create row and get index
            this.gridReadEntityB.Rows.Add();
            int row_index = this.gridReadEntityB.Rows.Count - 1;

            // 2) Load on the grid
            this.gridReadEntityB.Rows[row_index].Cells["id"].Value = entityB.Id;
            this.gridReadEntityB.Rows[row_index].Cells["name"].Value = entityB.Name;

            // 3) Load on the checked listbox
            this.checkedListBoxEntititesB.Items.Add(entityB.Name, false);

            // 4) Update the viewMapEntityB
            this.viewMapEntityB.addEntityB(entityB, row_index, this.checkedListBoxEntititesB.Items.Count - 1);
        }

        public void deleteEntityBFromUi(int id)
        {
            // To prevent loading all entities every time an EntityB is deleted,
            // we'll use the viewMapEntityB to selectively delete the entity from the
            // checked listbox and grid.

            // 1) Remove from grid
            gridReadEntityB.Rows.RemoveAt(this.viewMapEntityB.getGridIndex(id));
         
            // 2) Remove from checked listbox;
            this.checkedListBoxEntititesB.Items.RemoveAt(this.viewMapEntityB.getListboxIndex(id));

            // 3) Remove from viewMapEntiyB
            this.viewMapEntityB.deleteEntityB(id);

            // 4) Update viewMapEntityA
            this.viewMapEntityA.setAllEntitiesB(this.viewMapEntityB.getEntitiesB());
        }

        private void deleteEntityB(object sender, EventArgs e)
        {
            // Get index of the selected row
            if (this.gridReadEntityB.Rows.Count > 0)
            {
                int rowIndex = this.gridReadEntityB.CurrentCell.RowIndex;
                EntityB entityB = this.viewMapEntityB.getEntityBByIndexGrid(rowIndex);
                this.controller.deleteEntityB(this, entityB);
            }
        }

        public void showWarning(string message)
        {
            MessageBox.Show(message);
        }

        private void updateEntityB(object sender, EventArgs e)
        {
            int row_index = this.gridReadEntityB.CurrentCell.RowIndex;
            int id = int.Parse(this.gridReadEntityB.Rows[row_index].Cells["id"].Value.ToString());
            string name = this.gridReadEntityB.Rows[row_index].Cells["name"].Value.ToString();

            FormUpdateEntityB formUpdateEntityB = new FormUpdateEntityB(id, name, row_index, this.controller, this);
            formUpdateEntityB.ShowDialog();
        }

        public void replaceEntityBInGrid(int index, int newId, string newName)
        {
            this.gridReadEntityB.Rows[index].Cells["id"].Value = newId;
            this.gridReadEntityB.Rows[index].Cells["name"].Value = newName;
        }

        private void createEntityA(object sender, EventArgs e)
        {
            string name = this.textBoxNameEntityA.Text;
            List<EntityB> associatedEntitiesB = this.getCheckedEntitiesB();
            EntityA entityA = new EntityA(name, associatedEntitiesB);
            this.controller.createEntityA(this, entityA);
            this.textBoxNameEntityA.Text = "";
            foreach(int index in this.checkedListBoxEntititesB.CheckedIndices)
            {
                this.checkedListBoxEntititesB.SetItemChecked(index, false);
            }
        }

        public void loadEntityAOnUi(EntityA entityA)
        {
            int index = this.gridReadEntityA.Rows.Count;
            this.gridReadEntityA.Rows.Add();
            this.gridReadEntityA.Rows[index].Cells["id"].Value = entityA.Id;
            this.gridReadEntityA.Rows[index].Cells["name"].Value = entityA.Name;
            this.viewMapEntityA.addEntityA(entityA, index);
        }

        private List<EntityB> getCheckedEntitiesB()
        {
            // Get checked entities B when an EntityA will be created
            List<EntityB> associatedEntitiesB = new List<EntityB>();

            foreach (int index in this.checkedListBoxEntititesB.CheckedIndices)
            {
                // Get the checked entities B ids
                EntityB entityB = this.viewMapEntityB.getEntityBByIndexListbox(index);
                associatedEntitiesB.Add(entityB);

            }
            return associatedEntitiesB;
        }

        private void clickEntityA(object sender, DataGridViewCellEventArgs e)
        {
            this.loadEntitiesBAssociatedEntitiesA(e.RowIndex);
        }

        private void loadEntitiesBAssociatedEntitiesA(int selectedRow)
        {
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
            List<EntityB> entitiesB = this.viewMapEntityA.getEntitiesB(selectedRow);

            int count = 0;
            foreach (EntityB entityB in entitiesB)
            {
                this.gridEntitiesBAssociatedEntitiesA.Rows.Add();
                this.gridEntitiesBAssociatedEntitiesA.Rows[count].Cells["id"].Value = entityB.Id;
                this.gridEntitiesBAssociatedEntitiesA.Rows[count].Cells["name"].Value = entityB.Name;
                count++;
            }
        }

        private void deleteEntityA(object sender, EventArgs e)
        {
            if (this.gridReadEntityA.CurrentCell != null)
            {
                int rowIndex = this.gridReadEntityA.CurrentCell.RowIndex;
                int id = int.Parse(this.gridReadEntityA.Rows[rowIndex].Cells["id"].Value.ToString());
                this.controller.deleteEntityA(this, id);
            }else
            {
                this.showWarning("No row selected. Please select a row and try again.");
            }
        }
        private void updateEntityA(object sender, EventArgs e)
        {
            if (this.gridReadEntityA.CurrentCell != null)
            {
                int rowIndex = this.gridReadEntityA.CurrentCell.RowIndex;
                EntityA entityA = this.viewMapEntityA.getEntityA(rowIndex);
                List<EntityB> noAssocEntitiesB = this.viewMapEntityA.getNoAssocEntitiesB(entityA);
                UpdateEntityA uiUpdateEntityA = new UpdateEntityA(this, this.controller, entityA, noAssocEntitiesB);
                uiUpdateEntityA.ShowDialog();
            }
            else // If there aren't selected rows
            {
                this.showWarning("No row selected. Please select a row and try again.");
            }
        }

        public void updateEntityAOnUi(EntityA entityA)
        {
            this.viewMapEntityA.updateEntityA(entityA);
        }

        private void readEntityA(object sender, EventArgs e)
        {
            // Options that returns in binary code
            // Read all entitiesA: 00 (Option 0)
            // Read by EntityB name: 01 (Option 1)
            // Read by EntityA name: 10 (Option 2)
            // Read by EntityA name and EntityB name: 11 (Option 3)

            // 1) Get option
            string option = "";
            if(this.textBoxNameFilterA.Text != "")
            {
                option += "1";
            }else
            {
                option += "0";
            }

            if (this.textBoxEntBNameFilterA.Text != "")
            {
                option += "1";
            }else
            {
                option += "0";
            }

            // 2) Filter
            List<EntityA> entitiesA = new List<EntityA>();
            if (option == "00") // Option 0
            {
                entitiesA = this.controller.getAllEntitiesA();
            }
            else
            {
                if (option == "01") // Option 1
                {
                    entitiesA = this.controller.readEntityAOption1(this.textBoxEntBNameFilterA.Text);
                }
                else
                {
                    if (option == "10") // Option 2
                    {
                        entitiesA = this.controller.readEntityAOption2(this.textBoxNameFilterA.Text);
                    }
                    else
                    {
                        if (option == "11") // Option 3
                        {
                            entitiesA = this.controller.readEntityAOption3(this.textBoxNameFilterA.Text, this.textBoxEntBNameFilterA.Text);
                        }
                    }
                }
            }

            this.setEntitiesA(entitiesA);
        }

        private void clearEntityAGrid(object sender, EventArgs e)
        {
            this.textBoxNameFilterA.Text = "";
            this.textBoxEntBNameFilterA.Text = "";
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
            this.gridReadEntityA.Rows.Clear();
        }
    }
}


