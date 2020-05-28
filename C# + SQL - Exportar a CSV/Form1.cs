using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;


namespace tutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=localhost\\SQLEXPRESS;Initial Catalog=tutos;Trusted_Connection=true");
            try
            {
                con.Open();

                SqlDataAdapter adap = new SqlDataAdapter(txtconsulta.Text, con);
                DataTable tabla = new DataTable();
                adap.Fill(tabla);

                List<string> lineas = new List<string>(), columnas = new List<string>();
                foreach (DataColumn col in tabla.Columns) columnas.Add(col.ColumnName);

                lineas.Add(string.Join(txtsep.Text, columnas));
                foreach (DataRow fila in tabla.Rows)
                {
                    List<string> celdas = new List<string>();
                    foreach (object celda in fila.ItemArray) celdas.Add(celda.ToString());

                    lineas.Add(string.Join(txtsep.Text, celdas));
                }
                File.WriteAllLines(txtruta.Text, lineas);
             
                con.Close();
                MessageBox.Show("OKEY!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnabrir_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK) txtruta.Text = sfd.FileName;
        }

        private void btnverarchivo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtruta.Text);
        }
    }
}
