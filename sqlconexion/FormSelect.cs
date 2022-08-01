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

        private void select_Click(object sender, EventArgs e)
        {
            string cadena = "select * from jobs;";
            
            SqlCommand command = new SqlCommand(cadena, Form1.conexion);
            SqlDataReader registros = command.ExecuteReader();
            //este while da un resultado por cada row de la lista original
            while(registros.Read())
            {
                Job j = new Job((int)registros["job_id"], (string)registros["job_title"], (decimal)registros["min_salary"], (decimal)registros["max_salary"]);
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
            var myForm = new FormUpdate();
            myForm.ShowDialog();
        }
    }
}
