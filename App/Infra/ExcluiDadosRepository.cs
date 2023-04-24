using agoravai.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agoravai.Infra
{
    public class ExcluiDadosRepository
    {

        public void ExcluiDados(string cep)
        {

            var sql = $@"DELETE FROM es_viacep WHERE cep_str = '{cep}'";

            using (var connection = new ConexaoDB().EstabelecerConexao())
            {
                connection.Execute(sql);
            }
        }




    }
}
