
namespace sqlconexion
{
    partial class FormUpdate
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
            this.txtjobtitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtminsalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaxsalary = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtjobtitle
            // 
            this.txtjobtitle.Location = new System.Drawing.Point(47, 107);
            this.txtjobtitle.Name = "txtjobtitle";
            this.txtjobtitle.Size = new System.Drawing.Size(342, 22);
            this.txtjobtitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min Salary";
            // 
            // txtminsalary
            // 
            this.txtminsalary.Location = new System.Drawing.Point(44, 193);
            this.txtminsalary.Name = "txtminsalary";
            this.txtminsalary.Size = new System.Drawing.Size(342, 22);
            this.txtminsalary.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Salary";
            // 
            // txtmaxsalary
            // 
            this.txtmaxsalary.Location = new System.Drawing.Point(41, 292);
            this.txtmaxsalary.Name = "txtmaxsalary";
            this.txtmaxsalary.Size = new System.Drawing.Size(342, 22);
            this.txtmaxsalary.TabIndex = 4;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(41, 373);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(131, 46);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(252, 373);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(131, 46);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 481);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaxsalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtminsalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtjobtitle);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtjobtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtminsalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaxsalary;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
    }
}