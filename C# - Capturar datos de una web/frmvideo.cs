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

namespace c_sahrp
{
    public partial class frmvideo : Form
    {
        public frmvideo()
        {
            InitializeComponent();   
        }

        WebBrowser navegador = new WebBrowser();
        private void Form1_Load(object sender, EventArgs e)
        {
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datos_cargados);
        }

        private void datos_cargados(object sender, EventArgs e)
        {
            try
            {
                txttitulo.Text = navegador.Document.GetElementById("eow-title").InnerText;
                rtbdescripcion.Text = navegador.Document.GetElementById("eow-description").InnerText;

                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("g-hovercard yt-uix-sessionlink      spf-link "))
                    {
                        txtcategoria.Text = etiqueta.InnerText;
                    }
                }
                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("yt-subscription-button-subscriber-count-branded-horizontal yt-subscriber-count"))
                    {
                        txtsuscriptores.Text = etiqueta.InnerText;
                    }
                }
                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("yt-uix-button yt-uix-button-size-default yt-uix-button-opacity yt-uix-button-has-icon no-icon-markup like-button-renderer-like-button like-button-renderer-like-button-unclicked yt-uix-clickcard-target   yt-uix-tooltip"))
                    {
                        txtlikes.Text = etiqueta.InnerText;
                    }
                }
                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("yt-uix-button yt-uix-button-size-default yt-uix-button-opacity yt-uix-button-has-icon no-icon-markup like-button-renderer-dislike-button like-button-renderer-dislike-button-unclicked yt-uix-clickcard-target   yt-uix-tooltip"))
                    {
                        txtdislikes.Text = etiqueta.InnerText;
                    }
                }
                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("watch-view-count"))
                    {
                        txtvisualizaciones.Text = etiqueta.InnerText;
                    }
                }
                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("watch-time-text"))
                    {
                        txtfecha.Text = etiqueta.InnerText;
                    }
                }
                int a = 0;
                foreach (HtmlElement etiqueta in navegador.Document.All)
                {
                    if (etiqueta.GetAttribute("classname").Contains("g-hovercard yt-uix-sessionlink      spf-link ") && a == 0)
                    {
                        txtcanal.Text = etiqueta.InnerText;
                        a += 1;
                    }
                }
                foreach (HtmlElement etiqueta in navegador.Document.GetElementsByTagName("img"))
                {
                    if (etiqueta.GetAttribute("alt").Contains(txtcanal.Text))
                    {
                        pbcanal.ImageLocation = etiqueta.GetAttribute("data-thumb");
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btncapturar_Click(object sender, EventArgs e)
        {
            navegador.Navigate(txturl.Text);
        }
    }
}



