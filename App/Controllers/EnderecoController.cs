using agoravai.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace agoravai.Controllers
{
    public class EnderecoController
    {
        
        public string BuscarEssaBomba(string cep)
        {
            try
            {
                string urlBaseApi = $"https://viacep.com.br/ws/{cep}/json/";
                string responseJson = "";
                var client = new RestClient(urlBaseApi);
                var request = new RestRequest(urlBaseApi, Method.Get);

                var tResponse = client.Execute(request);
                var sStatusCod = tResponse.StatusCode;

                if (sStatusCod != HttpStatusCode.OK)
                {
                    return tResponse.Content.ToString();
                }
                else
                {
                    responseJson = tResponse.Content;

                }

                return responseJson.ToString();

            }
            catch (Exception ex)

            {

                MessageBox.Show("Falha ao requisitar a api. Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return ex.ToString();
                //MessageBox.Show("campo" + txtCEP_Str, "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }       
           
     }    

}
