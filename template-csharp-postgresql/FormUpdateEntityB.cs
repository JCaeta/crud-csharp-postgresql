using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace template_csharp_postgresql
{
    public partial class FormUpdateEntityB : Form
    {
        private int id;
        private Controller controller;
        private Form1 parentUi;
        private int index;
        public FormUpdateEntityB(int id, string name, int index, Controller controller, Form1 parentUi)
        {
            InitializeComponent();
            this.id = id;
            this.textBoxName.Text = name;
            this.controller = controller;
            this.parentUi = parentUi;
            this.index = index;
        }

        private void update(object sender, EventArgs e)
        {
            this.controller.updateEntityB(this.parentUi, this.id, this.textBoxName.Text, this.index);
            this.Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
