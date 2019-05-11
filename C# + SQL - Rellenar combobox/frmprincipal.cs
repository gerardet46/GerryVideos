using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        combobox combo = new combobox();
        public frmprincipal()
        {
            InitializeComponent();
            combo.seleccionar(cb);
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                string[] valores = combo.captar_info(cb.Text);
                lbid.Text = "Id: "+ valores[0];
                lbcolor.Text = "Color: " + valores[1];
                lbprecio.Text = "Precio: " + valores[2];
            }
        }
    }
}