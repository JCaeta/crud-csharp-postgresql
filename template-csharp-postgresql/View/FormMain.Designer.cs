
namespace template_csharp_postgresql
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateModelA = new System.Windows.Forms.Button();
            this.labelModelA = new System.Windows.Forms.Label();
            this.labelModelB = new System.Windows.Forms.Label();
            this.textBoxNameModelA = new System.Windows.Forms.TextBox();
            this.checkedListBoxModelsB = new System.Windows.Forms.CheckedListBox();
            this.textBoxNameModelB = new System.Windows.Forms.TextBox();
            this.buttonCreateModelB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelModelBAssociated = new System.Windows.Forms.Label();
            this.gridReadModelB = new System.Windows.Forms.DataGridView();
            this.lblModelBSearch = new System.Windows.Forms.Label();
            this.gridReadModelA = new System.Windows.Forms.DataGridView();
            this.textBoxNameFilterB = new System.Windows.Forms.TextBox();
            this.lblSearchNameModelB1 = new System.Windows.Forms.Label();
            this.buttonReadModelB = new System.Windows.Forms.Button();
            this.buttonDeleteModelB = new System.Windows.Forms.Button();
            this.buttonUpdateModelB = new System.Windows.Forms.Button();
            this.buttonReadModelA = new System.Windows.Forms.Button();
            this.lblSearchNameModelA = new System.Windows.Forms.Label();
            this.textBoxNameFilterA = new System.Windows.Forms.TextBox();
            this.gridModelsBAssociatedModelsA = new System.Windows.Forms.DataGridView();
            this.lblAssociatedModelsB = new System.Windows.Forms.Label();
            this.buttonUpdateModelA = new System.Windows.Forms.Button();
            this.buttonDeleteModelA = new System.Windows.Forms.Button();
            this.lblSearchNameModelB0 = new System.Windows.Forms.Label();
            this.textBoxModBNameFilterA = new System.Windows.Forms.TextBox();
            this.buttonClearModelA = new System.Windows.Forms.Button();
            this.buttonClearModelB = new System.Windows.Forms.Button();
            this.groupInsert = new System.Windows.Forms.GroupBox();
            this.groupReadUpdateDelete = new System.Windows.Forms.GroupBox();
            this.lblModelASearch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridReadModelB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReadModelA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelsBAssociatedModelsA)).BeginInit();
            this.groupInsert.SuspendLayout();
            this.groupReadUpdateDelete.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateModelA
            // 
            this.buttonCreateModelA.Location = new System.Drawing.Point(149, 195);
            this.buttonCreateModelA.Name = "buttonCreateModelA";
            this.buttonCreateModelA.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateModelA.TabIndex = 0;
            this.buttonCreateModelA.Text = "Create";
            this.buttonCreateModelA.UseVisualStyleBackColor = true;
            this.buttonCreateModelA.Click += new System.EventHandler(this.createModelA);
            // 
            // labelModelA
            // 
            this.labelModelA.AutoSize = true;
            this.labelModelA.Location = new System.Drawing.Point(167, 18);
            this.labelModelA.Name = "labelModelA";
            this.labelModelA.Size = new System.Drawing.Size(52, 15);
            this.labelModelA.TabIndex = 1;
            this.labelModelA.Text = "Model A";
            // 
            // labelModelB
            // 
            this.labelModelB.AutoSize = true;
            this.labelModelB.Location = new System.Drawing.Point(408, 18);
            this.labelModelB.Name = "labelModelB";
            this.labelModelB.Size = new System.Drawing.Size(51, 15);
            this.labelModelB.TabIndex = 2;
            this.labelModelB.Text = "Model B";
            // 
            // textBoxNameModelA
            // 
            this.textBoxNameModelA.Location = new System.Drawing.Point(123, 45);
            this.textBoxNameModelA.Name = "textBoxNameModelA";
            this.textBoxNameModelA.Size = new System.Drawing.Size(133, 23);
            this.textBoxNameModelA.TabIndex = 3;
            // 
            // checkedListBoxModelsB
            // 
            this.checkedListBoxModelsB.FormattingEnabled = true;
            this.checkedListBoxModelsB.Location = new System.Drawing.Point(123, 83);
            this.checkedListBoxModelsB.Name = "checkedListBoxModelsB";
            this.checkedListBoxModelsB.Size = new System.Drawing.Size(133, 94);
            this.checkedListBoxModelsB.TabIndex = 5;
            // 
            // textBoxNameModelB
            // 
            this.textBoxNameModelB.Location = new System.Drawing.Point(354, 45);
            this.textBoxNameModelB.Name = "textBoxNameModelB";
            this.textBoxNameModelB.Size = new System.Drawing.Size(152, 23);
            this.textBoxNameModelB.TabIndex = 6;
            // 
            // buttonCreateModelB
            // 
            this.buttonCreateModelB.Location = new System.Drawing.Point(390, 195);
            this.buttonCreateModelB.Name = "buttonCreateModelB";
            this.buttonCreateModelB.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateModelB.TabIndex = 7;
            this.buttonCreateModelB.Text = "Create";
            this.buttonCreateModelB.UseVisualStyleBackColor = true;
            this.buttonCreateModelB.Click += new System.EventHandler(this.createModelB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // labelModelBAssociated
            // 
            this.labelModelBAssociated.AutoSize = true;
            this.labelModelBAssociated.Location = new System.Drawing.Point(15, 83);
            this.labelModelBAssociated.Name = "labelModelBAssociated";
            this.labelModelBAssociated.Size = new System.Drawing.Size(106, 15);
            this.labelModelBAssociated.TabIndex = 9;
            this.labelModelBAssociated.Text = "ModelB associated";
            // 
            // gridReadModelB
            // 
            this.gridReadModelB.AllowUserToAddRows = false;
            this.gridReadModelB.AllowUserToDeleteRows = false;
            this.gridReadModelB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReadModelB.Location = new System.Drawing.Point(343, 113);
            this.gridReadModelB.MultiSelect = false;
            this.gridReadModelB.Name = "gridReadModelB";
            this.gridReadModelB.ReadOnly = true;
            this.gridReadModelB.RowTemplate.Height = 25;
            this.gridReadModelB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReadModelB.Size = new System.Drawing.Size(199, 168);
            this.gridReadModelB.TabIndex = 10;
            // 
            // lblModelBSearch
            // 
            this.lblModelBSearch.AutoSize = true;
            this.lblModelBSearch.Location = new System.Drawing.Point(343, 32);
            this.lblModelBSearch.Name = "lblModelBSearch";
            this.lblModelBSearch.Size = new System.Drawing.Size(78, 15);
            this.lblModelBSearch.TabIndex = 11;
            this.lblModelBSearch.Text = "Model B filter";
            // 
            // gridReadModelA
            // 
            this.gridReadModelA.AllowUserToAddRows = false;
            this.gridReadModelA.AllowUserToDeleteRows = false;
            this.gridReadModelA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReadModelA.Location = new System.Drawing.Point(55, 146);
            this.gridReadModelA.Name = "gridReadModelA";
            this.gridReadModelA.ReadOnly = true;
            this.gridReadModelA.RowTemplate.Height = 25;
            this.gridReadModelA.Size = new System.Drawing.Size(201, 115);
            this.gridReadModelA.TabIndex = 12;
            this.gridReadModelA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickModelA);
            // 
            // textBoxNameFilterB
            // 
            this.textBoxNameFilterB.Location = new System.Drawing.Point(388, 55);
            this.textBoxNameFilterB.Name = "textBoxNameFilterB";
            this.textBoxNameFilterB.Size = new System.Drawing.Size(107, 23);
            this.textBoxNameFilterB.TabIndex = 13;
            // 
            // lblSearchNameModelB1
            // 
            this.lblSearchNameModelB1.AutoSize = true;
            this.lblSearchNameModelB1.Location = new System.Drawing.Point(343, 59);
            this.lblSearchNameModelB1.Name = "lblSearchNameModelB1";
            this.lblSearchNameModelB1.Size = new System.Drawing.Size(42, 15);
            this.lblSearchNameModelB1.TabIndex = 14;
            this.lblSearchNameModelB1.Text = "Name:";
            // 
            // buttonReadModelB
            // 
            this.buttonReadModelB.Location = new System.Drawing.Point(343, 84);
            this.buttonReadModelB.Name = "buttonReadModelB";
            this.buttonReadModelB.Size = new System.Drawing.Size(75, 23);
            this.buttonReadModelB.TabIndex = 16;
            this.buttonReadModelB.Text = "Read";
            this.buttonReadModelB.UseVisualStyleBackColor = true;
            this.buttonReadModelB.Click += new System.EventHandler(this.readModelB);
            // 
            // buttonDeleteModelB
            // 
            this.buttonDeleteModelB.Location = new System.Drawing.Point(343, 287);
            this.buttonDeleteModelB.Name = "buttonDeleteModelB";
            this.buttonDeleteModelB.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteModelB.TabIndex = 17;
            this.buttonDeleteModelB.Text = "Delete";
            this.buttonDeleteModelB.UseVisualStyleBackColor = true;
            this.buttonDeleteModelB.Click += new System.EventHandler(this.deleteModelB);
            // 
            // buttonUpdateModelB
            // 
            this.buttonUpdateModelB.Location = new System.Drawing.Point(420, 287);
            this.buttonUpdateModelB.Name = "buttonUpdateModelB";
            this.buttonUpdateModelB.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateModelB.TabIndex = 18;
            this.buttonUpdateModelB.Text = "Update";
            this.buttonUpdateModelB.UseVisualStyleBackColor = true;
            this.buttonUpdateModelB.Click += new System.EventHandler(this.updateModelB);
            // 
            // buttonReadModelA
            // 
            this.buttonReadModelA.Location = new System.Drawing.Point(104, 113);
            this.buttonReadModelA.Name = "buttonReadModelA";
            this.buttonReadModelA.Size = new System.Drawing.Size(75, 23);
            this.buttonReadModelA.TabIndex = 22;
            this.buttonReadModelA.Text = "Read";
            this.buttonReadModelA.UseVisualStyleBackColor = true;
            this.buttonReadModelA.Click += new System.EventHandler(this.readModelA);
            // 
            // lblSearchNameModelA
            // 
            this.lblSearchNameModelA.AutoSize = true;
            this.lblSearchNameModelA.Location = new System.Drawing.Point(55, 59);
            this.lblSearchNameModelA.Name = "lblSearchNameModelA";
            this.lblSearchNameModelA.Size = new System.Drawing.Size(90, 15);
            this.lblSearchNameModelA.TabIndex = 21;
            this.lblSearchNameModelA.Text = "Name model A:";
            // 
            // textBoxNameFilterA
            // 
            this.textBoxNameFilterA.Location = new System.Drawing.Point(149, 55);
            this.textBoxNameFilterA.Name = "textBoxNameFilterA";
            this.textBoxNameFilterA.Size = new System.Drawing.Size(107, 23);
            this.textBoxNameFilterA.TabIndex = 20;
            // 
            // gridModelsBAssociatedModelsA
            // 
            this.gridModelsBAssociatedModelsA.AllowUserToAddRows = false;
            this.gridModelsBAssociatedModelsA.AllowUserToDeleteRows = false;
            this.gridModelsBAssociatedModelsA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModelsBAssociatedModelsA.Location = new System.Drawing.Point(55, 287);
            this.gridModelsBAssociatedModelsA.Name = "gridModelsBAssociatedModelsA";
            this.gridModelsBAssociatedModelsA.ReadOnly = true;
            this.gridModelsBAssociatedModelsA.RowTemplate.Height = 25;
            this.gridModelsBAssociatedModelsA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModelsBAssociatedModelsA.Size = new System.Drawing.Size(201, 131);
            this.gridModelsBAssociatedModelsA.TabIndex = 23;
            // 
            // lblAssociatedModelsB
            // 
            this.lblAssociatedModelsB.AutoSize = true;
            this.lblAssociatedModelsB.Location = new System.Drawing.Point(55, 269);
            this.lblAssociatedModelsB.Name = "lblAssociatedModelsB";
            this.lblAssociatedModelsB.Size = new System.Drawing.Size(116, 15);
            this.lblAssociatedModelsB.TabIndex = 24;
            this.lblAssociatedModelsB.Text = "Associated models B";
            // 
            // buttonUpdateModelA
            // 
            this.buttonUpdateModelA.Location = new System.Drawing.Point(181, 424);
            this.buttonUpdateModelA.Name = "buttonUpdateModelA";
            this.buttonUpdateModelA.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateModelA.TabIndex = 26;
            this.buttonUpdateModelA.Text = "Update";
            this.buttonUpdateModelA.UseVisualStyleBackColor = true;
            this.buttonUpdateModelA.Click += new System.EventHandler(this.updateModelA);
            // 
            // buttonDeleteModelA
            // 
            this.buttonDeleteModelA.Location = new System.Drawing.Point(104, 424);
            this.buttonDeleteModelA.Name = "buttonDeleteModelA";
            this.buttonDeleteModelA.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteModelA.TabIndex = 25;
            this.buttonDeleteModelA.Text = "Delete";
            this.buttonDeleteModelA.UseVisualStyleBackColor = true;
            this.buttonDeleteModelA.Click += new System.EventHandler(this.deleteModelA);
            // 
            // lblSearchNameModelB0
            // 
            this.lblSearchNameModelB0.AutoSize = true;
            this.lblSearchNameModelB0.Location = new System.Drawing.Point(55, 88);
            this.lblSearchNameModelB0.Name = "lblSearchNameModelB0";
            this.lblSearchNameModelB0.Size = new System.Drawing.Size(89, 15);
            this.lblSearchNameModelB0.TabIndex = 27;
            this.lblSearchNameModelB0.Text = "Name model B:";
            // 
            // textBoxModBNameFilterA
            // 
            this.textBoxModBNameFilterA.Location = new System.Drawing.Point(149, 84);
            this.textBoxModBNameFilterA.Name = "textBoxModBNameFilterA";
            this.textBoxModBNameFilterA.Size = new System.Drawing.Size(107, 23);
            this.textBoxModBNameFilterA.TabIndex = 28;
            // 
            // buttonClearModelA
            // 
            this.buttonClearModelA.Location = new System.Drawing.Point(181, 113);
            this.buttonClearModelA.Name = "buttonClearModelA";
            this.buttonClearModelA.Size = new System.Drawing.Size(75, 23);
            this.buttonClearModelA.TabIndex = 29;
            this.buttonClearModelA.Text = "Clear";
            this.buttonClearModelA.UseVisualStyleBackColor = true;
            this.buttonClearModelA.Click += new System.EventHandler(this.clearModelAGrid);
            // 
            // buttonClearModelB
            // 
            this.buttonClearModelB.Location = new System.Drawing.Point(420, 84);
            this.buttonClearModelB.Name = "buttonClearModelB";
            this.buttonClearModelB.Size = new System.Drawing.Size(75, 23);
            this.buttonClearModelB.TabIndex = 30;
            this.buttonClearModelB.Text = "Clear";
            this.buttonClearModelB.UseVisualStyleBackColor = true;
            this.buttonClearModelB.Click += new System.EventHandler(this.clearModelBGrid);
            // 
            // groupInsert
            // 
            this.groupInsert.Controls.Add(this.labelModelBAssociated);
            this.groupInsert.Controls.Add(this.label1);
            this.groupInsert.Controls.Add(this.buttonCreateModelB);
            this.groupInsert.Controls.Add(this.textBoxNameModelB);
            this.groupInsert.Controls.Add(this.checkedListBoxModelsB);
            this.groupInsert.Controls.Add(this.textBoxNameModelA);
            this.groupInsert.Controls.Add(this.labelModelB);
            this.groupInsert.Controls.Add(this.labelModelA);
            this.groupInsert.Controls.Add(this.buttonCreateModelA);
            this.groupInsert.Location = new System.Drawing.Point(6, 59);
            this.groupInsert.Name = "groupInsert";
            this.groupInsert.Size = new System.Drawing.Size(570, 252);
            this.groupInsert.TabIndex = 31;
            this.groupInsert.TabStop = false;
            this.groupInsert.Text = "Create";
            // 
            // groupReadUpdateDelete
            // 
            this.groupReadUpdateDelete.Controls.Add(this.buttonClearModelB);
            this.groupReadUpdateDelete.Controls.Add(this.buttonClearModelA);
            this.groupReadUpdateDelete.Controls.Add(this.textBoxModBNameFilterA);
            this.groupReadUpdateDelete.Controls.Add(this.lblSearchNameModelB0);
            this.groupReadUpdateDelete.Controls.Add(this.buttonUpdateModelA);
            this.groupReadUpdateDelete.Controls.Add(this.buttonDeleteModelA);
            this.groupReadUpdateDelete.Controls.Add(this.lblAssociatedModelsB);
            this.groupReadUpdateDelete.Controls.Add(this.gridModelsBAssociatedModelsA);
            this.groupReadUpdateDelete.Controls.Add(this.buttonReadModelA);
            this.groupReadUpdateDelete.Controls.Add(this.lblSearchNameModelA);
            this.groupReadUpdateDelete.Controls.Add(this.textBoxNameFilterA);
            this.groupReadUpdateDelete.Controls.Add(this.lblModelASearch);
            this.groupReadUpdateDelete.Controls.Add(this.buttonUpdateModelB);
            this.groupReadUpdateDelete.Controls.Add(this.buttonDeleteModelB);
            this.groupReadUpdateDelete.Controls.Add(this.buttonReadModelB);
            this.groupReadUpdateDelete.Controls.Add(this.lblSearchNameModelB1);
            this.groupReadUpdateDelete.Controls.Add(this.textBoxNameFilterB);
            this.groupReadUpdateDelete.Controls.Add(this.gridReadModelA);
            this.groupReadUpdateDelete.Controls.Add(this.lblModelBSearch);
            this.groupReadUpdateDelete.Controls.Add(this.gridReadModelB);
            this.groupReadUpdateDelete.Location = new System.Drawing.Point(6, 317);
            this.groupReadUpdateDelete.Name = "groupReadUpdateDelete";
            this.groupReadUpdateDelete.Size = new System.Drawing.Size(569, 471);
            this.groupReadUpdateDelete.TabIndex = 32;
            this.groupReadUpdateDelete.TabStop = false;
            this.groupReadUpdateDelete.Text = "Read, Update and Delete";
            // 
            // lblModelASearch
            // 
            this.lblModelASearch.AutoSize = true;
            this.lblModelASearch.Location = new System.Drawing.Point(56, 32);
            this.lblModelASearch.Name = "lblModelASearch";
            this.lblModelASearch.Size = new System.Drawing.Size(79, 15);
            this.lblModelASearch.TabIndex = 19;
            this.lblModelASearch.Text = "Model A filter";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.setDatabaseConfiguration);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 838);
            this.Controls.Add(this.groupReadUpdateDelete);
            this.Controls.Add(this.groupInsert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.gridReadModelB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReadModelA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelsBAssociatedModelsA)).EndInit();
            this.groupInsert.ResumeLayout(false);
            this.groupInsert.PerformLayout();
            this.groupReadUpdateDelete.ResumeLayout(false);
            this.groupReadUpdateDelete.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelModelA;
        private System.Windows.Forms.Label labelModelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelModelBAssociated;
        private System.Windows.Forms.Label lblModelBSearch;
        private System.Windows.Forms.Label lblSearchNameModelB1;
        private System.Windows.Forms.Label lblSearchNameModelA;
        private System.Windows.Forms.Label lblAssociatedModelsB;
        private System.Windows.Forms.Label lblSearchNameModelB0;
        private System.Windows.Forms.GroupBox groupInsert;
        private System.Windows.Forms.GroupBox groupReadUpdateDelete;
        private System.Windows.Forms.Label lblModelASearch;
        public System.Windows.Forms.DataGridView gridReadModelA;
        public System.Windows.Forms.DataGridView gridReadModelB;
        public System.Windows.Forms.DataGridView gridModelsBAssociatedModelsA;
        public System.Windows.Forms.CheckedListBox checkedListBoxModelsB;
        public System.Windows.Forms.TextBox textBoxNameModelA;
        public System.Windows.Forms.TextBox textBoxNameFilterB;
        public System.Windows.Forms.TextBox textBoxNameFilterA;
        public System.Windows.Forms.TextBox textBoxModBNameFilterA;
        public System.Windows.Forms.TextBox textBoxNameModelB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        public System.Windows.Forms.Button buttonCreateModelA;
        public System.Windows.Forms.Button buttonDeleteModelB;
        public System.Windows.Forms.Button buttonUpdateModelB;
        public System.Windows.Forms.Button buttonReadModelA;
        public System.Windows.Forms.Button buttonUpdateModelA;
        public System.Windows.Forms.Button buttonDeleteModelA;
        public System.Windows.Forms.Button buttonClearModelA;
        public System.Windows.Forms.Button buttonCreateModelB;
        public System.Windows.Forms.Button buttonReadModelB;
        public System.Windows.Forms.Button buttonClearModelB;
    }
}