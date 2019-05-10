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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            idioma.controles(this);
            this.Text = idioma.info["titulo2"];
        }
    }
}
