
namespace sqlconexion
{
    partial class FormInsert
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
            this.txtjobtittle = new System.Windows.Forms.TextBox();
            this.txtminsalary = new System.Windows.Forms.TextBox();
            this.txtmaxsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtjobtittle
            // 
            this.txtjobtittle.Location = new System.Drawing.Point(74, 96);
            this.txtjobtittle.Name = "txtjobtittle";
            this.txtjobtittle.Size = new System.Drawing.Size(100, 22);
            this.txtjobtittle.TabIndex = 0;
            // 
            // txtminsalary
            // 
            this.txtminsalary.Location = new System.Drawing.Point(74, 176);
            this.txtminsalary.Name = "txtminsalary";
            this.txtminsalary.Size = new System.Drawing.Size(100, 22);
            this.txtminsalary.TabIndex = 1;
            // 
            // txtmaxsalary
            // 
            this.txtmaxsalary.Location = new System.Drawing.Point(74, 255);
            this.txtmaxsalary.Name = "txtmaxsalary";
            this.txtmaxsalary.Size = new System.Drawing.Size(100, 22);
            this.txtmaxsalary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job__title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "min_salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "max_salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear cadena";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaxsalary);
            this.Controls.Add(this.txtminsalary);
            this.Controls.Add(this.txtjobtittle);
            this.Name = "FormInsert";
            this.Text = "FormInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtjobtittle;
        private System.Windows.Forms.TextBox txtminsalary;
        private System.Windows.Forms.TextBox txtmaxsalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}