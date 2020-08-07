using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msgapp
{
    public partial class update : Form
    {
        string temp = ""; // carpeta de descarga

        public update()
        {
            InitializeComponent();

            // solo se abrirá si hay una nueva versión
            lbversion.Text = Actualizaciones.getVersion();
            rtbcambios.Text = Actualizaciones.getCambios();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            btnactualizar.Text = "Actualizando...";
            btnactualizar.Enabled = false;

            ProcessStartInfo psi = new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + "updates.exe", lbversion.Text + @" http://localhost/msgapp/msgapp-v" + lbversion.Text + ".zip");
            psi.UseShellExecute = true;
            var d = Process.Start(psi);

            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
            /*WebClient wc = new WebClient();
            wc.DownloadFileCompleted += (s, _e) =>
            {
                // generamos un archivo para instalación
                string batch = Path.Combine(temp, "_update.bat");
                string programa = AppDomain.CurrentDomain.BaseDirectory;

                // reiniciamos el programa para copiar primero los datos
                File.WriteAllText(batch, string.Format(
                    @"timeout /t 3
echo 'copiando nuevos archivos...'
xcopy '{0}' '{1}' /e /d /y /h /r /c
echo 'actualización correcta'
start '{2}\msgapp.exe'
exit", temp, programa, programa));

                Process.Start(batch);
                Environment.Exit(0);
            };

            // descargamos la nueva versión
            string link = "http://localhost/msgapp/msgapp-v" + lbversion.Text + ".zip";
            temp = Path.Combine(Path.GetTempPath(), "msgapp");

            // creamos la carpeta temporal si no existe
            if (Directory.Exists(temp)) eliminarCarpeta(temp);
            Directory.CreateDirectory(temp);

            wc.DownloadFileAsync(new Uri(link), temp);*/
        }


        void eliminarCarpeta(string ruta)
        {
            foreach (string f in Directory.GetFiles(ruta)) File.Delete(f);
            foreach (string d in Directory.GetDirectories(ruta)) eliminarCarpeta(d);

            Directory.Delete(ruta);
        }
    }
}
