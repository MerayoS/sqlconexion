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
    public partial class Form1 : Form
    {
        public static SqlConnection conexion = null;
     
        public Form1()
        {
            InitializeComponent();
            btndisconect.Enabled = false;
            btninsert.Enabled = false;
            btnselect.Enabled = false;

        }
        public void Conectarse()
        {
            try
            {
                conexion = new SqlConnection("Data source=185.166.215.109,54321;Initial Catalog=SantiagoEmpleados2; Persist Security Info=true; User Id=sa; Password=123456789");
                conexion.Open();
                MessageBox.Show("Conexion establecida correctamente");
                btnconect.Enabled = false;
                btndisconect.Enabled = true;
                btninsert.Enabled = true;
                btnselect.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        public void Desconectarse()
        {
            try
            {
                conexion.Close();
                MessageBox.Show("Se ha desconectado correctamente");
                btnconect.Enabled = true;
                btndisconect.Enabled = false;
                btninsert.Enabled = false;
                btnselect.Enabled = false;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        public void InsertRow()
        {
            
        }
        private void btnconect_Click(object sender, EventArgs e)
        {
            
            Conectarse();
        }

        private void btndisconect_Click(object sender, EventArgs e)
        {
            Desconectarse();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            
            var myForm = new FormInsert();
            myForm.ShowDialog();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            var myForm = new FormSelect();
            myForm.ShowDialog();
        }
    }
}
