
namespace sqlconexion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconect = new System.Windows.Forms.Button();
            this.btndisconect = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(78, 49);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(205, 82);
            this.btnconect.TabIndex = 0;
            this.btnconect.Text = "Conectarse";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // btndisconect
            // 
            this.btndisconect.Location = new System.Drawing.Point(525, 49);
            this.btndisconect.Name = "btndisconect";
            this.btndisconect.Size = new System.Drawing.Size(205, 82);
            this.btndisconect.TabIndex = 1;
            this.btndisconect.Text = "Desconectarse";
            this.btndisconect.UseVisualStyleBackColor = true;
            this.btndisconect.Click += new System.EventHandler(this.btndisconect_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(78, 285);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(211, 82);
            this.btninsert.TabIndex = 2;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(295, 285);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(211, 82);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "Select/Delete";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(519, 285);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(211, 82);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btndisconect);
            this.Controls.Add(this.btnconect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.Button btndisconect;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
    }
}

