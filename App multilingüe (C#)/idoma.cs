using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sahrp
{
    public static class idioma
    {
        public static Dictionary<string, string> info = new Dictionary<string, string>();

        private static void cargar(string archivo)
        {
            info.Clear();
            foreach (string linea in File.ReadLines("lang\\" + archivo))
            {
                if (linea.Contains("="))
                {
                    string[] s = linea.Split(new char[] { '=' });
                    info.Add(s[0], s[1]);
                }
            }
        }

        public static void cambiarIdioma(string archivo)
        {
            Properties.Settings config = new Properties.Settings();
            config.lang = archivo;
            config.Save();
            cargar(archivo);
        }

        static public void controles(Form f)
        {
            foreach (string control in info.Keys)
            {
                try
                {
                    f.Controls[control].Text = info[control];
                } catch (Exception e) { }
            }
        }
    }
}
