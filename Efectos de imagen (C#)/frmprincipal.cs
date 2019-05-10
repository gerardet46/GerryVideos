using System.Windows.Forms;
using System.Drawing;
using System;
using System.Diagnostics;

namespace c_sahrp
{
    public partial class frmprincipal : Form
    {
        bool conv = false, neg = false;
        string dir_inicial = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Wallpapers";

        public frmprincipal()
        {
            InitializeComponent();
            btnconvbl.Click += (s, e) => pbblanconegro.Image = blancoynegro();
            btnconvneg.Click += (s, e) => pbneg.Image = negativo();
            btnabrir.Click += (s, e) =>
            {
                OpenFileDialog of = new OpenFileDialog() { Filter = "Imágenes|*.jpg;*.png;*.bmp", InitialDirectory = dir_inicial };
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(of.FileName);
                    pbblanconegro.Image = pbneg.Image = null;
                    conv = neg = false;
                    btnabrir.Text = $"Abrir ({pb.Image.Width}x{pb.Image.Height})";
                }
            };
            btnguardarbl.Click += (s, e) =>
            {
                pbblanconegro.Image = blancoynegro();
                SaveFileDialog sf = new SaveFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp", InitialDirectory = dir_inicial };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pbblanconegro.Image.Save(sf.FileName);
                    Process.Start(sf.FileName);
                }
            };
            btnguardarneg.Click += (s, e) =>
            {
                pbneg.Image = negativo();
                SaveFileDialog sf = new SaveFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp", InitialDirectory = dir_inicial };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pbneg.Image.Save(sf.FileName);
                    Process.Start(sf.FileName);
                }
            };
        }
        Image blancoynegro()
        {
            if (!conv)
            {
                Bitmap bm = new Bitmap(pb.Image);
                progres.Maximum = bm.Width * bm.Height;
                for (int x = 0; x < bm.Width; x++)
                    for(int y = 0; y < bm.Height; y++)
                    {
                        Color c = bm.GetPixel(x, y);
                        int intensidad = (c.R + c.G + c.B) / 3;
                        Color nuevo = Color.FromArgb(intensidad, intensidad, intensidad);
                        bm.SetPixel(x, y, nuevo);
                        progres.Value++;
                    }
                conv = true;
                progres.Value = 0;
                return bm;
            }
            return pbblanconegro.Image;
        }
        Image negativo()
        {
            if (!neg)
            {
                Bitmap bm = new Bitmap(pb.Image);
                progres.Maximum = bm.Width * bm.Height;
                for (int x = 0; x < bm.Width; x++)
                    for (int y = 0; y < bm.Height; y++)
                    {
                        Color c = bm.GetPixel(x, y);
                        Color nuevo = Color.FromArgb(255-c.R, 255-c.G, 255-c.B);
                        bm.SetPixel(x, y, nuevo);
                        progres.Value++;
                    }
                neg = true;
                progres.Value = 0;
                return bm;
            }
            return pbneg.Image;
        }
    }
}