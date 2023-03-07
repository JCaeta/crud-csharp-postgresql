using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using template_csharp_postgresql.Models;
using template_csharp_postgresql.View;

namespace template_csharp_postgresql
{
    public partial class FormUpdateModelA : Form
    {
        private Controller controller;
        private ViewHelper viewHelper;
        private ModelA modelA;
        private List<ModelB> noAssocModelsB;
        private Dictionary<int, ModelB> dictModelsB;

        public FormUpdateModelA(ViewHelper viewHelper, Controller controller, ModelA modelA, List<ModelB> noAssocModelsB)
        {
            InitializeComponent();
            this.viewHelper = viewHelper;
            this.modelA = modelA;
            this.controller = controller;
            this.textBoxName.Text = modelA.Name;
            this.noAssocModelsB = noAssocModelsB;
            this.dictModelsB = new Dictionary<int, ModelB>();
            this.loadModelsB();
        }
        
        private void loadModelsB()
        {
            foreach(ModelB modelB in this.modelA.ModelsB)
            {
                this.chkListModelsB.Items.Add(modelB.Name, true);
                this.dictModelsB.Add(this.chkListModelsB.Items.Count - 1, modelB);
            }

            foreach (ModelB modelB in this.noAssocModelsB)
            {
                this.chkListModelsB.Items.Add(modelB.Name, false);
                this.dictModelsB.Add(this.chkListModelsB.Items.Count - 1, modelB);
            }
        }

        private void update(object sender, EventArgs e)
        {
            this.modelA.Name = this.textBoxName.Text;
            this.modelA.ModelsB.Clear();
            foreach (int index in this.chkListModelsB.CheckedIndices)
            {
                this.modelA.ModelsB.Add(this.dictModelsB[index]);
            }

            if(this.controller.updateModelA(modelA))
            {
                this.viewHelper.updateModelA(modelA);
            }
            this.Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
