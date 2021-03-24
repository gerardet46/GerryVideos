using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace update
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa de actualización
            //if (args.Length < 2) Environment.Exit(1);

            string version = args[0];
            string link = args[1];
            //string version = "1.1.0.0";
            //string link = "http://localhost/msgapp/msgapp-v1.1.0.0.zip";

            string carpeta = AppDomain.CurrentDomain.BaseDirectory;
            string archivo = Path.Combine(carpeta, version + ".zip");


            WebClient wc = new WebClient();

            wc.DownloadFileCompleted += (s, e) =>
            {
                // cuando acabe la descarga
                Console.WriteLine("Copiando archivos...");
                ZipFile.ExtractToDirectory(archivo, carpeta);
                File.Delete(archivo);
                Console.WriteLine("Hecho");
                Process.Start("msgapp.exe");
                Environment.Exit(0);
            };

            Console.WriteLine("Dercargando " + link);
            wc.DownloadFile(new Uri(link), archivo);

            ZIP.ExtractToDirectory(new ZipArchive(new FileStream(archivo, FileMode.Open)),
                carpeta, true);

            //ZipFile.ExtractToDirectory(archivo, carpeta);
            try
            {
                File.Delete(archivo);
            }
            catch (Exception ex) { }

            Console.WriteLine("Hecho");
            Process.Start("msgapp.exe");
            Environment.Exit(0);
        }
   }

    static class ZIP
    {
        // extraer reemplazando archivos
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.Combine(destinationDirectoryName, file.FullName);
                string directory = Path.GetDirectoryName(completeFileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                if (file.Name != "" && file.Name != "updates.exe")
                    file.ExtractToFile(completeFileName, true);
            }
        }
    }
}