using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        Properties.Settings config = new Properties.Settings();
        WebBrowser web = new WebBrowser();
        List<string> seriales = new List<string>();
        List<string> activados = new List<string>();
        public frmprincipal()
        {
            if (config.activado) new frmprograma().ShowDialog();
            InitializeComponent();           
            web.ScriptErrorsSuppressed = true;
            web.Navigate("http://localhost:8080/tutoriales");
            web.DocumentCompleted += Web_DocumentCompleted;
        }

        bool login = true;
        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (login)
            {
                web.Document.GetElementById("codigo").SetAttribute("value", "gerry");
                web.Document.GetElementById("entrar").InvokeMember("click");
                login = false;
            }
            else
            {
                foreach (HtmlElement tr in web.Document.GetElementsByTagName("tr"))
                {
                    int i = 0;
                    foreach (HtmlElement td in tr.Children)
                    {
                        if (i == 0) { seriales.Add(td.InnerText); i = 1; }
                        else { activados.Add(td.InnerText);i = 0; }
                    }
                }
            }
        }

        const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        private void btncomprar_Click(object sender, EventArgs e)
        {
            bool coincide = false;
            // PAGO

            do
            {
                Random rn = new Random();
                string serial = "";
                lbestado.Text = "Generando licencia...";

                for (int i = 0; i < 29; i++)
                {
                    if (i == 5 || i == 11 || i == 17 || i == 23) serial += "-";
                    else serial += caracteres[rn.Next(caracteres.Length)];
                }
                for (int i = 0; i < seriales.Count; i++)
                    if (serial == seriales[i]) coincide = true;

                if (!coincide)
                {
                    lbestado.Text = "Actualizando bases de datos...";
                    web.Document.GetElementById("serial").SetAttribute("value", serial);
                    web.Document.GetElementById("activado").SetAttribute("value", "no");
                    web.Document.GetElementById("btninsertar").InvokeMember("click");
                    txtcomprar.Text = serial;
                    lbestado.Text = "Finalizado";
                }
            } while (coincide);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            bool disponible = false;
            for (int i = 0; i < seriales.Count; i++)
            {
                if (seriales[i] == txtserial.Text && activados[i] == "no")
                {
                    disponible = true;
                    web.Document.GetElementById("serial2").SetAttribute("value", txtserial.Text);
                    web.Document.GetElementById("activado2").SetAttribute("value", "si");
                    web.Document.GetElementById("btnactualizar").InvokeMember("click");
                    config.serial = txtserial.Text;
                    config.activado = true;
                    config.Save();
                    break;
                }
            }
            if (disponible) { MessageBox.Show("Producto activado"); Application.Restart(); }
            else MessageBox.Show("Serial no válido");
        }
    }
}