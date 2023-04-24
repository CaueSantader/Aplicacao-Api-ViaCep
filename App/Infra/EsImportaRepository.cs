using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Dapper;
using agoravai.Models;

namespace agoravai.Infra
{
    public class EsImportaRepository
    {
        public void EsImportaUpdateBanco(DadosRetorno dadosRetorno)
        {
            
            var sql = @"INSERT INTO es_viacep (cep_str, logradouro_str, complemento_str,bairro_str, localidade_str, uf_str,ibge_str,gia_str,ddd_str,siafi_str, tstamp) 
                       VALUES (@cep_str, @logradouro_str,@complemento_str ,@bairro_str, @localidade_str, @uf_str, @ibge_str, @gia_str, @ddd_str, @siafi_str, current_timestamp )";

            using (var connection = new ConexaoDB().EstabelecerConexao())
            {
                connection.Execute(sql, new { cep_str = dadosRetorno.cep, logradouro_str = dadosRetorno.logradouro, complemento_str = dadosRetorno.complemento, bairro_str = dadosRetorno.bairro, localidade_str = dadosRetorno.localidade, uf_str = dadosRetorno.uf, ibge_str = dadosRetorno.ibge, gia_str = dadosRetorno.gia, ddd_str = dadosRetorno.ddd, siafi_str = dadosRetorno.siafi });
                
            }
        }
    }
 }

