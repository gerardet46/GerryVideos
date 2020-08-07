using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// para ponerlo en el menú de windows
using IWshRuntimeLibrary;
// para el registro
using Microsoft.Win32;

namespace instalador
{
    public partial class frminstalador : Form
    {
        List<Panel> paginas = new List<Panel>(); // para los paneles
        int indice = 0; // indice del panel

        string ruta = "";
        string pathToExe = "";
        string temp = ""; // descarga del programa, luego se extrae el zip

        WebClient wc = new WebClient();
        string VERSION = "", ARCHIVO = "", URL = "";
       
        public frminstalador()
        {
            InitializeComponent();

            // primero de todo comprobamos la última versión
            VERSION = new WebClient().DownloadString("http://localhost/msgapp/version.txt").Replace("\n", "");
            lbversion.Text = VERSION;
            
            // ahora detectamos el link al archivo
            ARCHIVO = "msgapp-v" + VERSION + ".zip";
            URL = "http://localhost/msgapp/" + ARCHIVO;
       
            // añadimos a la lista de páginas
            paginas.Add(panel1);
            paginas.Add(panel2);
            paginas.Add(panel3);
            paginas.Add(panel4);
            paginas.Add(panel5);

            // navegamos a la primera (Bienvenida)
            pagina();

            // ruta predeterminada de programas ("C:\Program Files\")
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            txtruta.Text = ruta;

            // para la dscarga del programa
            wc.DownloadProgressChanged += (s, e) =>
            {
                pbinstalacion.Value = e.ProgressPercentage;
            };
            wc.DownloadFileCompleted += (s, e) =>
            {
                if (!e.Cancelled)
                {
                    // si no se ha cancelado, extraemos el archivo en la carpeta de instalación
                    string carpeta = Path.Combine(ruta, "msgapp");
                    if (Directory.Exists(carpeta)) eliminarCarpeta(carpeta);
                    Directory.CreateDirectory(carpeta);

                    rtbprogreso.AppendText("\nExtrayendo/copiando archivos");
                    ZipFile.ExtractToDirectory(temp, carpeta); // extraemos el archivo

                    rtbprogreso.AppendText("\nAgregando al registro...");
                    // agregando al menú de inicio
                    pathToExe = Path.Combine(carpeta, "msgapp.exe");
                    addInicio();

                    // la agregamos al registro
                    RegistryKey __key = Registry.LocalMachine.OpenSubKey("Software", true)
                    .OpenSubKey("Microsoft", true).OpenSubKey("Windows", true)
                    .OpenSubKey("CurrentVersion", true);
                    
                    RegistryKey key = __key.OpenSubKey("App Paths", true);

                    key.CreateSubKey("msgapp.exe", true);
                    key = key.OpenSubKey("msgapp.exe", true);
                    key.SetValue("", Path.Combine(carpeta, "msgapp.exe"));
                    key.SetValue("Path", carpeta);

                    // lo mismo para desinstalarla
                    RegistryKey unins = __key.OpenSubKey("Uninstall", true);
                    unins.CreateSubKey("msgapp", true);
                    unins = unins.OpenSubKey("msgapp", true);

                    unins.SetValue("DisplayName", "MsgApp");
                    unins.SetValue("DisplayVersion", VERSION); // versión que se mostrará
                    unins.SetValue("UninstallString", Path.Combine(carpeta, "uninstall.exe")); // ruta para desinstalar
                    
                    pbinstalacion.Value = pbinstalacion.Maximum;

                    MessageBox.Show("Instalación completada");
                    Environment.Exit(0);
                }
            };
        }

        void pagina()
        {
            // mostramos la página actual
            paginas[indice].BringToFront();
            switch (indice)
            {
                case 0:
                    // bienvenida
                    btnatras.Enabled = false;
                    btnsiguiente.Enabled = true;
                    break;
                case 1:
                    // licencia
                    btnatras.Enabled = true;
                    btnsiguiente.Enabled = false;
                    break;
                case 3:
                    // para instalar
                    btnsiguiente.Text = "Instalar";
                    break;
                case 4:
                    btnsiguiente.Text = "Instalando...";
                    btnsiguiente.Enabled = false;
                    btnatras.Text = "Cancelar";
                    break;
                default: break;
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (indice == paginas.Count - 1) Environment.Exit(0);
            // vamos a la siguiente página
            ++indice;
            pagina();

            // si se está instalando
            if (btnsiguiente.Text == "Instalando...")
            {
                temp = Path.Combine(Path.GetTempPath(), "msgapp");

                if (Directory.Exists(temp)) eliminarCarpeta(temp);
                Directory.CreateDirectory(temp);

                temp = Path.Combine(temp, ARCHIVO);

                wc.DownloadFileAsync(new Uri(URL), temp); // descargamos el programa para luego extraerlo
                rtbprogreso.Text = "Descargando " + URL;
                lbprogreso.Text = "Instalando...";
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (btnatras.Text == "Cancelar")
            {
                // pedimos confirmación para salir
                var d = MessageBox.Show("Seguro que quieres salir?", "Instalación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (d == DialogResult.Yes)
                {
                    // cancelamos y salimos
                    if (wc.IsBusy) wc.CancelAsync();
                    Environment.Exit(0);
                }
            }
            --indice;
            pagina();
        }

        private void rbnoacepto_CheckedChanged(object sender, EventArgs e)
        {
            // código para (no) aceptar la licencia
            if (rbnoacepto.Checked)
            {
                // no la acepta
                btnsiguiente.Enabled = false;
            }
            else btnsiguiente.Enabled = true;
        }


        // para ponerlo en el menú de inicio

        private void addInicio()
        {
            string commonStartMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
            string appStartMenuPath = Path.Combine(commonStartMenuPath, "Programs", txtmenuinicio.Text);

            if (!Directory.Exists(appStartMenuPath))
                Directory.CreateDirectory(appStartMenuPath);

            string shortcutLocation = Path.Combine(appStartMenuPath, "msgapp (acceso directo)" + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "Muestra un mensaje";
            //shortcut.IconLocation = @"C:\Program Files (x86)\TestApp\TestApp.ico"; //uncomment to set the icon of the shortcut
            shortcut.TargetPath = pathToExe;
            shortcut.Save();
        }

        // para seleccionar la carpeta de instalación
        private void btncarpeta_Click(object sender, EventArgs e)
        {
            // seleccionamos otra carpeta para la instalación
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtruta.Text = fbd.SelectedPath;
                ruta = fbd.SelectedPath;
                pathToExe = Path.Combine(ruta, "msgapp.exe");
            }
        }

        // método para eliminar una carpeta por completo
        private void eliminarCarpeta(string ruta)
        {
            foreach (string ar in Directory.GetFiles(ruta)) System.IO.File.Delete(ar);
            foreach (string ca in Directory.GetDirectories(ruta)) eliminarCarpeta(ca);

            Directory.Delete(ruta);
        }
    }
}
