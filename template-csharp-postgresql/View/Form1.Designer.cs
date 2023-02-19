
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
            this.buttonCreateEntityA = new System.Windows.Forms.Button();
            this.labelEntityA = new System.Windows.Forms.Label();
            this.labelEntityB = new System.Windows.Forms.Label();
            this.textBoxNameEntityA = new System.Windows.Forms.TextBox();
            this.checkedListBoxEntititesB = new System.Windows.Forms.CheckedListBox();
            this.textBoxNameEntityB = new System.Windows.Forms.TextBox();
            this.buttonCreateEntityB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntityBAssociated = new System.Windows.Forms.Label();
            this.gridReadEntityB = new System.Windows.Forms.DataGridView();
            this.lblEntityBSearch = new System.Windows.Forms.Label();
            this.gridReadEntityA = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearchNameEntityB1 = new System.Windows.Forms.Label();
            this.buttonReadEntityB = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonUpdateEntityB = new System.Windows.Forms.Button();
            this.buttonReadEntityA = new System.Windows.Forms.Button();
            this.lblSearchNameEntityA = new System.Windows.Forms.Label();
            this.textBoxNameFilterA = new System.Windows.Forms.TextBox();
            this.gridEntitiesBAssociatedEntitiesA = new System.Windows.Forms.DataGridView();
            this.lblAssociatedEntitiesB = new System.Windows.Forms.Label();
            this.buttonUpdateEntityA = new System.Windows.Forms.Button();
            this.buttonDeleteEntityA = new System.Windows.Forms.Button();
            this.lblSearchNameEntityB0 = new System.Windows.Forms.Label();
            this.textBoxEntBNameFilterA = new System.Windows.Forms.TextBox();
            this.buttonClearEntityA = new System.Windows.Forms.Button();
            this.buttonClearEntityB = new System.Windows.Forms.Button();
            this.groupInsert = new System.Windows.Forms.GroupBox();
            this.groupReadUpdateDelete = new System.Windows.Forms.GroupBox();
            this.lblEntityASearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridReadEntityB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReadEntityA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntitiesBAssociatedEntitiesA)).BeginInit();
            this.groupInsert.SuspendLayout();
            this.groupReadUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateEntityA
            // 
            this.buttonCreateEntityA.Location = new System.Drawing.Point(149, 195);
            this.buttonCreateEntityA.Name = "buttonCreateEntityA";
            this.buttonCreateEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateEntityA.TabIndex = 0;
            this.buttonCreateEntityA.Text = "Create";
            this.buttonCreateEntityA.UseVisualStyleBackColor = true;
            this.buttonCreateEntityA.Click += new System.EventHandler(this.createEntityA);
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
            // buttonCreateEntityB
            // 
            this.buttonCreateEntityB.Location = new System.Drawing.Point(390, 195);
            this.buttonCreateEntityB.Name = "buttonCreateEntityB";
            this.buttonCreateEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateEntityB.TabIndex = 7;
            this.buttonCreateEntityB.Text = "Create";
            this.buttonCreateEntityB.UseVisualStyleBackColor = true;
            this.buttonCreateEntityB.Click += new System.EventHandler(this.createEntityB);
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
            // gridReadEntityB
            // 
            this.gridReadEntityB.AllowUserToAddRows = false;
            this.gridReadEntityB.AllowUserToDeleteRows = false;
            this.gridReadEntityB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReadEntityB.Location = new System.Drawing.Point(343, 113);
            this.gridReadEntityB.MultiSelect = false;
            this.gridReadEntityB.Name = "gridReadEntityB";
            this.gridReadEntityB.ReadOnly = true;
            this.gridReadEntityB.RowTemplate.Height = 25;
            this.gridReadEntityB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReadEntityB.Size = new System.Drawing.Size(199, 168);
            this.gridReadEntityB.TabIndex = 10;
            // 
            // lblEntityBSearch
            // 
            this.lblEntityBSearch.AutoSize = true;
            this.lblEntityBSearch.Location = new System.Drawing.Point(343, 32);
            this.lblEntityBSearch.Name = "lblEntityBSearch";
            this.lblEntityBSearch.Size = new System.Drawing.Size(74, 15);
            this.lblEntityBSearch.TabIndex = 11;
            this.lblEntityBSearch.Text = "Entity B filter";
            // 
            // gridReadEntityA
            // 
            this.gridReadEntityA.AllowUserToAddRows = false;
            this.gridReadEntityA.AllowUserToDeleteRows = false;
            this.gridReadEntityA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReadEntityA.Location = new System.Drawing.Point(55, 146);
            this.gridReadEntityA.Name = "gridReadEntityA";
            this.gridReadEntityA.ReadOnly = true;
            this.gridReadEntityA.RowTemplate.Height = 25;
            this.gridReadEntityA.Size = new System.Drawing.Size(201, 115);
            this.gridReadEntityA.TabIndex = 12;
            this.gridReadEntityA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickEntityA);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 13;
            // 
            // lblSearchNameEntityB1
            // 
            this.lblSearchNameEntityB1.AutoSize = true;
            this.lblSearchNameEntityB1.Location = new System.Drawing.Point(343, 59);
            this.lblSearchNameEntityB1.Name = "lblSearchNameEntityB1";
            this.lblSearchNameEntityB1.Size = new System.Drawing.Size(42, 15);
            this.lblSearchNameEntityB1.TabIndex = 14;
            this.lblSearchNameEntityB1.Text = "Name:";
            // 
            // buttonReadEntityB
            // 
            this.buttonReadEntityB.Location = new System.Drawing.Point(343, 84);
            this.buttonReadEntityB.Name = "buttonReadEntityB";
            this.buttonReadEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonReadEntityB.TabIndex = 16;
            this.buttonReadEntityB.Text = "Read";
            this.buttonReadEntityB.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(343, 287);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 17;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.deleteEntityB);
            // 
            // buttonUpdateEntityB
            // 
            this.buttonUpdateEntityB.Location = new System.Drawing.Point(420, 287);
            this.buttonUpdateEntityB.Name = "buttonUpdateEntityB";
            this.buttonUpdateEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityB.TabIndex = 18;
            this.buttonUpdateEntityB.Text = "Update";
            this.buttonUpdateEntityB.UseVisualStyleBackColor = true;
            this.buttonUpdateEntityB.Click += new System.EventHandler(this.updateEntityB);
            // 
            // buttonReadEntityA
            // 
            this.buttonReadEntityA.Location = new System.Drawing.Point(104, 113);
            this.buttonReadEntityA.Name = "buttonReadEntityA";
            this.buttonReadEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonReadEntityA.TabIndex = 22;
            this.buttonReadEntityA.Text = "Read";
            this.buttonReadEntityA.UseVisualStyleBackColor = true;
            this.buttonReadEntityA.Click += new System.EventHandler(this.readEntityA);
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
            this.gridEntitiesBAssociatedEntitiesA.Size = new System.Drawing.Size(201, 131);
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
            this.buttonUpdateEntityA.Location = new System.Drawing.Point(181, 424);
            this.buttonUpdateEntityA.Name = "buttonUpdateEntityA";
            this.buttonUpdateEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityA.TabIndex = 26;
            this.buttonUpdateEntityA.Text = "Update";
            this.buttonUpdateEntityA.UseVisualStyleBackColor = true;
            this.buttonUpdateEntityA.Click += new System.EventHandler(this.updateEntityA);
            // 
            // buttonDeleteEntityA
            // 
            this.buttonDeleteEntityA.Location = new System.Drawing.Point(104, 424);
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
            this.buttonClearEntityB.Location = new System.Drawing.Point(420, 84);
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
            this.groupInsert.Controls.Add(this.buttonCreateEntityB);
            this.groupInsert.Controls.Add(this.textBoxNameEntityB);
            this.groupInsert.Controls.Add(this.checkedListBoxEntititesB);
            this.groupInsert.Controls.Add(this.textBoxNameEntityA);
            this.groupInsert.Controls.Add(this.labelEntityB);
            this.groupInsert.Controls.Add(this.labelEntityA);
            this.groupInsert.Controls.Add(this.buttonCreateEntityA);
            this.groupInsert.Location = new System.Drawing.Point(6, 5);
            this.groupInsert.Name = "groupInsert";
            this.groupInsert.Size = new System.Drawing.Size(570, 252);
            this.groupInsert.TabIndex = 31;
            this.groupInsert.TabStop = false;
            this.groupInsert.Text = "Create";
            // 
            // groupReadUpdateDelete
            // 
            this.groupReadUpdateDelete.Controls.Add(this.buttonClearEntityB);
            this.groupReadUpdateDelete.Controls.Add(this.buttonClearEntityA);
            this.groupReadUpdateDelete.Controls.Add(this.textBoxEntBNameFilterA);
            this.groupReadUpdateDelete.Controls.Add(this.lblSearchNameEntityB0);
            this.groupReadUpdateDelete.Controls.Add(this.buttonUpdateEntityA);
            this.groupReadUpdateDelete.Controls.Add(this.buttonDeleteEntityA);
            this.groupReadUpdateDelete.Controls.Add(this.lblAssociatedEntitiesB);
            this.groupReadUpdateDelete.Controls.Add(this.gridEntitiesBAssociatedEntitiesA);
            this.groupReadUpdateDelete.Controls.Add(this.buttonReadEntityA);
            this.groupReadUpdateDelete.Controls.Add(this.lblSearchNameEntityA);
            this.groupReadUpdateDelete.Controls.Add(this.textBoxNameFilterA);
            this.groupReadUpdateDelete.Controls.Add(this.lblEntityASearch);
            this.groupReadUpdateDelete.Controls.Add(this.buttonUpdateEntityB);
            this.groupReadUpdateDelete.Controls.Add(this.buttondelete);
            this.groupReadUpdateDelete.Controls.Add(this.buttonReadEntityB);
            this.groupReadUpdateDelete.Controls.Add(this.lblSearchNameEntityB1);
            this.groupReadUpdateDelete.Controls.Add(this.textBox1);
            this.groupReadUpdateDelete.Controls.Add(this.gridReadEntityA);
            this.groupReadUpdateDelete.Controls.Add(this.lblEntityBSearch);
            this.groupReadUpdateDelete.Controls.Add(this.gridReadEntityB);
            this.groupReadUpdateDelete.Location = new System.Drawing.Point(6, 275);
            this.groupReadUpdateDelete.Name = "groupReadUpdateDelete";
            this.groupReadUpdateDelete.Size = new System.Drawing.Size(569, 471);
            this.groupReadUpdateDelete.TabIndex = 32;
            this.groupReadUpdateDelete.TabStop = false;
            this.groupReadUpdateDelete.Text = "Read, Update and Delete";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 779);
            this.Controls.Add(this.groupReadUpdateDelete);
            this.Controls.Add(this.groupInsert);
            this.Name = "Form1";
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.gridReadEntityB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReadEntityA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntitiesBAssociatedEntitiesA)).EndInit();
            this.groupInsert.ResumeLayout(false);
            this.groupInsert.PerformLayout();
            this.groupReadUpdateDelete.ResumeLayout(false);
            this.groupReadUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateEntityA;
        private System.Windows.Forms.Label labelEntityA;
        private System.Windows.Forms.Label labelEntityB;
        private System.Windows.Forms.TextBox textBoxNameEntityA;
        private System.Windows.Forms.CheckedListBox checkedListBoxEntititesB;
        private System.Windows.Forms.TextBox textBoxNameEntityB;
        private System.Windows.Forms.Button buttonCreateEntityB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEntityBAssociated;
        private System.Windows.Forms.DataGridView gridReadEntityB;
        private System.Windows.Forms.Label lblEntityBSearch;
        private System.Windows.Forms.DataGridView gridReadEntityA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearchNameEntityB1;
        private System.Windows.Forms.Button buttonReadEntityB;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonUpdateEntityB;
        private System.Windows.Forms.Button buttonReadEntityA;
        private System.Windows.Forms.Label lblSearchNameEntityA;
        private System.Windows.Forms.TextBox textBoxNameFilterA;
        private System.Windows.Forms.DataGridView gridEntitiesBAssociatedEntitiesA;
        private System.Windows.Forms.Label lblAssociatedEntitiesB;
        private System.Windows.Forms.Button buttonUpdateEntityA;
        private System.Windows.Forms.Button buttonDeleteEntityA;
        private System.Windows.Forms.Label lblSearchNameEntityB0;
        private System.Windows.Forms.TextBox textBoxEntBNameFilterA;
        private System.Windows.Forms.Button buttonClearEntityA;
        private System.Windows.Forms.Button buttonClearEntityB;
        private System.Windows.Forms.GroupBox groupInsert;
        private System.Windows.Forms.GroupBox groupReadUpdateDelete;
        private System.Windows.Forms.Label lblEntityASearch;
    }
}