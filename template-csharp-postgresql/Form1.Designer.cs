
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
            this.dataGridViewEntityBSearch = new System.Windows.Forms.DataGridView();
            this.labelEntityASearch = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNameEntityBSearch = new System.Windows.Forms.Label();
            this.buttonSeachEntityB = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonUpdateEntityB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntityBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // 
            // labelEntityA
            // 
            this.labelEntityA.AutoSize = true;
            this.labelEntityA.Location = new System.Drawing.Point(168, 15);
            this.labelEntityA.Name = "labelEntityA";
            this.labelEntityA.Size = new System.Drawing.Size(48, 15);
            this.labelEntityA.TabIndex = 1;
            this.labelEntityA.Text = "Entity A";
            // 
            // labelEntityB
            // 
            this.labelEntityB.AutoSize = true;
            this.labelEntityB.Location = new System.Drawing.Point(360, 15);
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
            this.textBoxNameEntityB.Size = new System.Drawing.Size(133, 23);
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
            // dataGridViewEntityBSearch
            // 
            this.dataGridViewEntityBSearch.AllowUserToAddRows = false;
            this.dataGridViewEntityBSearch.AllowUserToDeleteRows = false;
            this.dataGridViewEntityBSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntityBSearch.Location = new System.Drawing.Point(316, 349);
            this.dataGridViewEntityBSearch.MultiSelect = false;
            this.dataGridViewEntityBSearch.Name = "dataGridViewEntityBSearch";
            this.dataGridViewEntityBSearch.ReadOnly = true;
            this.dataGridViewEntityBSearch.RowTemplate.Height = 25;
            this.dataGridViewEntityBSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEntityBSearch.Size = new System.Drawing.Size(152, 119);
            this.dataGridViewEntityBSearch.TabIndex = 10;
            // 
            // labelEntityASearch
            // 
            this.labelEntityASearch.AutoSize = true;
            this.labelEntityASearch.Location = new System.Drawing.Point(316, 268);
            this.labelEntityASearch.Name = "labelEntityASearch";
            this.labelEntityASearch.Size = new System.Drawing.Size(81, 15);
            this.labelEntityASearch.TabIndex = 11;
            this.labelEntityASearch.Text = "EntityB search";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(61, 393);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(201, 75);
            this.dataGridView2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 23);
            this.textBox1.TabIndex = 13;
            // 
            // labelNameEntityBSearch
            // 
            this.labelNameEntityBSearch.AutoSize = true;
            this.labelNameEntityBSearch.Location = new System.Drawing.Point(316, 295);
            this.labelNameEntityBSearch.Name = "labelNameEntityBSearch";
            this.labelNameEntityBSearch.Size = new System.Drawing.Size(42, 15);
            this.labelNameEntityBSearch.TabIndex = 14;
            this.labelNameEntityBSearch.Text = "Name:";
            // 
            // buttonSeachEntityB
            // 
            this.buttonSeachEntityB.Location = new System.Drawing.Point(316, 320);
            this.buttonSeachEntityB.Name = "buttonSeachEntityB";
            this.buttonSeachEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonSeachEntityB.TabIndex = 16;
            this.buttonSeachEntityB.Text = "Search";
            this.buttonSeachEntityB.UseVisualStyleBackColor = true;
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(316, 474);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 17;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.deleteEntityB);
            // 
            // buttonUpdateEntityB
            // 
            this.buttonUpdateEntityB.Location = new System.Drawing.Point(393, 474);
            this.buttonUpdateEntityB.Name = "buttonUpdateEntityB";
            this.buttonUpdateEntityB.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEntityB.TabIndex = 18;
            this.buttonUpdateEntityB.Text = "Update";
            this.buttonUpdateEntityB.UseVisualStyleBackColor = true;
            this.buttonUpdateEntityB.Click += new System.EventHandler(this.updateEntityB);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 631);
            this.Controls.Add(this.buttonUpdateEntityB);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonSeachEntityB);
            this.Controls.Add(this.labelNameEntityBSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelEntityASearch);
            this.Controls.Add(this.dataGridViewEntityBSearch);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntityBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewEntityBSearch;
        private System.Windows.Forms.Label labelEntityASearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNameEntityBSearch;
        private System.Windows.Forms.Button buttonSeachEntityB;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonUpdateEntityB;
    }
}