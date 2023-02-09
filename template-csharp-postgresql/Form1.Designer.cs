
namespace template_csharp_postgresql
{
    partial class Form1
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
            this.buttonInsertEntityA = new System.Windows.Forms.Button();
            this.labelEntityA = new System.Windows.Forms.Label();
            this.labelEntityB = new System.Windows.Forms.Label();
            this.textBoxNameEntityA = new System.Windows.Forms.TextBox();
            this.checkedListBoxEntititesB = new System.Windows.Forms.CheckedListBox();
            this.textBoxNameEntityB = new System.Windows.Forms.TextBox();
            this.buttonInsertEntityB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntityBAssociated = new System.Windows.Forms.Label();
            this.gridSearchEntityB = new System.Windows.Forms.DataGridView();
            this.lblEntityBSearch = new System.Windows.Forms.Label();
            this.gridSearchEntityA = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearchNameEntityB1 = new System.Windows.Forms.Label();
            this.buttonSearchEntityB = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonUpdateEntityB = new System.Windows.Forms.Button();
            this.buttonSearchEntityA = new System.Windows.Forms.Button();
            this.lblSearchNameEntityA = new System.Windows.Forms.Label();
            this.textBoxNameFilterA = new System.Windows.Forms.TextBox();
            this.lblEntityASearch = new System.Windows.Forms.Label();
            this.gridEntitiesBAssociatedEntitiesA = new System.Windows.Forms.DataGridView();
            this.lblAssociatedEntitiesB = new System.Windows.Forms.Label();
            this.buttonUpdateEntityA = new System.Windows.Forms.Button();
            this.buttonDeleteEntityA = new System.Windows.Forms.Button();
            this.lblSearchNameEntityB0 = new System.Windows.Forms.Label();
            this.textBoxEntBNameFilterA = new System.Windows.Forms.TextBox();
            this.buttonClearEntityA = new System.Windows.Forms.Button();
            this.buttonClearEntityB = new System.Windows.Forms.Button();
            this.groupInsert = new System.Windows.Forms.GroupBox();
            this.groupFilterUpdateDelete = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntitiesBAssociatedEntitiesA)).BeginInit();
            this.groupInsert.SuspendLayout();
            this.groupFilterUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInsertEntityA
            // 
            this.buttonInsertEntityA.Location = new System.Drawing.Point(149, 195);
            this.buttonInsertEntityA.Name = "buttonInsertEntityA";
            this.buttonInsertEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertEntityA.TabIndex = 0;
            this.buttonInsertEntityA.Text = "Insert";
            this.buttonInsertEntityA.UseVisualStyleBackColor = true;
            this.buttonInsertEntityA.Click += new System.EventHandler(this.insertEntityA);
            // 
            // labelEntityA
            // 
            this.labelEntityA.AutoSize = true;
            this.labelEntityA.Location = new System.Drawing.Point(167, 18);
            this.labelEntityA.Name = "labelEntityA";
            this.labelEntityA.Size = new System.Drawing.Size(48, 15);
            this.labelEntityA.TabIndex = 1;
            this.labelEntityA.Text = "Entity A";
            // 
            // labelEntityB
            // 
            this.labelEntityB.AutoSize = true;
            this.labelEntityB.Location = new System.Drawing.Point(408, 18);
            this.labelEntityB.Name = "labelEntityB";
            this.labelEntityB.Size = new System.Drawing.Size(47, 15);
            this.labelEntityB.TabIndex = 2;
            this.labelEntityB.Text = "Entity B";
            // 
            // textBoxNameEntityA
            // 
            this.textBoxNameEntityA.Location = new System.Drawing.Point(123, 45);
            this.textBoxNameEntityA.Name = "textBoxNameEntityA";
            this.textBoxNameEntityA.Size = new System.Drawing.Size(133, 23);
            this.textBoxNameEntityA.TabIndex = 3;
            // 
            // checkedListBoxEntititesB
            // 
            this.checkedListBoxEntititesB.FormattingEnabled = true;
            this.checkedListBoxEntititesB.Location = new System.Drawing.Point(123, 83);
            this.checkedListBoxEntititesB.Name = "checkedListBoxEntititesB";
            this.checkedListBoxEntititesB.Size = new System.Drawing.Size(133, 94);
            this.checkedListBoxEntititesB.TabIndex = 5;
            // 
            // textBoxNameEntityB
            // 
            this.textBoxNameEntityB.Location = new System.Drawing.Point(354, 45);
            this.textBoxNameEntityB.Name = "textBoxNameEntityB";
            this.textBoxNameEntityB.Size = new System.Drawing.Size(152, 23);
            this.textBoxNameEntityB.TabIndex = 6;
            // 
            // buttonInsertEntityB
            // 
            this.buttonInsertEntityB.Location = new System.Drawing.Point(390, 195);
            this.buttonInsertEntityB.Name = "buttonInsertEntityB";
            this.buttonInsertEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertEntityB.TabIndex = 7;
            this.buttonInsertEntityB.Text = "Insert";
            this.buttonInsertEntityB.UseVisualStyleBackColor = true;
            this.buttonInsertEntityB.Click += new System.EventHandler(this.insertEntityB);
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
            // labelEntityBAssociated
            // 
            this.labelEntityBAssociated.AutoSize = true;
            this.labelEntityBAssociated.Location = new System.Drawing.Point(15, 83);
            this.labelEntityBAssociated.Name = "labelEntityBAssociated";
            this.labelEntityBAssociated.Size = new System.Drawing.Size(102, 15);
            this.labelEntityBAssociated.TabIndex = 9;
            this.labelEntityBAssociated.Text = "EntityB associated";
            // 
            // gridSearchEntityB
            // 
            this.gridSearchEntityB.AllowUserToAddRows = false;
            this.gridSearchEntityB.AllowUserToDeleteRows = false;
            this.gridSearchEntityB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchEntityB.Location = new System.Drawing.Point(354, 113);
            this.gridSearchEntityB.MultiSelect = false;
            this.gridSearchEntityB.Name = "gridSearchEntityB";
            this.gridSearchEntityB.ReadOnly = true;
            this.gridSearchEntityB.RowTemplate.Height = 25;
            this.gridSearchEntityB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearchEntityB.Size = new System.Drawing.Size(152, 119);
            this.gridSearchEntityB.TabIndex = 10;
            // 
            // lblEntityBSearch
            // 
            this.lblEntityBSearch.AutoSize = true;
            this.lblEntityBSearch.Location = new System.Drawing.Point(354, 32);
            this.lblEntityBSearch.Name = "lblEntityBSearch";
            this.lblEntityBSearch.Size = new System.Drawing.Size(74, 15);
            this.lblEntityBSearch.TabIndex = 11;
            this.lblEntityBSearch.Text = "Entity B filter";
            // 
            // gridSearchEntityA
            // 
            this.gridSearchEntityA.AllowUserToAddRows = false;
            this.gridSearchEntityA.AllowUserToDeleteRows = false;
            this.gridSearchEntityA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchEntityA.Location = new System.Drawing.Point(55, 146);
            this.gridSearchEntityA.Name = "gridSearchEntityA";
            this.gridSearchEntityA.ReadOnly = true;
            this.gridSearchEntityA.RowTemplate.Height = 25;
            this.gridSearchEntityA.Size = new System.Drawing.Size(201, 115);
            this.gridSearchEntityA.TabIndex = 12;
            this.gridSearchEntityA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickEntityA);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 13;
            // 
            // lblSearchNameEntityB1
            // 
            this.lblSearchNameEntityB1.AutoSize = true;
            this.lblSearchNameEntityB1.Location = new System.Drawing.Point(354, 59);
            this.lblSearchNameEntityB1.Name = "lblSearchNameEntityB1";
            this.lblSearchNameEntityB1.Size = new System.Drawing.Size(42, 15);
            this.lblSearchNameEntityB1.TabIndex = 14;
            this.lblSearchNameEntityB1.Text = "Name:";
            // 
            // buttonSearchEntityB
            // 
            this.buttonSearchEntityB.Location = new System.Drawing.Point(354, 84);
            this.buttonSearchEntityB.Name = "buttonSearchEntityB";
            this.buttonSearchEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchEntityB.TabIndex = 16;
            this.buttonSearchEntityB.Text = "Filter";
            this.buttonSearchEntityB.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(354, 238);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 17;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.deleteEntityB);
            // 
            // buttonUpdateEntityB
            // 
            this.buttonUpdateEntityB.Location = new System.Drawing.Point(431, 238);
            this.buttonUpdateEntityB.Name = "buttonUpdateEntityB";
            this.buttonUpdateEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityB.TabIndex = 18;
            this.buttonUpdateEntityB.Text = "Update";
            this.buttonUpdateEntityB.UseVisualStyleBackColor = true;
            this.buttonUpdateEntityB.Click += new System.EventHandler(this.updateEntityB);
            // 
            // buttonSearchEntityA
            // 
            this.buttonSearchEntityA.Location = new System.Drawing.Point(100, 113);
            this.buttonSearchEntityA.Name = "buttonSearchEntityA";
            this.buttonSearchEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchEntityA.TabIndex = 22;
            this.buttonSearchEntityA.Text = "Filter";
            this.buttonSearchEntityA.UseVisualStyleBackColor = true;
            this.buttonSearchEntityA.Click += new System.EventHandler(this.filterEntityA);
            // 
            // lblSearchNameEntityA
            // 
            this.lblSearchNameEntityA.AutoSize = true;
            this.lblSearchNameEntityA.Location = new System.Drawing.Point(55, 59);
            this.lblSearchNameEntityA.Name = "lblSearchNameEntityA";
            this.lblSearchNameEntityA.Size = new System.Drawing.Size(86, 15);
            this.lblSearchNameEntityA.TabIndex = 21;
            this.lblSearchNameEntityA.Text = "Name entity A:";
            // 
            // textBoxNameFilterA
            // 
            this.textBoxNameFilterA.Location = new System.Drawing.Point(149, 55);
            this.textBoxNameFilterA.Name = "textBoxNameFilterA";
            this.textBoxNameFilterA.Size = new System.Drawing.Size(107, 23);
            this.textBoxNameFilterA.TabIndex = 20;
            // 
            // lblEntityASearch
            // 
            this.lblEntityASearch.AutoSize = true;
            this.lblEntityASearch.Location = new System.Drawing.Point(56, 32);
            this.lblEntityASearch.Name = "lblEntityASearch";
            this.lblEntityASearch.Size = new System.Drawing.Size(75, 15);
            this.lblEntityASearch.TabIndex = 19;
            this.lblEntityASearch.Text = "Entity A filter";
            // 
            // gridEntitiesBAssociatedEntitiesA
            // 
            this.gridEntitiesBAssociatedEntitiesA.AllowUserToAddRows = false;
            this.gridEntitiesBAssociatedEntitiesA.AllowUserToDeleteRows = false;
            this.gridEntitiesBAssociatedEntitiesA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntitiesBAssociatedEntitiesA.Location = new System.Drawing.Point(55, 287);
            this.gridEntitiesBAssociatedEntitiesA.Name = "gridEntitiesBAssociatedEntitiesA";
            this.gridEntitiesBAssociatedEntitiesA.ReadOnly = true;
            this.gridEntitiesBAssociatedEntitiesA.RowTemplate.Height = 25;
            this.gridEntitiesBAssociatedEntitiesA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEntitiesBAssociatedEntitiesA.Size = new System.Drawing.Size(201, 89);
            this.gridEntitiesBAssociatedEntitiesA.TabIndex = 23;
            // 
            // lblAssociatedEntitiesB
            // 
            this.lblAssociatedEntitiesB.AutoSize = true;
            this.lblAssociatedEntitiesB.Location = new System.Drawing.Point(55, 269);
            this.lblAssociatedEntitiesB.Name = "lblAssociatedEntitiesB";
            this.lblAssociatedEntitiesB.Size = new System.Drawing.Size(115, 15);
            this.lblAssociatedEntitiesB.TabIndex = 24;
            this.lblAssociatedEntitiesB.Text = "Associated entities B";
            // 
            // buttonUpdateEntityA
            // 
            this.buttonUpdateEntityA.Location = new System.Drawing.Point(181, 382);
            this.buttonUpdateEntityA.Name = "buttonUpdateEntityA";
            this.buttonUpdateEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityA.TabIndex = 26;
            this.buttonUpdateEntityA.Text = "Update";
            this.buttonUpdateEntityA.UseVisualStyleBackColor = true;
            this.buttonUpdateEntityA.Click += new System.EventHandler(this.updateEntityA);
            // 
            // buttonDeleteEntityA
            // 
            this.buttonDeleteEntityA.Location = new System.Drawing.Point(104, 382);
            this.buttonDeleteEntityA.Name = "buttonDeleteEntityA";
            this.buttonDeleteEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEntityA.TabIndex = 25;
            this.buttonDeleteEntityA.Text = "Delete";
            this.buttonDeleteEntityA.UseVisualStyleBackColor = true;
            this.buttonDeleteEntityA.Click += new System.EventHandler(this.deleteEntityA);
            // 
            // lblSearchNameEntityB0
            // 
            this.lblSearchNameEntityB0.AutoSize = true;
            this.lblSearchNameEntityB0.Location = new System.Drawing.Point(55, 88);
            this.lblSearchNameEntityB0.Name = "lblSearchNameEntityB0";
            this.lblSearchNameEntityB0.Size = new System.Drawing.Size(85, 15);
            this.lblSearchNameEntityB0.TabIndex = 27;
            this.lblSearchNameEntityB0.Text = "Name entity B:";
            // 
            // textBoxEntBNameFilterA
            // 
            this.textBoxEntBNameFilterA.Location = new System.Drawing.Point(149, 84);
            this.textBoxEntBNameFilterA.Name = "textBoxEntBNameFilterA";
            this.textBoxEntBNameFilterA.Size = new System.Drawing.Size(107, 23);
            this.textBoxEntBNameFilterA.TabIndex = 28;
            // 
            // buttonClearEntityA
            // 
            this.buttonClearEntityA.Location = new System.Drawing.Point(181, 113);
            this.buttonClearEntityA.Name = "buttonClearEntityA";
            this.buttonClearEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonClearEntityA.TabIndex = 29;
            this.buttonClearEntityA.Text = "Clear";
            this.buttonClearEntityA.UseVisualStyleBackColor = true;
            // 
            // buttonClearEntityB
            // 
            this.buttonClearEntityB.Location = new System.Drawing.Point(431, 84);
            this.buttonClearEntityB.Name = "buttonClearEntityB";
            this.buttonClearEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonClearEntityB.TabIndex = 30;
            this.buttonClearEntityB.Text = "Clear";
            this.buttonClearEntityB.UseVisualStyleBackColor = true;
            // 
            // groupInsert
            // 
            this.groupInsert.Controls.Add(this.labelEntityBAssociated);
            this.groupInsert.Controls.Add(this.label1);
            this.groupInsert.Controls.Add(this.buttonInsertEntityB);
            this.groupInsert.Controls.Add(this.textBoxNameEntityB);
            this.groupInsert.Controls.Add(this.checkedListBoxEntititesB);
            this.groupInsert.Controls.Add(this.textBoxNameEntityA);
            this.groupInsert.Controls.Add(this.labelEntityB);
            this.groupInsert.Controls.Add(this.labelEntityA);
            this.groupInsert.Controls.Add(this.buttonInsertEntityA);
            this.groupInsert.Location = new System.Drawing.Point(6, 5);
            this.groupInsert.Name = "groupInsert";
            this.groupInsert.Size = new System.Drawing.Size(570, 252);
            this.groupInsert.TabIndex = 31;
            this.groupInsert.TabStop = false;
            this.groupInsert.Text = "Create";
            // 
            // groupFilterUpdateDelete
            // 
            this.groupFilterUpdateDelete.Controls.Add(this.buttonClearEntityB);
            this.groupFilterUpdateDelete.Controls.Add(this.buttonClearEntityA);
            this.groupFilterUpdateDelete.Controls.Add(this.textBoxEntBNameFilterA);
            this.groupFilterUpdateDelete.Controls.Add(this.lblSearchNameEntityB0);
            this.groupFilterUpdateDelete.Controls.Add(this.buttonUpdateEntityA);
            this.groupFilterUpdateDelete.Controls.Add(this.buttonDeleteEntityA);
            this.groupFilterUpdateDelete.Controls.Add(this.lblAssociatedEntitiesB);
            this.groupFilterUpdateDelete.Controls.Add(this.gridEntitiesBAssociatedEntitiesA);
            this.groupFilterUpdateDelete.Controls.Add(this.buttonSearchEntityA);
            this.groupFilterUpdateDelete.Controls.Add(this.lblSearchNameEntityA);
            this.groupFilterUpdateDelete.Controls.Add(this.textBoxNameFilterA);
            this.groupFilterUpdateDelete.Controls.Add(this.lblEntityASearch);
            this.groupFilterUpdateDelete.Controls.Add(this.buttonUpdateEntityB);
            this.groupFilterUpdateDelete.Controls.Add(this.buttondelete);
            this.groupFilterUpdateDelete.Controls.Add(this.buttonSearchEntityB);
            this.groupFilterUpdateDelete.Controls.Add(this.lblSearchNameEntityB1);
            this.groupFilterUpdateDelete.Controls.Add(this.textBox1);
            this.groupFilterUpdateDelete.Controls.Add(this.gridSearchEntityA);
            this.groupFilterUpdateDelete.Controls.Add(this.lblEntityBSearch);
            this.groupFilterUpdateDelete.Controls.Add(this.gridSearchEntityB);
            this.groupFilterUpdateDelete.Location = new System.Drawing.Point(6, 275);
            this.groupFilterUpdateDelete.Name = "groupFilterUpdateDelete";
            this.groupFilterUpdateDelete.Size = new System.Drawing.Size(569, 426);
            this.groupFilterUpdateDelete.TabIndex = 32;
            this.groupFilterUpdateDelete.TabStop = false;
            this.groupFilterUpdateDelete.Text = "Filter, Update and Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 741);
            this.Controls.Add(this.groupFilterUpdateDelete);
            this.Controls.Add(this.groupInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntitiesBAssociatedEntitiesA)).EndInit();
            this.groupInsert.ResumeLayout(false);
            this.groupInsert.PerformLayout();
            this.groupFilterUpdateDelete.ResumeLayout(false);
            this.groupFilterUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertEntityA;
        private System.Windows.Forms.Label labelEntityA;
        private System.Windows.Forms.Label labelEntityB;
        private System.Windows.Forms.TextBox textBoxNameEntityA;
        private System.Windows.Forms.CheckedListBox checkedListBoxEntititesB;
        private System.Windows.Forms.TextBox textBoxNameEntityB;
        private System.Windows.Forms.Button buttonInsertEntityB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEntityBAssociated;
        private System.Windows.Forms.DataGridView gridSearchEntityB;
        private System.Windows.Forms.Label lblEntityBSearch;
        private System.Windows.Forms.DataGridView gridSearchEntityA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearchNameEntityB1;
        private System.Windows.Forms.Button buttonSearchEntityB;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonUpdateEntityB;
        private System.Windows.Forms.Button buttonSearchEntityA;
        private System.Windows.Forms.Label lblSearchNameEntityA;
        private System.Windows.Forms.TextBox textBoxNameFilterA;
        private System.Windows.Forms.Label lblEntityASearch;
        private System.Windows.Forms.DataGridView gridEntitiesBAssociatedEntitiesA;
        private System.Windows.Forms.Label lblAssociatedEntitiesB;
        private System.Windows.Forms.Button buttonUpdateEntityA;
        private System.Windows.Forms.Button buttonDeleteEntityA;
        private System.Windows.Forms.Label lblSearchNameEntityB0;
        private System.Windows.Forms.TextBox textBoxEntBNameFilterA;
        private System.Windows.Forms.Button buttonClearEntityA;
        private System.Windows.Forms.Button buttonClearEntityB;
        private System.Windows.Forms.GroupBox groupInsert;
        private System.Windows.Forms.GroupBox groupFilterUpdateDelete;
    }
}