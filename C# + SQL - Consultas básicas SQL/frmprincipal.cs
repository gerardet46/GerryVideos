using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        ConsultasSQL sql = new ConsultasSQL();

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgv.Rows[e.RowIndex];
            txtID.Text = Convert.ToString(fila.Cells[0].Value);
            txtnombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtprecio.Text = Convert.ToString(fila.Cells[2].Value);
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            txtID.Text = dgv.Rows.Count.ToString();
            if (sql.Insertar(txtID.Text, txtnombre.Text, txtprecio.Text))
            {
                MessageBox.Show("Datos insertados");
                dgv.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido insertar los datos");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(txtID.Text))
            {
                MessageBox.Show("Datos eliminados");
                dgv.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(txtID.Text, txtnombre.Text, txtprecio.Text))
            {
                MessageBox.Show("Datos actualizados");
                dgv.DataSource = sql.MostrarDatos();
            }
            else MessageBox.Show("No se han podido actualizar los datos");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "") dgv.DataSource = sql.Buscar(txtbuscar.Text);
            else dgv.DataSource = sql.MostrarDatos();
        }
    }
}
