using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agoravai.Infra
{
    public class ConexaoDB
    {
        NpgsqlConnection con = new NpgsqlConnection();

        static string servidor = "LocalHost";
        static string bd = "LocalHost";
        static string Usuario = "postgres";
        static string password = "Cisantander1";
        static string port = "5432";

        string conexao = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + Usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public NpgsqlConnection EstabelecerConexao()
        {
            con.ConnectionString = conexao;
            con.Open();

            return con;
        }            
        

    }
}
