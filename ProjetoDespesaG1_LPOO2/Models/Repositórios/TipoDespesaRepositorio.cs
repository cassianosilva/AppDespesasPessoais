using MySql.Data.MySqlClient;
using PeixeiraConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoDespesaG1_LPOO2.Models
{
    public class TipoDespesaRepositorio
    {
        public static List<TipoDespesa> GetTipos()
        {
            Database conn = new Database();
            List<TipoDespesa> tipos = new List<TipoDespesa>();

            string sql = "SELECT * FROM tipodespesa";
            MySqlDataReader dr = conn.executarConsulta(sql);

            while (dr.Read())
            {
                tipos.Add(new TipoDespesa((int)dr["idTipo"], (string)dr["nomeTipo"]));
            }

            return tipos;
        }
    }
}