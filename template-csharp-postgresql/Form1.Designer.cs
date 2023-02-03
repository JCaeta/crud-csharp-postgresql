
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
            this.textBoxEntityASearch = new System.Windows.Forms.TextBox();
            this.lblEntityASearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAssociatedEntitiesB = new System.Windows.Forms.Label();
            this.buttonUpdateEntityA = new System.Windows.Forms.Button();
            this.buttonDeleteEntityA = new System.Windows.Forms.Button();
            this.lblSearchNameEntityB0 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsertEntityA
            // 
            this.buttonInsertEntityA.Location = new System.Drawing.Point(155, 192);
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
            this.labelEntityA.Location = new System.Drawing.Point(173, 15);
            this.labelEntityA.Name = "labelEntityA";
            this.labelEntityA.Size = new System.Drawing.Size(48, 15);
            this.labelEntityA.TabIndex = 1;
            this.labelEntityA.Text = "Entity A";
            // 
            // labelEntityB
            // 
            this.labelEntityB.AutoSize = true;
            this.labelEntityB.Location = new System.Drawing.Point(370, 15);
            this.labelEntityB.Name = "labelEntityB";
            this.labelEntityB.Size = new System.Drawing.Size(47, 15);
            this.labelEntityB.TabIndex = 2;
            this.labelEntityB.Text = "Entity B";
            // 
            // textBoxNameEntityA
            // 
            this.textBoxNameEntityA.Location = new System.Drawing.Point(129, 42);
            this.textBoxNameEntityA.Name = "textBoxNameEntityA";
            this.textBoxNameEntityA.Size = new System.Drawing.Size(133, 23);
            this.textBoxNameEntityA.TabIndex = 3;
            // 
            // checkedListBoxEntititesB
            // 
            this.checkedListBoxEntititesB.FormattingEnabled = true;
            this.checkedListBoxEntititesB.Location = new System.Drawing.Point(129, 80);
            this.checkedListBoxEntititesB.Name = "checkedListBoxEntititesB";
            this.checkedListBoxEntititesB.Size = new System.Drawing.Size(133, 94);
            this.checkedListBoxEntititesB.TabIndex = 5;
            // 
            // textBoxNameEntityB
            // 
            this.textBoxNameEntityB.Location = new System.Drawing.Point(316, 42);
            this.textBoxNameEntityB.Name = "textBoxNameEntityB";
            this.textBoxNameEntityB.Size = new System.Drawing.Size(152, 23);
            this.textBoxNameEntityB.TabIndex = 6;
            // 
            // buttonInsertEntityB
            // 
            this.buttonInsertEntityB.Location = new System.Drawing.Point(348, 192);
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
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // labelEntityBAssociated
            // 
            this.labelEntityBAssociated.AutoSize = true;
            this.labelEntityBAssociated.Location = new System.Drawing.Point(21, 80);
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
            this.gridSearchEntityB.Location = new System.Drawing.Point(316, 339);
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
            this.lblEntityBSearch.Location = new System.Drawing.Point(316, 258);
            this.lblEntityBSearch.Name = "lblEntityBSearch";
            this.lblEntityBSearch.Size = new System.Drawing.Size(84, 15);
            this.lblEntityBSearch.TabIndex = 11;
            this.lblEntityBSearch.Text = "Entity B search";
            // 
            // gridSearchEntityA
            // 
            this.gridSearchEntityA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchEntityA.Location = new System.Drawing.Point(61, 377);
            this.gridSearchEntityA.Name = "gridSearchEntityA";
            this.gridSearchEntityA.RowTemplate.Height = 25;
            this.gridSearchEntityA.Size = new System.Drawing.Size(201, 115);
            this.gridSearchEntityA.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 13;
            // 
            // lblSearchNameEntityB1
            // 
            this.lblSearchNameEntityB1.AutoSize = true;
            this.lblSearchNameEntityB1.Location = new System.Drawing.Point(316, 285);
            this.lblSearchNameEntityB1.Name = "lblSearchNameEntityB1";
            this.lblSearchNameEntityB1.Size = new System.Drawing.Size(42, 15);
            this.lblSearchNameEntityB1.TabIndex = 14;
            this.lblSearchNameEntityB1.Text = "Name:";
            // 
            // buttonSearchEntityB
            // 
            this.buttonSearchEntityB.Location = new System.Drawing.Point(393, 310);
            this.buttonSearchEntityB.Name = "buttonSearchEntityB";
            this.buttonSearchEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchEntityB.TabIndex = 16;
            this.buttonSearchEntityB.Text = "Search";
            this.buttonSearchEntityB.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(316, 464);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 17;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.deleteEntityB);
            // 
            // buttonUpdateEntityB
            // 
            this.buttonUpdateEntityB.Location = new System.Drawing.Point(393, 464);
            this.buttonUpdateEntityB.Name = "buttonUpdateEntityB";
            this.buttonUpdateEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityB.TabIndex = 18;
            this.buttonUpdateEntityB.Text = "Update";
            this.buttonUpdateEntityB.UseVisualStyleBackColor = true;
            this.buttonUpdateEntityB.Click += new System.EventHandler(this.updateEntityB);
            // 
            // buttonSearchEntityA
            // 
            this.buttonSearchEntityA.Location = new System.Drawing.Point(187, 339);
            this.buttonSearchEntityA.Name = "buttonSearchEntityA";
            this.buttonSearchEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchEntityA.TabIndex = 22;
            this.buttonSearchEntityA.Text = "Search";
            this.buttonSearchEntityA.UseVisualStyleBackColor = true;
            // 
            // lblSearchNameEntityA
            // 
            this.lblSearchNameEntityA.AutoSize = true;
            this.lblSearchNameEntityA.Location = new System.Drawing.Point(61, 285);
            this.lblSearchNameEntityA.Name = "lblSearchNameEntityA";
            this.lblSearchNameEntityA.Size = new System.Drawing.Size(86, 15);
            this.lblSearchNameEntityA.TabIndex = 21;
            this.lblSearchNameEntityA.Text = "Name entity A:";
            // 
            // textBoxEntityASearch
            // 
            this.textBoxEntityASearch.Location = new System.Drawing.Point(155, 281);
            this.textBoxEntityASearch.Name = "textBoxEntityASearch";
            this.textBoxEntityASearch.Size = new System.Drawing.Size(107, 23);
            this.textBoxEntityASearch.TabIndex = 20;
            // 
            // lblEntityASearch
            // 
            this.lblEntityASearch.AutoSize = true;
            this.lblEntityASearch.Location = new System.Drawing.Point(62, 258);
            this.lblEntityASearch.Name = "lblEntityASearch";
            this.lblEntityASearch.Size = new System.Drawing.Size(85, 15);
            this.lblEntityASearch.TabIndex = 19;
            this.lblEntityASearch.Text = "Entity A search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(201, 61);
            this.dataGridView1.TabIndex = 23;
            // 
            // lblAssociatedEntitiesB
            // 
            this.lblAssociatedEntitiesB.AutoSize = true;
            this.lblAssociatedEntitiesB.Location = new System.Drawing.Point(61, 500);
            this.lblAssociatedEntitiesB.Name = "lblAssociatedEntitiesB";
            this.lblAssociatedEntitiesB.Size = new System.Drawing.Size(115, 15);
            this.lblAssociatedEntitiesB.TabIndex = 24;
            this.lblAssociatedEntitiesB.Text = "Associated entities B";
            // 
            // buttonUpdateEntityA
            // 
            this.buttonUpdateEntityA.Location = new System.Drawing.Point(187, 585);
            this.buttonUpdateEntityA.Name = "buttonUpdateEntityA";
            this.buttonUpdateEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityA.TabIndex = 26;
            this.buttonUpdateEntityA.Text = "Update";
            this.buttonUpdateEntityA.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEntityA
            // 
            this.buttonDeleteEntityA.Location = new System.Drawing.Point(110, 585);
            this.buttonDeleteEntityA.Name = "buttonDeleteEntityA";
            this.buttonDeleteEntityA.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEntityA.TabIndex = 25;
            this.buttonDeleteEntityA.Text = "Delete";
            this.buttonDeleteEntityA.UseVisualStyleBackColor = true;
            // 
            // lblSearchNameEntityB0
            // 
            this.lblSearchNameEntityB0.AutoSize = true;
            this.lblSearchNameEntityB0.Location = new System.Drawing.Point(61, 314);
            this.lblSearchNameEntityB0.Name = "lblSearchNameEntityB0";
            this.lblSearchNameEntityB0.Size = new System.Drawing.Size(85, 15);
            this.lblSearchNameEntityB0.TabIndex = 27;
            this.lblSearchNameEntityB0.Text = "Name entity B:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 23);
            this.textBox2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 723);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSearchNameEntityB0);
            this.Controls.Add(this.buttonUpdateEntityA);
            this.Controls.Add(this.buttonDeleteEntityA);
            this.Controls.Add(this.lblAssociatedEntitiesB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearchEntityA);
            this.Controls.Add(this.lblSearchNameEntityA);
            this.Controls.Add(this.textBoxEntityASearch);
            this.Controls.Add(this.lblEntityASearch);
            this.Controls.Add(this.buttonUpdateEntityB);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonSearchEntityB);
            this.Controls.Add(this.lblSearchNameEntityB1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridSearchEntityA);
            this.Controls.Add(this.lblEntityBSearch);
            this.Controls.Add(this.gridSearchEntityB);
            this.Controls.Add(this.labelEntityBAssociated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertEntityB);
            this.Controls.Add(this.textBoxNameEntityB);
            this.Controls.Add(this.checkedListBoxEntititesB);
            this.Controls.Add(this.textBoxNameEntityA);
            this.Controls.Add(this.labelEntityB);
            this.Controls.Add(this.labelEntityA);
            this.Controls.Add(this.buttonInsertEntityA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchEntityA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBoxEntityASearch;
        private System.Windows.Forms.Label lblEntityASearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAssociatedEntitiesB;
        private System.Windows.Forms.Button buttonUpdateEntityA;
        private System.Windows.Forms.Button buttonDeleteEntityA;
        private System.Windows.Forms.Label lblSearchNameEntityB0;
        private System.Windows.Forms.TextBox textBox2;
    }
}