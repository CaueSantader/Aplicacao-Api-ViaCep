using agoravai.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agoravai.Infra
{
    public class InsereDadosRepository : ModeloRelatorio
    {

        public void InsereDados(string[] campo)
        {
            var sql = @"INSERT INTO es_viacep (cep_str, logradouro_str, complemento_str,bairro_str, localidade_str, uf_str,ibge_str,gia_str,ddd_str,siafi_str, tstamp) 
                       VALUES (@cep_str, @logradouro_str,@complemento_str ,@bairro_str, @localidade_str, @uf_str, @ibge_str, @gia_str, @ddd_str, @siafi_str, current_timestamp )";

            using (var connection = new ConexaoDB().EstabelecerConexao())
            {
                connection.Execute(sql, new { cep_str = campo[0], logradouro_str = campo[1], complemento_str = campo[2], bairro_str = campo[3], localidade_str = campo[4], uf_str = campo[5], ibge_str = campo[6], gia_str = campo[7], ddd_str = campo[8], siafi_str = campo[9] });

            }


        }

    }
}
