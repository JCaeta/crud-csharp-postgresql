using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using template_csharp_postgresql.View;
using template_csharp_postgresql.Models;

namespace template_csharp_postgresql
{
    public partial class FormUpdateModelB : Form
    {
        private Controller controller;
        private ModelB modelB;
        private ViewHelper viewHelper;

        public FormUpdateModelB(ModelB modelB, Controller controller, ViewHelper viewHelper)
        {
            InitializeComponent();
            this.textBoxName.Text = modelB.Name;
            this.controller = controller;
            this.modelB = modelB;
            this.viewHelper = viewHelper;
        }

        private void update(object sender, EventArgs e)
        {
            this.modelB.Name = this.textBoxName.Text;

            if (this.controller.updateModelB(this.modelB))
            {
                this.viewHelper.updateModelB(this.modelB);
            }
            else
            {
                MessageBox.Show("The ModelB object could not be updated");
            }
            this.Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
