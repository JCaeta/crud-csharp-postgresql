using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using template_csharp_postgresql.Models;
using template_csharp_postgresql.View.Mappers;
using template_csharp_postgresql.View;

namespace template_csharp_postgresql
{
    public partial class FormMain : Form
    {
        private Controller controller;
        private ViewHelper viewHelper;

        public FormMain()
        {
            InitializeComponent();
            this.viewHelper = new ViewHelper(this);
            this.controller = new Controller();

            this.viewHelper.initializeForm();
            if (!this.controller.loadDatabaseInformation())
            {
                MessageBox.Show("The database information is incorrect or has " +
                    "not been configured. Please go to 'Configuration' to enter " +
                    "your database information.");
                this.viewHelper.enableForm(false);
            }
            else
            {
                this.readData();
            }
        }
        private void setDatabaseConfiguration(object sender, EventArgs e)
        {
            FormDatabaseInformation formConfiguration = new FormDatabaseInformation(this.controller);
            formConfiguration.ShowDialog();

            if (this.controller.isDatabaseInformationConfigured())
            {
                this.viewHelper.enableForm(true);
                this.readData();
            }
        }

        public void readData()
        {
            List<ModelA> modelsA = this.controller.readAllModelsA();
            this.viewHelper.setModelsA(modelsA);

            List<ModelB> modelsB = this.controller.readAllModelsB();
            this.viewHelper.setModelsB(modelsB);
        }

        private void createModelB(object sender, EventArgs e)
        {
            string name = this.viewHelper.getNameToCreateModelB();
            ModelB modelB = this.controller.createModelB(name);
            this.viewHelper.createModelB(modelB);
        }

        private void readModelB(object sender, EventArgs e)
        {
            string name = this.viewHelper.getNameToFilterModelB();
            List<ModelB> modelsB;
            if (name != "")
            {
                // Option 0
                modelsB = this.controller.readModelBByName(name);
            }
            else
            {
                // Option 1
                modelsB = this.controller.readAllModelsB();
            }
            this.viewHelper.setModelsBGrid(modelsB);
        }

        private void updateModelB(object sender, EventArgs e)
        {
            this.viewHelper.openFormUpdateModelB(this.controller);
        }

        private void deleteModelB(object sender, EventArgs e)
        {
            // Get index of the selected row
            if (this.gridReadModelB.Rows.Count > 0)
            {
                ModelB modelB = this.viewHelper.getModelBToDelete();
                if(this.controller.deleteModelB(modelB))
                {
                    this.viewHelper.deleteModelB(modelB.Id);
                }
                else
                {
                    MessageBox.Show("The ModelB object could not be deleted");
                }
            }
        }

        private void createModelA(object sender, EventArgs e)
        {
            ModelA modelA = this.viewHelper.getModelAToCreate();
            modelA = this.controller.createModelA(modelA);
            this.viewHelper.createModelA(modelA);
        }

        private void readModelA(object sender, EventArgs e)
        {
            // Options that returns in binary code
            // Read all modelsA: 00 (Option 0)
            // Read by ModelB name: 01 (Option 1)
            // Read by ModelA name: 10 (Option 2)
            // Read by ModelA name and ModelB name: 11 (Option 3)

            // 1) Get option
            string option = "";
            if (this.textBoxNameFilterA.Text != "")
            {
                option += "1";
            }
            else
            {
                option += "0";
            }

            if (this.textBoxModBNameFilterA.Text != "")
            {
                option += "1";
            }
            else
            {
                option += "0";
            }

            // 2) Filter
            List<ModelA> modelsA = new List<ModelA>();
            if (option == "00") // Option 0
            {
                modelsA = this.controller.readAllModelsA();
            }
            else
            {
                if (option == "01") // Option 1
                {
                    modelsA = this.controller.readModelAOption1(this.textBoxModBNameFilterA.Text);
                }
                else
                {
                    if (option == "10") // Option 2
                    {
                        modelsA = this.controller.readModelAOption2(this.textBoxNameFilterA.Text);
                    }
                    else
                    {
                        if (option == "11") // Option 3
                        {
                            modelsA = this.controller.readModelAOption3(this.textBoxNameFilterA.Text, this.textBoxModBNameFilterA.Text);
                        }
                    }
                }
            }
            this.viewHelper.setModelsA(modelsA);
        }

        private void updateModelA(object sender, EventArgs e)
        {
            if (this.gridReadModelA.CurrentCell != null)
            {
                this.viewHelper.openFormUpdateModelA(this.controller);
            }
            else // If there aren't selected rows
            {
                MessageBox.Show("No row selected. Please select a row and try again.");
            }
        }

        private void deleteModelA(object sender, EventArgs e)
        {

            if (this.gridReadModelA.CurrentCell != null)
            {
                int id = this.viewHelper.getSelectedModelAId();
                if (this.controller.deleteModelA(id))
                {
                    this.viewHelper.deleteModelA(id);
                }
                else
                {
                    MessageBox.Show("The ModelA object could not be deleted");
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row and try again.");
            }
        }

        private void clickModelA(object sender, DataGridViewCellEventArgs e)
        {
            this.viewHelper.loadModelsBAssociatedModelsA(e.RowIndex);
        }

        private void clearModelAGrid(object sender, EventArgs e)
        {
            this.viewHelper.clearModelAGrid();
        }

        private void clearModelBGrid(object sender, EventArgs e)
        {
            this.viewHelper.clearModelBGrid();
        }
    }
}


