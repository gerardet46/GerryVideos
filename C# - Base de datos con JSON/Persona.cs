using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Ir a paquetes NuGet para obtener el paquete

namespace c_sahrp
{
    public class Persona
    {
        public int DNI;
        public string Nombre;
        public Mascota mascota;

        public Persona(int dni, string nombre, Mascota m)
        {
            DNI = dni;
            Nombre = nombre;
            mascota = m;
        }
    }

    public class Mascota
    {
        public enum TIPO
        {
            NINGUNA = 0,
            PERRO = 1,
            GATO = 2,
            PEZ = 3
        }

        public TIPO tipo;
        public string Nombre;

        public Mascota(string n, TIPO t)
        {
            Nombre = n;
            tipo = t;
        }
    }

    public class Basededatos<T>
    {
        public List<T> valores = new List<T>();
        public string ruta;

        public Basededatos(string r)
        {
            ruta = r;
        }

        public void Guardar()
        {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
            catch (Exception) { }
        }

        public void Insertar(T nuevo)
        {
            valores.Add(nuevo);
            Guardar();
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }

        public void Eliminar(Func<T, bool> criterio)
        {
            valores = valores.Where(x => !criterio(x)).ToList();
        }

        public void Actualizar(Func<T, bool> criterio, T nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}
