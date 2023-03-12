using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace crud_csharp_postgresql.View
{
    public partial class FormDatabaseInformation : Form
    {
        private Controller controller;
        private FormMain ui;
        private Dictionary<string, string> databaseInformation;

        public FormDatabaseInformation(Controller controller)
        {
            InitializeComponent();
            this.databaseInformation = new Dictionary<string, string>();
            this.databaseInformation.Add("SERVER", "");
            this.databaseInformation.Add("USER_ID", "");
            this.databaseInformation.Add("PASSWORD", "");
            this.databaseInformation.Add("DATABASE_NAME", "");

            this.controller = controller;
            string rootPath = Application.StartupPath;
            string filePath = Path.Combine(rootPath, "..\\..\\..\\database-information.txt");
            if (File.Exists(filePath))
            {
                this.loadFileData(filePath);
            }
        }

        private void loadFileData(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Do something with the line
                string[] parts = line.Split(':');
                this.databaseInformation[parts[0]] = parts[1];
            }
            reader.Close();

            this.textBoxServer.Text = this.databaseInformation["SERVER"];
            this.textBoxUserId.Text = this.databaseInformation["USER_ID"];
            this.textBoxPassword.Text = this.databaseInformation["PASSWORD"];
            this.textBoxDatabaseName.Text = this.databaseInformation["DATABASE_NAME"];
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok(object sender, EventArgs e)
        {
            this.databaseInformation["SERVER"] = this.textBoxServer.Text;
            this.databaseInformation["USER_ID"] = this.textBoxUserId.Text;
            this.databaseInformation["PASSWORD"] = this.textBoxPassword.Text;
            this.databaseInformation["DATABASE_NAME"] = this.textBoxDatabaseName.Text;

            this.controller.setDatabaseInformation(this.databaseInformation);
            if (this.controller.loadDatabaseInformation())
            {
                MessageBox.Show("The database information was updated");
            }
            else
            {
                MessageBox.Show("The data you provied is invalid. Please try again");
            }
            
            this.Close();
        }
    }
}
