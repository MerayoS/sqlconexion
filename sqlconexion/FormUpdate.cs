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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        
        private void btnmodificar_Click(object sender, EventArgs e)
        {

            //string jobTitle = idSelected.JobTitle;
            //Decimal minS = idSelected.MinSal;
            //Decimal maxS = idSelected.MaxSal;

            //string cadena = "Update jobs set job_title = @pJobTitle, min_salary = @pMin, max_salary = @pMax Where job_id =" + idSelected.JobID + " ;";

            //SqlCommand command = new SqlCommand(cadena, Form1.conexion);

            //SqlParameter pJobTitle = new SqlParameter("@pJobTitle", SqlDbType.VarChar, 35);
            //pJobTitle.Value = jobTitle;
            //command.Parameters.Add(pJobTitle);

            //SqlParameter pMin = new SqlParameter("@pMin", SqlDbType.Decimal);
            //pJobTitle.Value = minS;
            //command.Parameters.Add(pMin);

            //SqlParameter pMax = new SqlParameter("@pMax", SqlDbType.Decimal);
            //pJobTitle.Value = maxS;
            //command.Parameters.Add(pMax);

        }
    }
}
