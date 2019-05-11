using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//////////////////////////////////
using System.Windows.Forms;
using System.Data.SqlClient;

namespace c_sahrp
{
    class combobox
    {
        SqlConnection con = new SqlConnection("Data Source=GERRYSOFT; Initial Catalog=Tutoriales; Integrated Security=true");

        public void seleccionar(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from negocio", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "--- Seleccione un item ---");
            cb.SelectedIndex = 0;
        }

        public string[] captar_info(string nombre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from negocio where nombre='" + nombre + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString()
                };
                resultado = valores;
            }
            con.Close();
            return resultado;
        }
    }
}
