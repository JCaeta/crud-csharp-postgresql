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

        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.gridSearchEntityB.AllowUserToAddRows = false;
            this.gridSearchEntityB.Columns.Add("id", "Id");
            this.gridSearchEntityB.Columns["Id"].Visible = false;
            this.gridSearchEntityB.Columns.Add("name", "Name");
            this.loadData();
        }

        private void initializeEntitiesBTrackDataTable()
        {
            this.entitiesBMap = new DataTable();
            this.entitiesBMap.Columns.Add("id");
            this.entitiesBMap.Columns.Add("name");
            this.entitiesBMap.Columns.Add("index-grid-search");
            this.entitiesBMap.Columns.Add("index-checked-list-box");
        }

        private void loadData()
        {
            DataTable entitiesB = this.controller.getAllEntitiesB();
            this.initializeEntitiesBTrackDataTable();
            int count = 0;
            foreach(DataRow row in entitiesB.Rows)
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
    }
}


