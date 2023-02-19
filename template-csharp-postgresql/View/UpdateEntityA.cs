using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using template_csharp_postgresql.Entities;

namespace template_csharp_postgresql
{
    public partial class UpdateEntityA : Form
    {
        private Controller controller;
        private Form1 mainUi;
        private EntityA entityA;
        private List<EntityB> noAssocEntitiesB;
        private Dictionary<int, EntityB> dictEntitiesB;


        public UpdateEntityA(Form1 ui, Controller controller, EntityA entityA, List<EntityB> noAssocEntitiesB)
        {
            InitializeComponent();

            this.mainUi = ui;
            this.entityA = entityA;
            this.controller = controller;
            this.textBoxName.Text = entityA.Name;
            this.noAssocEntitiesB = noAssocEntitiesB;
            this.dictEntitiesB = new Dictionary<int, EntityB>();
            this.loadEntitiesB();
        }
        
        private void loadEntitiesB()
        {
            foreach(EntityB entityB in this.entityA.EntitiesB)
            {
                this.chkListEntititesB.Items.Add(entityB.Name, true);
                this.dictEntitiesB.Add(this.chkListEntititesB.Items.Count - 1, entityB);
            }

            foreach (EntityB entityB in this.noAssocEntitiesB)
            {
                this.chkListEntititesB.Items.Add(entityB.Name, false);
                this.dictEntitiesB.Add(this.chkListEntititesB.Items.Count - 1, entityB);
            }
        }

        private void update(object sender, EventArgs e)
        {
            this.entityA.Name = this.textBoxName.Text;
            this.entityA.EntitiesB.Clear();
            foreach (int index in this.chkListEntititesB.CheckedIndices)
            {
                this.entityA.EntitiesB.Add(this.dictEntitiesB[index]);
            }

            this.controller.updateEntityA(this.mainUi, entityA);
            this.Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
