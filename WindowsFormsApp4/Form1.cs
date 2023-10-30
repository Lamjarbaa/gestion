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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string CON = "Data Source=.;Initial Catalog=gestion_ecole;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM etudiant", CON);
            dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void suprimer_Click(object sender, EventArgs e)
        {

        }
    }
}


