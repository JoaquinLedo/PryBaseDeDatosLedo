using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace PryBaseDeDatosLedo
{
    public partial class Form1 : Form
    {
        //declaro el objeto de base de datos 
        OleDbConnection conectionbD;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectionbD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= E:\\Escritorio\\PryBaseDeDatosLedo\\base\\2_EL_CLUB.accdb");
            conectionbD.Open();
            lblConectar.Text = "conctar base de datos";
            lblConectar.BackColor = Color.Green;

        }
    }
}
