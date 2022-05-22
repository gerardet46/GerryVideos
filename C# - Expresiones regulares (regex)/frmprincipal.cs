using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
            lbcoincide.Text = "";
        }

        private void txttexto_TextChanged(object sender, EventArgs e)
        {
            /* numero----------- ^[0-9]+([.|,][0-9]+)?$
             * html------------- \<[^\>]+\>
             * link------------- \<a[^\>]*[\s]href="(?<link>[^"]*)"[^\>]*\>
             * telefono--------- ^(((\(\+34\))|\+34)[\s])?[6|8|9][0-9]{2}([0-9]{6}|([\s][0-9]{3}){2}|([\s][0-9]{2}){3})$
             */
            Regex rx = new Regex(@"\<a[^\>]*[\s]href="+"\""+"(?<link>[^" + "\"" + "]*)" + "\"" + @"[^\>]*\>");

            if (rx.IsMatch(txttexto.Text))
            {
                lbcoincide.Text = "si";
                foreach (Match mt in rx.Matches(txttexto.Text))
                {
                    lbcoincide.Text = mt.Groups["link"].Value;
                }
            }
            else lbcoincide.Text = "no";

            //lbcoincide.Text = rx.Replace(txttexto.Text, "");
        }
    }
}