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
        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
            this.dataGridViewEntityBSearch.AllowUserToAddRows = false;
            this.dataGridViewEntityBSearch.Columns.Add("id", "Id");
            this.dataGridViewEntityBSearch.Columns["Id"].Visible = false;
            this.dataGridViewEntityBSearch.Columns.Add("name", "Name");
            this.loadData();
        }

        private void loadData()
        {
            DataTable entitiesB = this.controller.getAllEntitiesB();
            int count = 0;
            foreach(DataRow row in entitiesB.Rows)
            {
                this.dataGridViewEntityBSearch.Rows.Add();
                this.dataGridViewEntityBSearch.Rows[count].Cells["id"].Value = row["id"];
                this.dataGridViewEntityBSearch.Rows[count].Cells["name"].Value = row["name"];
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

        public void loadNewEntityB(int id, string name)
        {
            // 1) Create row and get index
            this.dataGridViewEntityBSearch.Rows.Add();
            int row_index = this.dataGridViewEntityBSearch.Rows.Count - 1;

            // 2) Load row
            this.dataGridViewEntityBSearch.Rows[row_index].Cells["id"].Value = id;
            this.dataGridViewEntityBSearch.Rows[row_index].Cells["name"].Value = name;
        }

        private void deleteEntityB(object sender, EventArgs e)
        {
            // Get index of the selected row
            if(this.dataGridViewEntityBSearch.Rows.Count > 0)
            {
                int row_index = this.dataGridViewEntityBSearch.CurrentCell.RowIndex;
                int col_index = this.dataGridViewEntityBSearch.Columns["Id"].Index;
                int id = int.Parse(this.dataGridViewEntityBSearch[col_index, row_index].Value.ToString());
                this.controller.deleteEntityB(this, id, row_index);
            }
        }

        public void deleteEntityBFromGrid(int index)
        {
            dataGridViewEntityBSearch.Rows.RemoveAt(index);
        }

        private void updateEntityB(object sender, EventArgs e)
        {
            int row_index = this.dataGridViewEntityBSearch.CurrentCell.RowIndex;
            int id = int.Parse(this.dataGridViewEntityBSearch.Rows[row_index].Cells["id"].Value.ToString());
            string name = this.dataGridViewEntityBSearch.Rows[row_index].Cells["name"].Value.ToString();

            FormUpdateEntityB formUpdateEntityB = new FormUpdateEntityB(id, name, row_index, this.controller, this);
            formUpdateEntityB.ShowDialog();
        }

        public void replaceEntityBInGrid(int index, int newId, string newName)
        {
            this.dataGridViewEntityBSearch.Rows[index].Cells["id"].Value = newId;
            this.dataGridViewEntityBSearch.Rows[index].Cells["name"].Value = newName;
        }
    }
}


