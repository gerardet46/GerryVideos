using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        string tabla = "";
        public frmprincipal()
        {
            InitializeComponent();
            new BaseDeDatos("");

            new BaseDeDatos("Usuarios").VerEnDGV(dgvusuarios, new BaseDeDatos("Usuarios").Abrir()); ////////
            dgvusuarios.Columns[1].Width = 300;
            dgvusuarios.Columns[2].Width = 200;
            dgvusuarios.ReadOnly = true; /////////////////
            //txtid.Text = new_id();

            actualizar(0);
            btnguardar.Enabled = false;
        }
        string id_nuevo()
        {
            var ids = new BaseDeDatos("Usuarios").Abrir().Select(x => x[0]).ToList();
            return ids.Count == 1 ? "0" : (int.Parse(ids[ids.Count - 1]) + 1).ToString();
        }

        void actualizar(int index)
        {
            cb.Items.Clear();
            cb.Items.Add("Selecciona una tabla");
            cb.Items.AddRange(Directory.GetFiles(Application.StartupPath + "\\db\\", "*.gdb").ToList().Select(Path.GetFileNameWithoutExtension).ToArray());
            cb.SelectedIndex = index;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                txtbuscartabla.Enabled = true;
                btnguardar.Enabled = true;
                tabla = cb.SelectedItem.ToString();

                BaseDeDatos db = new BaseDeDatos(tabla);
                List<List<string>> _tabla = db.Abrir();
                db.VerEnDGV(dgvver, _tabla);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            BaseDeDatos db = new BaseDeDatos(tabla);
            db.Guardar(db.DGVaLista(dgvver));
            db.VerEnDGV(dgvver, db.Abrir());
        }

        private void lb_KeyDown(object sender, KeyEventArgs e)
        {
            if (lb.SelectedIndex > -1 && e.KeyCode == Keys.Delete)
                if (MessageBox.Show("Seguro que quieres eliminar la columna \"" + lb.SelectedItem.ToString() + "\"?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                { lb.Items.RemoveAt(lb.SelectedIndex); txtcolumna.Focus(); }
        }

        private void txtcolumna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtcolumna.Text))
            {
                lb.Items.Add(txtcolumna.Text);
                txtcolumna.Clear();
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            BaseDeDatos.CrearTabla(txtcreartabla.Text, lb.Items.OfType<string>().ToArray());
            actualizar(0);
        }

        private void txtbuscartabla_TextChanged(object sender, EventArgs e)
        {
            if (tabla != "")
            {
                BaseDeDatos db = new BaseDeDatos(tabla);
                db.VerEnDGV(dgvver, db.Buscar(x => x.Contains(txtbuscartabla.Text), 0, true));
            }
        }

        private void btnelimartabla_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                BaseDeDatos.EliminarTabla(cb.SelectedItem.ToString());
                MessageBox.Show("Tabla eliminada");
                cb.SelectedIndex = 0;
                tabla = "";
                btnguardar.Enabled = false;
                actualizar(0);
            }
        }

        BaseDeDatos usuarios = new BaseDeDatos("Usuarios");
        private void btninsertar_Click(object sender, EventArgs e)
        {
            txtid.Text = id_nuevo();
            usuarios.Insertar(new List<string>() { txtid.Text, txtusuario.Text, txtcontraseña.Text });
            usuarios.VerEnDGV(dgvusuarios, usuarios.Abrir());
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            usuarios.Actualizar(id => id == txtid.Text, 0, new List<string>() { txtid.Text, txtusuario.Text, txtcontraseña.Text });
            usuarios.VerEnDGV(dgvusuarios, usuarios.Abrir());
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            usuarios.Eliminar(id => id == txtid.Text, 0);
            usuarios.VerEnDGV(dgvusuarios, usuarios.Abrir());
        }

        private void txtbuscarusuario_TextChanged(object sender, EventArgs e)
        {
            new BaseDeDatos("Usuarios").VerEnDGV(dgvusuarios, new BaseDeDatos("Usuarios").Buscar(x => x.Contains(txtbuscarusuario.Text), 1, true));
        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCellCollection row = dgvusuarios.Rows[e.RowIndex].Cells;
                txtid.Text = Convert.ToString(row[0].Value);
                txtusuario.Text = Convert.ToString(row[1].Value);
                txtcontraseña.Text = Convert.ToString(row[2].Value);
            }
        }
    }
}