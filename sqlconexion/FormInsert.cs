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
                Decimal? minS = Decimal.Parse(txtminsalary.Text);
                Decimal? maxS = Decimal.Parse(txtmaxsalary.Text);

                string cadena = "insert into jobs (job_title, min_salary, max_salary) values (@pJobTitle, @pMin, @pMax);";

                //Form1.conexion funciona por que la conexion se decalro globalmente en el form1, y ademas es public static
                SqlCommand command = new SqlCommand(cadena, Form1.conexion);

                //Creando estos parametros evitamos que los usuarios puedan realizar consultas sql en los campos a completar
                //Haciendo uso de " o '
                SqlParameter pJobTitle = new SqlParameter("@pJobTitle", SqlDbType.VarChar,35);
                pJobTitle.Value = jobTitle;
                command.Parameters.Add(pJobTitle);

                SqlParameter pMin = new SqlParameter("@pMin", SqlDbType.Decimal);
                pMin.Value = minS;
                command.Parameters.Add(pMin);

                SqlParameter pMax = new SqlParameter("@pMax", SqlDbType.Decimal);
                pMax.Value = maxS;
                command.Parameters.Add(pMax);

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
