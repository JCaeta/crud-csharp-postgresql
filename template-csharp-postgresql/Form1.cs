using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace template_csharp_postgresql
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private DataTable entitiesBMap;
        // Maps the entitiesB ids with indexes of grids and list boxes
        // Map's fields
        // - id
        // - name
        // - index-grid-read
        // - index-checked-list-box

        private DataTable entitiesB;
        private Dictionary<string, Dictionary<int, DataTable>> dataEntitiesA;
        private int widthColumns = 155;

        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
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

        private void initializeEntitiesBTrackDataTable()
        {
            // Initialize entitiesB map that tracks the checked listbox
            // with the gridReadEntityB
            this.entitiesBMap = new DataTable();
            this.entitiesBMap.Columns.Add("id");
            this.entitiesBMap.Columns.Add("name");
            this.entitiesBMap.Columns.Add("index-grid-read");
            this.entitiesBMap.Columns.Add("index-checked-list-box");
        }
        
        public void deleteEntityAFromGrid(int index, int id)
        {
            this.gridReadEntityA.Rows.RemoveAt(index);
            this.dataEntitiesA["A"].Remove(id); // Delete entityA
            this.dataEntitiesA["B"].Remove(id); // Delete associated entitiesB
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
        }

        public void loadEntitiesA()
        {
            this.gridReadEntityA.Rows.Clear();
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
            this.dataEntitiesA = this.controller.getAllEntitiesA();
            int count = 0;
            foreach (DataTable entityA in this.dataEntitiesA["A"].Values)
            {
                this.gridReadEntityA.Rows.Add();
                this.gridReadEntityA.Rows[count].Cells["id"].Value = entityA.Rows[0]["id"];
                this.gridReadEntityA.Rows[count].Cells["name"].Value = entityA.Rows[0]["name"];
                count++;
            }
        }

        private void loadEntitiesB()
        {
            // This method loads entitiesB in gridReadEntityB and checkedListBoxEntitiesB
            this.entitiesB = this.controller.getAllEntitiesB();
            this.initializeEntitiesBTrackDataTable();
            int count = 0;
            this.gridReadEntityB.Rows.Clear();
            this.checkedListBoxEntititesB.Items.Clear();
            foreach (DataRow row in this.entitiesB.Rows)
            {
                this.entitiesBMap.Rows.Add();
                this.entitiesBMap.Rows[count]["id"] = row["id"];
                this.entitiesBMap.Rows[count]["name"] = row["name"];
                this.entitiesBMap.Rows[count]["index-grid-read"] = count;
                this.entitiesBMap.Rows[count]["index-checked-list-box"] = count;

                // Load read entity B grid
                this.gridReadEntityB.Rows.Add();
                this.gridReadEntityB.Rows[count].Cells["id"].Value = row["id"];
                this.gridReadEntityB.Rows[count].Cells["name"].Value = row["name"];

                // Load associated entity b checkbox in entityA create section
                this.checkedListBoxEntititesB.Items.Add(row["name"], false);
                count += 1;
            }
        }

        private void loadData()
        {
            this.loadEntitiesA();
            this.loadEntitiesB();
        }

        private void createEntityB(object sender, EventArgs e)
        {
            string name = this.textBoxNameEntityB.Text;
            this.controller.createEntityB(this, name);

            // Clear entry
            this.textBoxNameEntityB.Clear();
        }

        public void loadEntityBOnUi(int id, string name)
        {
            // To prevent loading all entities every time a new EntityB is created,
            // we'll add only the new entity to the checked listbox and grid.

            // 1) Create row and get index
            this.gridReadEntityB.Rows.Add();
            int row_index = this.gridReadEntityB.Rows.Count - 1;

            // 2) Load on the grid
            this.gridReadEntityB.Rows[row_index].Cells["id"].Value = id;
            this.gridReadEntityB.Rows[row_index].Cells["name"].Value = name;

            // 3) Load on the checked listbox
            this.checkedListBoxEntititesB.Items.Add(name, false);

            // 4) Update the entitiesBMap
            this.entitiesBMap.Rows.Add();
            int lengthMap = this.entitiesBMap.Rows.Count;
            int indexCheckedListBox = this.checkedListBoxEntititesB.Items.Count;
            this.entitiesBMap.Rows[lengthMap - 1]["id"] = id;
            this.entitiesBMap.Rows[lengthMap - 1]["name"] = name;
            this.entitiesBMap.Rows[lengthMap - 1]["index-grid-read"] = row_index;
            this.entitiesBMap.Rows[lengthMap - 1]["index-checked-list-box"] = indexCheckedListBox;
        }
        public void deleteEntityBFromUi(int index)
        {
            // To prevent loading all entities every time an EntityB is deleted,
            // we'll use the entitiesBMap to selectively delete the entity from the
            // checked listbox and grid.

            // 1) Remove from grid
            gridReadEntityB.Rows.RemoveAt(index);

            // 2) Remove from checked listbox
            DataRow[] rowsChkListBox = this.entitiesBMap.Select("[index-grid-read] = " + index);
            int indexChkListBox = int.Parse(rowsChkListBox[0]["index-checked-list-box"].ToString());
            this.checkedListBoxEntititesB.Items.RemoveAt(indexChkListBox);

            // 3) Remove from entitiesBMap
            DataRow[] rows = this.entitiesBMap.Select("[index-grid-read] = " + index);
            this.entitiesBMap.Rows.Remove(rows[0]);
        }

        private void deleteEntityB(object sender, EventArgs e)
        {
            // Get index of the selected row
            if (this.gridReadEntityB.Rows.Count > 0)
            {
                int row_index = this.gridReadEntityB.CurrentCell.RowIndex;
                int col_index = this.gridReadEntityB.Columns["Id"].Index;
                int id = int.Parse(this.gridReadEntityB[col_index, row_index].Value.ToString());
                this.controller.deleteEntityB(this, id, row_index);
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
            DataTable associatedEntitiesB = this.getCheckedEntitiesB();
            this.controller.createEntityA(this, associatedEntitiesB, name);
        }

        private DataTable getCheckedEntitiesB() 
        {
            DataTable associatedEntitiesB = new DataTable();
            associatedEntitiesB.Columns.Add("id");
            associatedEntitiesB.Columns.Add("name");

            foreach (int index in this.checkedListBoxEntititesB.CheckedIndices)
            {
                // Get the entities B ids
                DataRow[] result = this.entitiesBMap.Select("[index-checked-list-box] = " + index);
                if (result.Length > 0)
                {
                    int id = int.Parse(result[0]["id"].ToString());
                    string name = result[0]["name"].ToString();

                    associatedEntitiesB.Rows.Add();
                    int i = associatedEntitiesB.Rows.Count - 1;
                    associatedEntitiesB.Rows[i]["id"] = id;
                    associatedEntitiesB.Rows[i]["name"] = name;
                }
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
            int entAid = int.Parse(this.gridReadEntityA.Rows[selectedRow].Cells["id"].Value.ToString());
            int count = 0;
            foreach(DataRow entityB in this.dataEntitiesA["B"][entAid].Rows)
            {
                this.gridEntitiesBAssociatedEntitiesA.Rows.Add();
                this.gridEntitiesBAssociatedEntitiesA.Rows[count].Cells["id"].Value = entityB["id"];
                this.gridEntitiesBAssociatedEntitiesA.Rows[count].Cells["name"].Value = entityB["name"];
                count++;
            }
        }

        private void deleteEntityA(object sender, EventArgs e)
        {


            if (this.gridReadEntityA.CurrentCell != null)
            {
                int rowIndex = this.gridReadEntityA.CurrentCell.RowIndex;
                int id = int.Parse(this.gridReadEntityA.Rows[rowIndex].Cells["id"].Value.ToString());
                this.controller.deleteEntityA(this, id, rowIndex);
            }else
            {
                this.showWarning("No row selected. Please select a row and try again.");
            }
        }

        private void updateEntityA(object sender, EventArgs e)
        {
            if (this.gridReadEntityA.CurrentCell != null)
            {
                Dictionary<string, DataTable> dataEntityA = this.getEntityAToUpdate();
                UpdateEntityA uiUpdateEntityA = new UpdateEntityA(this, this.controller, dataEntityA);
                uiUpdateEntityA.ShowDialog();
            }
            else // If there aren't selected rows
            {
                this.showWarning("No row selected. Please select a row and try again.");
            }
        }

        private Dictionary<string, DataTable> getEntityAToUpdate()
        {
            // 1) Initialize dictionary
            DataTable entityA = new DataTable();
            entityA.Columns.Add("id");
            entityA.Columns.Add("name");

            DataTable entitiesB = new DataTable();
            entitiesB.Columns.Add("id");
            entitiesB.Columns.Add("name");
            entitiesB.Columns.Add("isAssociated");

            Dictionary<string, DataTable> dataEntityA = new Dictionary<string, DataTable>();
            dataEntityA.Add("A", entityA);
            dataEntityA.Add("B", entitiesB);

            // 2) Search data
            // Load entityA 
            int rowIndex = this.gridReadEntityA.CurrentCell.RowIndex;

            int idEntA = int.Parse(this.gridReadEntityA.Rows[rowIndex].Cells["id"].Value.ToString());
            string nameEntA = this.dataEntitiesA["A"][idEntA].Rows[0]["name"].ToString();

            dataEntityA["A"].Rows.Add();
            dataEntityA["A"].Rows[0]["id"] = idEntA;
            dataEntityA["A"].Rows[0]["name"] = nameEntA;
            DataTable allEntitiesB = this.entitiesB.Copy();

            // Load entitiesB
            int count = 0;
            foreach (DataRow row in this.dataEntitiesA["B"][idEntA].Rows)
            {
                dataEntityA["B"].Rows.Add();
                dataEntityA["B"].Rows[count]["id"] = row["id"];
                dataEntityA["B"].Rows[count]["name"] = row["name"];
                dataEntityA["B"].Rows[count]["isAssociated"] = true;

                // Delete from allEntitiesB the loaded entityB
                DataRow[] rToDel = allEntitiesB.Select("[id] = " + row["id"]);
                if (rToDel.Length > 0)
                {
                    rToDel[0].Delete();
                }
                count++;
            }

            // Load rest of entitiesB (those that are not associated)
            foreach (DataRow row in allEntitiesB.Rows)
            {
                dataEntityA["B"].Rows.Add();
                dataEntityA["B"].Rows[count]["id"] = row["id"];
                dataEntityA["B"].Rows[count]["name"] = row["name"];
                dataEntityA["B"].Rows[count]["isAssociated"] = false;
                count++;
            }
            return dataEntityA;
        }

        public void updateEntityAInGrid()
        {
            this.loadEntitiesA();
        }

        private void readEntityA(object sender, EventArgs e)
        {
            // Options that returns in binary code
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
            if(option == "01") // Option 1
            {
                this.controller.readEntityAOption1(this.textBoxEntBNameFilterA.Text);
            }
            else
            {
                if(option == "10") // Option 2
                {
                    this.controller.readEntityAOption2(this.textBoxNameFilterA.Text);
                }else
                {
                    if(option == "11")
                    {
                        this.controller.readEntityAOption3(this.textBoxNameFilterA.Text, this.textBoxEntBNameFilterA.Text);
                    }
                }
            }
        }
    }
}


