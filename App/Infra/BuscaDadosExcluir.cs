using agoravai.Models;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agoravai.Infra
{
    public class BuscaDadosExcluir : ModeloRelatorio
    {

        public List<ModeloRelatorio> BuscaParaExcluir (string cep)
        {

            List<ModeloRelatorio> listaDadosRelatorio = new List<ModeloRelatorio>();
            try
            {
                var connection = new ConexaoDB().EstabelecerConexao();
                var cmd = connection.CreateCommand();
                //cmd.CommandTimeout = 10000;

                cmd.CommandText = $@"SELECT DISTINCT ON (cep_str) cep_str, logradouro_str, complemento_str,bairro_str, localidade_str, uf_str,ibge_str,gia_str,ddd_str,siafi_str FROM es_viacep WHERE cep_str = '{cep}' ";
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();

                da.SelectCommand = new NpgsqlCommand(cmd.CommandText, connection);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ModeloRelatorio modelo = new ModeloRelatorio();
                        modelo.cep = dr["cep_str"].ToString();
                        modelo.logradouro = dr["logradouro_str"].ToString();
                        modelo.complemento = dr["complemento_str"].ToString();
                        modelo.bairro = dr["bairro_str"].ToString();
                        modelo.localidade = dr["localidade_str"].ToString();
                        modelo.uf = dr["uf_str"].ToString();
                        modelo.ibge = dr["ibge_str"].ToString();
                        modelo.gia = dr["gia_str"].ToString();
                        modelo.ddd = dr["ddd_str"].ToString();
                        modelo.siafi = dr["siafi_str"].ToString();

                        listaDadosRelatorio.Add(modelo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaDadosRelatorio;
        }

    }          

}
