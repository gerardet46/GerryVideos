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
    public partial class frmprograma : Form
    {
        WebBrowser web = new WebBrowser();
        List<string> seriales = new List<string>();
        List<string> activados = new List<string>();
        public frmprograma()
        {
            InitializeComponent();
            this.FormClosed += delegate (object sender, FormClosedEventArgs e) { Application.Exit(); };
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
                        else { activados.Add(td.InnerText); i = 0; }
                    }
                }
            }
        }

        Properties.Settings config = new Properties.Settings();
        private void btndesactivar_Click(object sender, EventArgs e)
        {
            web.Document.GetElementById("serial2").SetAttribute("value", config.serial);
            web.Document.GetElementById("activado2").SetAttribute("value", "no");
            web.Document.GetElementById("btnactualizar").InvokeMember("click");
            config.serial = "";
            config.activado = false;
            config.Save();
            Application.Restart();
        }
    }
}
