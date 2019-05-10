using System.Windows.Forms;
using System.Drawing;
using System;
using System.Diagnostics;
using System.Text;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        void actualizar()
        {
            idioma.controles(this);

            this.Text = idioma.info["titulo"];
            idiomaToolStripMenuItem.Text = idioma.info["idiomaToolStripMenuItem"];
            opcionesToolStripMenuItem.Text = idioma.info["opcionesToolStripMenuItem"];
            cerrarProgramaToolStripMenuItem.Text = idioma.info["cerrarProgramaToolStripMenuItem"];
            irAlOtroFormularioToolStripMenuItem.Text = idioma.info["irAlOtroFormularioToolStripMenuItem"];
        }

        public frmprincipal()
        {
            InitializeComponent();
            actualizar();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void irAlOtroFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idioma.cambiarIdioma("es.txt");
            actualizar();
        }

        private void catalàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idioma.cambiarIdioma("ca.txt");
            actualizar();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idioma.cambiarIdioma("en.txt");
            actualizar();
        }
    }
}