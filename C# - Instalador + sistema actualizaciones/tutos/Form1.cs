using msgapp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            label1.Text = "versión: " + fvi.FileVersion;


            // comprobamos actualizaciones (cada vez que se inicia el programa)
            if (Actualizaciones.check())
            {
                var d = new update();
                d.ShowDialog();
                d.Dispose();
            }
        }

        private void btnmensaje_Click(object sender, EventArgs e)
        {
            var PATH = AppDomain.CurrentDomain.BaseDirectory;

            if (!File.Exists(PATH + "config\\datos.txt"))
            {
                if (!Directory.Exists(PATH + "config")) Directory.CreateDirectory(PATH + "config");
                File.WriteAllText(PATH + "config\\datos.txt", "Eiii qué tal??");
            }

            MessageBox.Show(File.ReadAllText(PATH + "config\\datos.txt"), "Título", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
