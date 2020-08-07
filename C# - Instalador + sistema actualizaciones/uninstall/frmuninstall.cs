using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uninstall
{
    public partial class frmuninstall : Form
    {
        public frmuninstall()
        {
            InitializeComponent();
        }

        void eliminarCarpeta(string ruta)
        {
            // no podremos borrar uninstall.exe porque se está usando, por eso están los try-catch
            foreach (string f in Directory.GetFiles(ruta))
            {
                try
                {
                    File.Delete(f);
                }
                catch (Exception) { }
            }
            foreach (string d in Directory.GetDirectories(ruta)) eliminarCarpeta(d);

            try
            {
                // eliminamos la carpeta
                Directory.Delete(ruta);
            }
            catch (Exception) { }
        }

        private void frmuninstall_Load(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Seguro que quieres desinstalar \"msgapp\"", "Desinstalar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (d == DialogResult.No) Environment.Exit(0); // salimos sin desinstalar
            else
            {
                // desinstalamos

                // quitamos los archivos
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                string _nombre = ""; // lo cogeremos del registro

                eliminarCarpeta(ruta);

                // quitamos los datos del registro
                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true).OpenSubKey("Microsoft", true).OpenSubKey("Windows", true)
                    .OpenSubKey("CurrentVersion", true);

                RegistryKey app = key.OpenSubKey("App Paths", true);

                RegistryKey nombre = app.OpenSubKey("msgapp.exe", true);
                _nombre = new DirectoryInfo(nombre.GetValue("Path").ToString()).Name;

                app.DeleteSubKeyTree("msgapp.exe", false);

                RegistryKey unins = key.OpenSubKey("Uninstall", true);
                unins.DeleteSubKeyTree("msgapp", false);

                // quitamos el acceso directo
                try
                {
                    string commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                    string appStartMenuPath = Path.Combine(commonStartMenuPath, "Programs", _nombre);

                    if (!Directory.Exists(appStartMenuPath))
                        Directory.CreateDirectory(appStartMenuPath);

                    string shortcutLocation = Path.Combine(appStartMenuPath, "msgapp (acceso directo)" + ".lnk");
                    File.Delete(shortcutLocation);
                }
                catch (Exception) { }

                // creamos un script para eliminarlo todo ("uninstall.exe" y la carpeta)
                string temp = Path.Combine(Path.GetTempPath(), "msgapp");
                if (!Directory.Exists(temp)) Directory.CreateDirectory(temp);

                string f = Path.Combine(temp, "uninstall.bat");
                File.WriteAllText(f, string.Format(@"sleep 4
del /s /f /q {0}\*.*
for /f %%f in ('dir /ad /b {1}') do rd /s /q {2}\%%f
del {0}", new[] { ruta, ruta, ruta, ruta }));

                MessageBox.Show("Aplicación desinstalada!");
                Process.Start(f);
                Environment.Exit(0);

            }
        }
    }
}
