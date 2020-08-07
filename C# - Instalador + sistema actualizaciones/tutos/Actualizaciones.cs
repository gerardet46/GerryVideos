using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msgapp
{
    public class Actualizaciones
    {
        public static bool check()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            string servidor = getVersion();

            if (servidor == "error") return false;
            // pasamos a números (separando los puntos)
            // EJ: "1.0.2.5" => [1, 0, 2, 5]
            List<int> v1, v2;
            v1 = version.Split('.').ToList().Select(x => int.Parse(x)).ToList();
            v2 = servidor.Split('.').ToList().Select(x => int.Parse(x)).ToList();

            for (int i = 0; i < 4; i++)
            {
                if (v2[i] > v1[i]) return true; // hay una nueva versión
                if (v2[i] < v1[i]) return false; // tenemos una versión nueva
            }
            // misma versión
            return false;
        }

        public static string getVersion()
        {
            try
            {
                return new WebClient().DownloadString("http://localhost/msgapp/version.txt").Replace("\n", "");
            }
            catch (Exception) { return "error"; }
        }

        public static string getCambios()
        {
            try
            {
                return new WebClient().DownloadString("http://localhost/msgapp/cambios.txt");
            }
            catch (Exception) { return "error"; }
        }
    }
}
