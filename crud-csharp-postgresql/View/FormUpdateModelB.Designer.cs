
namespace crud_csharp_postgresql
{
    partial class FormUpdateModelB
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(36, 74);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 31);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.update);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(122, 74);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.cancel);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(115, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name: ";
            // 
            // FormUpdateModelB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 134);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "FormUpdateModelB";
            this.Text = "Update Model B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}