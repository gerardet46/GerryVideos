using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace c_sahrp
{
    public class BaseDeDatos
    {
        private const string DEL = "(%$#··#·$$@)";
        private string _ruta = Application.StartupPath + "\\db\\";
        public string Tabla { get; set; }
        public BaseDeDatos(string t) { Tabla = t; carpeta(); if (!Existe("Usuarios")) CrearTabla("Usuarios", new string[] { "ID", "Nombre de usuario", "Contraseña" }); }
        /*************************************/
        public static void CrearTabla(string n, string[] col)
        {
            string ruta = Application.StartupPath + "\\db\\" + n + ".gdb";
            File.WriteAllText(ruta, string.Join(DEL, col));
        }

        public static void EliminarTabla(string n)
        {
            string ruta = Application.StartupPath + "\\db\\" + n + ".gdb";
            if (File.Exists(ruta)) File.Delete(ruta);
        }

        public static bool Existe(string nombre) { return File.Exists(Application.StartupPath + "\\db\\" + nombre + ".gdb");}
        /********************************************/
        public void Insertar(List<string> valores)
        {
            excepcion();
            File.AppendAllText(Ruta(), "\r\n" + string.Join(DEL, valores));
        }
        private string actualizar = "\r\n";
        public void Actualizar(Func<string,bool> b, int index, List<string> valores)
        {
            excepcion();
            string[] lineas = SplitLINEAS(File.ReadAllText(Ruta()));
            string txt_nuevo = lineas[0];
            for (int i = 1; i < lineas.Length; i++)
                txt_nuevo += b(SplitDEL(lineas[i])[index]) ? actualizar + string.Join(DEL, valores) : "\r\n" + lineas[i];
            File.WriteAllText(Ruta(), txt_nuevo);
        }
        public void Eliminar(Func<string, bool> b, int index)
        {
            actualizar = "";
            Actualizar(b, index, new List<string>());
            actualizar = "\r\n";
        }

        /*********************************************/
        public List<List<string>> Buscar(Func<string, bool> b, int index, bool col)
        {
            excepcion();

            string txt = File.ReadAllText(Ruta());
            List<List<string>> r = new List<List<string>>();
            if (col) r.Add(SplitDEL(SplitLINEAS(txt)[0]).ToList());

            for (int i = 1; i < SplitLINEAS(txt).Length; i++)
            {
                string celda = SplitDEL(SplitLINEAS(txt)[i])[index];
                if (b(celda)) r.Add(SplitDEL(SplitLINEAS(txt)[i]).ToList());
            }
            return r;
        }

        public List<List<string>> Abrir() { return Buscar(x => x.Length >= 0, 0, true); }

        public void VerEnDGV(DataGridView d, List<List<string>> t)
        {
            d.Rows.Clear(); d.Columns.Clear();
            for (int i = 0; i < t[0].Count; i++) d.Columns.Add(t[0][i], t[0][i]);

            for (int i = 1; i < t.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(d);
                for (int x = 0; x < t[i].Count; x++) row.Cells[x].Value = t[i][x];
                d.Rows.Add(row);
            }
        }
        /********************************************/
        public List<List<string>> DGVaLista(DataGridView d)
        {
            List<List<string>> r = new List<List<string>>();

            List<string> columnas = new List<string>();
            for (int i = 0; i < d.Columns.Count; i++)
                columnas.Add(d.Columns[i].HeaderText);

            r.Add(columnas);

            for (int i = 0; i < d.Rows.Count - 1; i++)
            {
                List<string> celdas = new List<string>();
                foreach (DataGridViewCell cell in d.Rows[i].Cells)
                    celdas.Add(Convert.ToString(cell.Value));
                r.Add(celdas);
            }

            return r;
        }

        public void Guardar(List<List<string>> t)
        {
            List<string> filas = new List<string>();
            for (int i = 0; i < t.Count; i++) filas.Add(string.Join(DEL, t[i]));
            File.WriteAllText(Ruta(), string.Join("\r\n", filas));
        }

        /********************************************/
        private string Ruta() { return _ruta + Tabla + ".gdb"; }
        private void excepcion() { if (Tabla == "" || !File.Exists(Ruta())) throw new Exception("Tabla no encontrada."); }
        private void carpeta() { if (!Directory.Exists(_ruta)) Directory.CreateDirectory(_ruta); }
        private string[] SplitDEL(string txt) { return txt.Split(new string[] { DEL }, StringSplitOptions.None); }
        private string[] SplitLINEAS(string txt) { return txt.Split(new string[] { "\r\n" }, StringSplitOptions.None); }
    }
}