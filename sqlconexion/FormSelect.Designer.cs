
namespace sqlconexion
{
    partial class FormSelect
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
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.ItemHeight = 16;
            this.listBoxSelect.Location = new System.Drawing.Point(59, 108);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.Size = new System.Drawing.Size(807, 116);
            this.listBoxSelect.TabIndex = 0;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(59, 278);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(175, 52);
            this.select.TabIndex = 1;
            this.select.Text = "Mostrar";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(691, 278);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(175, 51);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Eliminar seleccion";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 370);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.select);
            this.Controls.Add(this.listBoxSelect);
            this.Name = "FormSelect";
            this.Text = "FormSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelect;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button btndelete;
    }
}