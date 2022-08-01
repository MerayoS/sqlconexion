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
    public partial class FormSelect : Form
    {
        List<Job> resultadoSelect = new List<Job>();


        public FormSelect()
        {
            InitializeComponent();
        }
        public object ReadFromDbNull(object formDB)
        {
            if (formDB == System.DBNull.Value)
                return null;
            else
                return formDB;
        }
        private void select_Click(object sender, EventArgs e)
        {
            string cadena = "select * from jobs;";
            
            SqlCommand command = new SqlCommand(cadena, Form1.conexion);
            SqlDataReader registros = command.ExecuteReader();
            //este while da un resultado por cada row de la lista original
            while(registros.Read())
            {
                //Job j = new Job((int)registros["job_id"], (string)registros["job_title"], (decimal)registros["min_salary"], (decimal)registros["max_salary"]);
                //Esta es una variante de lo de arriba, el numero es el numero de orden de la columna en la base de datos a partir de 0 
                Job j = new Job()
                {
                    JobID = registros.GetInt32(0),
                    JobTitle = registros.GetString(1),
                    MinSal = (Decimal?)ReadFromDbNull(registros[2]),
                    MaxSal = (Decimal?)ReadFromDbNull(registros[3]),
                };
                //result = "Job-Id: " + registros["job_id"] + 
                //    ", Job-Title: " + registros["job_title"] +
                //    ", Min-Salary: " + registros["min_salary"] +
                //    ", Max-Salary: " + registros["max_salary"] + ".";
                listBoxSelect.Items.Add(j);

            }
            registros.Close();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            Job idSelected = (Job)listBoxSelect.SelectedItem;
            
            string cadena = "Delete from jobs where job_id =" + idSelected.JobID + ";";

            SqlCommand command = new SqlCommand(cadena, Form1.conexion);

            if (listBoxSelect.SelectedItem != null)
            {
                command.ExecuteNonQuery();
                listBoxSelect.Items.Remove(listBoxSelect.SelectedItem);
            }
            else
                MessageBox.Show("Debe seleccionar la fila que quiere eliminar");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Job Selected = (Job)listBoxSelect.SelectedItem;
            var myForm = new FormUpdate();
            myForm.ShowDialog();
        }
      
    }
}
