using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlconexion
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             
                string jobTitle = txtjobtittle.Text;
                int minS = Int32.Parse(txtminsalary.Text);
                int maxS = Int32.Parse(txtmaxsalary.Text);
                string cadena = "insert into jobs (job_title, min_salary, max_salary) values ('" + jobTitle + "', " + minS + ", " + maxS + ");";
                //Form1.conexion funciona por que la conexion se decalro globalmente en el form1, y ademas es public static
                SqlCommand command = new SqlCommand(cadena, Form1.conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Insert realizado correctamente");
                
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error: " + ee);
            }
        }
    }
}
