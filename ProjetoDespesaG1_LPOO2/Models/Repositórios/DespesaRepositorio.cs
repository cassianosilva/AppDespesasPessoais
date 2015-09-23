using MySql.Data.MySqlClient;
using PeixeiraConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoDespesaG1_LPOO2.Models
{
    public class DespesaRepositorio
    {
        Database db = new Database();

        public IEnumerable<Despesa> getLasts()
        {
            List<Despesa> despesas = new List<Despesa>();
            string sql = "SELECT d.idDespesa, d.localDespesa, d.dataDespesa, d.valorDespesa, t.idTipo, t.nomeTipo ";
            sql += "FROM despesa d ";
            sql += "INNER JOIN tipodespesa t ";
            sql += "ON d.idTipo = t.idTipo ";
            sql += "ORDER BY idDespesa DESC ";
            sql += "LIMIT 7";
            MySqlDataReader dr = db.executarConsulta(sql);

            while (dr.Read())
            {
                despesas.Add(
                    new Despesa((int)dr["idDespesa"], (string)dr["localDespesa"], dr["dataDespesa"].ToString().Remove(10), 
                    dr["valorDespesa"].ToString(), new TipoDespesa((int)dr["idTipo"], (string)dr["nomeTipo"])));
            }

            return despesas;
        }

        public Despesa getOne(int Id)
        {
            string sql = "SELECT * FROM despesa d ";
            sql += "INNER JOIN tipodespesa t ";
            sql += "ON d.idTipo = t.idTipo";
            MySqlDataReader dr = db.executarConsulta(sql);
            dr.Read();
            Despesa dp = new Despesa((int)dr["idDespesa"], (string)dr["localDespesa"], dr["dataDespesa"].ToString().Remove(10),
                         dr["valorDespesa"].ToString(), new TipoDespesa((int)dr["idTipo"], (string)dr["nomeTipo"]));

            return dp;

        }

        public IEnumerable<Despesa> getByDate(string pData)
        {
            List<Despesa> despesas = new List<Despesa>();
            string sql = "SELECT * FROM despesa d INNER Join tipodespesa t ON d.idTipo = t.idTipo "; 
            sql += "WHERE dataDespesa = '" + pData + "'";
            MySqlDataReader dr = db.executarConsulta(sql);

            while (dr.Read())
            {
                despesas.Add(
                    new Despesa
                    (
                        (int)dr["idDespesa"], (string)dr["localDespesa"], dr["dataDespesa"].ToString().Remove(10),
                        dr["valorDespesa"].ToString(), new TipoDespesa((int)dr["idTipo"], (string)dr["nomeTipo"]))
                    );
            }

            return despesas;
        }

        public void Create(Despesa pDespesa)
        {
            string insertSql = "INSERT INTO despesa (localDespesa,dataDespesa,valorDespesa,idTipo) VALUES ('";
            insertSql += pDespesa.LocalDespesa + "', '" + pDespesa.DataDespesa + "', ";
            insertSql += pDespesa.ValorDespesa + ", " + pDespesa.Tipo.idTipo + ")";

            db.executarComando(insertSql);
        }

        public void Update(Despesa pDespesa)
        {
            string updateSql = "UPDATE despesa SET localDespesa = '" + pDespesa.LocalDespesa + "', ";
            updateSql += "dataDespesa = '" + pDespesa.DataDespesa + "', valorDespesa = " + pDespesa.ValorDespesa + " ";
            updateSql += "WHERE idDespesa = " + pDespesa.IdDespesa;

            db.executarComando(updateSql);
        }

        public void Delete(int Id)
        {
            string deleteSql = "DELETE FROM despesa WHERE idDespesa = " + Id;

            db.executarComando(deleteSql);
        }
    }
}