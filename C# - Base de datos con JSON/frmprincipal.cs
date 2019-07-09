using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        Basededatos<Persona> bd = new Basededatos<Persona>("bd.json");

        void mostrar(List<Persona> lista)
        {
            dgv.Rows.Clear();

            foreach (Persona p in lista)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.DNI });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Nombre });
                dgv.Rows.Add(fila);
            }
        }
        public frmprincipal()
        {
            InitializeComponent();
            cbmascota.SelectedIndex = 0;
            bd.Cargar();
            mostrar(bd.valores);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Mascota.TIPO t;
            switch (cbmascota.SelectedIndex)
            {
                case 1: t = Mascota.TIPO.PERRO; break;
                case 2: t = Mascota.TIPO.GATO; break;
                case 3: t = Mascota.TIPO.PEZ; break;
                default: t = Mascota.TIPO.NINGUNA; break;
            }

            Mascota m = new Mascota(txtmascota.Text, t);
            Persona p = new Persona((new Random()).Next(10000000, 99999999), txtnombre.Text, m);
            bd.Insertar(p);
            mostrar(bd.valores);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(txtdni.Text);

            Mascota.TIPO t;
            switch (cbmascota.SelectedIndex)
            {
                case 1: t = Mascota.TIPO.PERRO; break;
                case 2: t = Mascota.TIPO.GATO; break;
                case 3: t = Mascota.TIPO.PEZ; break;
                default: t = Mascota.TIPO.NINGUNA; break;
            }
            Mascota m = new Mascota(txtmascota.Text, t);
            Persona p = new Persona(DNI, txtnombre.Text, m);
            bd.Actualizar(x => x.DNI == DNI, p);
            mostrar(bd.valores);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(txtdni.Text);
            bd.Eliminar(x => x.DNI == DNI);
            mostrar(bd.valores);
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            var lista = bd.Buscar(x => x.Nombre.Contains(txtbusca.Text));
            mostrar(lista);
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona p = bd.Buscar(x => x.DNI.ToString() == dgv.CurrentRow.Cells[0].Value.ToString())[0];
            txtdni.Text = p.DNI.ToString();
            txtnombre.Text = p.Nombre;
            txtmascota.Text = p.mascota.Nombre;
            cbmascota.SelectedIndex = (int)p.mascota.tipo;
        }
    }
}
