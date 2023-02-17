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
        private DataTable entitiesBMap; // Maps the entitiesB ids with indexes of grids and list boxes
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
            this.gridSearchEntityA.Columns.Add("id", "Id");
            this.gridSearchEntityA.Columns["Id"].Visible = false;
            this.gridSearchEntityA.Columns.Add("name", "Name");
            this.gridSearchEntityA.Columns["name"].Width = this.widthColumns;
        }

        private void initializeGridSearchEntityB()
        {
            this.gridSearchEntityB.Columns.Add("id", "Id");
            this.gridSearchEntityB.Columns["id"].Visible = false;
            this.gridSearchEntityB.Columns.Add("name", "Name");
            this.gridSearchEntityB.Columns["name"].Width = this.widthColumns;
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
            this.entitiesBMap = new DataTable();
            this.entitiesBMap.Columns.Add("id");
            this.entitiesBMap.Columns.Add("name");
            this.entitiesBMap.Columns.Add("index-grid-search");
            this.entitiesBMap.Columns.Add("index-checked-list-box");
        }
        
        public void deleteEntityAFromGrid(int index, int id)
        {
            this.gridSearchEntityA.Rows.RemoveAt(index);
            this.dataEntitiesA["A"].Remove(id); // Delete entityA
            this.dataEntitiesA["B"].Remove(id); // Delete associated entitiesB
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
        }

        public void loadEntitiesA()
        {
            this.gridSearchEntityA.Rows.Clear();
            this.gridEntitiesBAssociatedEntitiesA.Rows.Clear();
            this.dataEntitiesA = this.controller.getAllEntitiesA();
            int count = 0;
            foreach (DataTable entityA in this.dataEntitiesA["A"].Values)
            {
                this.gridSearchEntityA.Rows.Add();
                this.gridSearchEntityA.Rows[count].Cells["id"].Value = entityA.Rows[0]["id"];
                this.gridSearchEntityA.Rows[count].Cells["name"].Value = entityA.Rows[0]["name"];
                count++;
            }
        }

        private void loadEntitiesB()
        {
            this.entitiesB = this.controller.getAllEntitiesB();
            this.initializeEntitiesBTrackDataTable();
            int count = 0;
            foreach (DataRow row in this.entitiesB.Rows)
            {
                this.entitiesBMap.Rows.Add();
                this.entitiesBMap.Rows[count]["id"] = row["id"];
                this.entitiesBMap.Rows[count]["name"] = row["name"];
                this.entitiesBMap.Rows[count]["index-grid-search"] = count;
                this.entitiesBMap.Rows[count]["index-checked-list-box"] = count;

                // Load search entity B grid
                this.gridSearchEntityB.Rows.Add();
                this.gridSearchEntityB.Rows[count].Cells["id"].Value = row["id"];
                this.gridSearchEntityB.Rows[count].Cells["name"].Value = row["name"];

                // Load associated entity b checkbox in entityA insert section
                this.checkedListBoxEntititesB.Items.Add(row["name"], false);
                count += 1;
            }
        }

        private void loadData()
        {
            this.loadEntitiesA();
            this.loadEntitiesB();
        }

        private void insertEntityB(object sender, EventArgs e)
        {
            string name = this.textBoxNameEntityB.Text;
            this.controller.insertEntityB(this, name);

            // Clear entry
            this.textBoxNameEntityB.Clear();
        }

        public void loadNewEntityBInGridSearch(int id, string name)
        {
            // 1) Create row and get index
            this.gridSearchEntityB.Rows.Add();
            int row_index = this.gridSearchEntityB.Rows.Count - 1;

            // 2) Load row
            this.gridSearchEntityB.Rows[row_index].Cells["id"].Value = id;
            this.gridSearchEntityB.Rows[row_index].Cells["name"].Value = name;
        }

        private void deleteEntityB(object sender, EventArgs e)
        {
            // Get index of the selected row
            if(this.gridSearchEntityB.Rows.Count > 0)
            {
                int row_index = this.gridSearchEntityB.CurrentCell.RowIndex;
                int col_index = this.gridSearchEntityB.Columns["Id"].Index;
                int id = int.Parse(this.gridSearchEntityB[col_index, row_index].Value.ToString());
                this.controller.deleteEntityB(this, id, row_index);
            }
        }

        public void showWarning(string message)
        {
            MessageBox.Show(message);
        }

        public void deleteEntityBFromGrid(int index)
        {
            gridSearchEntityB.Rows.RemoveAt(index);
        }

        private void updateEntityB(object sender, EventArgs e)
        {
            int row_index = this.gridSearchEntityB.CurrentCell.RowIndex;
            int id = int.Parse(this.gridSearchEntityB.Rows[row_index].Cells["id"].Value.ToString());
            string name = this.gridSearchEntityB.Rows[row_index].Cells["name"].Value.ToString();

            FormUpdateEntityB formUpdateEntityB = new FormUpdateEntityB(id, name, row_index, this.controller, this);
            formUpdateEntityB.ShowDialog();
        }

        public void replaceEntityBInGrid(int index, int newId, string newName)
        {
            this.gridSearchEntityB.Rows[index].Cells["id"].Value = newId;
            this.gridSearchEntityB.Rows[index].Cells["name"].Value = newName;
        }

        private void insertEntityA(object sender, EventArgs e)
        {
            string name = this.textBoxNameEntityA.Text;
            DataTable associatedEntitiesB = this.getCheckedEntitiesB();
            this.controller.insertEntityA(this, associatedEntitiesB, name);
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
            int entAid = int.Parse(this.gridSearchEntityA.Rows[selectedRow].Cells["id"].Value.ToString());
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
            if(this.gridSearchEntityA.CurrentCell != null)
            {
                int rowIndex = this.gridSearchEntityA.CurrentCell.RowIndex;
                int id = int.Parse(this.gridSearchEntityA.Rows[rowIndex].Cells["id"].Value.ToString());
                this.controller.deleteEntityA(this, id, rowIndex);
            }else
            {
                this.showWarning("No row selected. Please select a row and try again.");
            }
        }

        private void updateEntityA(object sender, EventArgs e)
        {
            if (this.gridSearchEntityA.CurrentCell != null)
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
            int rowIndex = this.gridSearchEntityA.CurrentCell.RowIndex;

            int idEntA = int.Parse(this.gridSearchEntityA.Rows[rowIndex].Cells["id"].Value.ToString());
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

        private void filterEntityA(object sender, EventArgs e)
        {
            // Options that returns in binary code
            // Find by EntityB name: 01 (Option 1)
            // Find by EntityA name: 10 (Option 2)
            // Find by EntityA name and EntityB name: 11 (Option 3)

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
                this.controller.filterEntityAOption1(this.textBoxEntBNameFilterA.Text);
            }
            else
            {
                if(option == "10") // Option 2
                {
                    this.controller.filterEntityAOption2(this.textBoxNameFilterA.Text);
                }else
                {
                    if(option == "11")
                    {
                        this.controller.filterEntityAOption3(this.textBoxNameFilterA.Text, this.textBoxEntBNameFilterA.Text);
                    }
                }

            }
        }
    }
}


