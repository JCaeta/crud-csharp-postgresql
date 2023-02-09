using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace template_csharp_postgresql
{
    public partial class UpdateEntityA : Form
    {
        private Controller controller;
        private Dictionary<string, DataTable> dataEntityA;
        private Form1 mainUi;


        public UpdateEntityA(Form1 ui, Controller controller, Dictionary<string, DataTable> dataEntityA)
        {
            InitializeComponent();

            this.mainUi = ui;
            this.dataEntityA = dataEntityA;
            this.controller = controller;
            this.textBoxName.Text = this.dataEntityA["A"].Rows[0]["name"].ToString();
            this.loadEntitiesB();

        }
        
        private void loadEntitiesB()
        {
            foreach(DataRow row in this.dataEntityA["B"].Rows)
            {
                this.chkListEntititesB.Items.Add(row["name"], bool.Parse(row["isAssociated"].ToString()));
            }
        }

        private void update(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            DataTable checkedEntitiesB = new DataTable();
            checkedEntitiesB.Columns.Add("id");
            checkedEntitiesB.Columns.Add("name");

            int count = 0;
            foreach (int index in this.chkListEntititesB.CheckedIndices)
            {
                checkedEntitiesB.Rows.Add();
                checkedEntitiesB.Rows[count]["id"] = dataEntityA["B"].Rows[index]["id"];
                checkedEntitiesB.Rows[count]["name"] = dataEntityA["B"].Rows[index]["name"];
                count++;
            }
            this.dataEntityA["B"] = checkedEntitiesB;
            this.dataEntityA["A"].Rows[0]["name"] = this.textBoxName.Text;

            this.controller.updateEntityA(this.mainUi, this.dataEntityA);
            this.Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
