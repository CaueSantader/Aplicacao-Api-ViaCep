using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using agoravai.Models;
using Dapper;
using System.Data;
using Npgsql;
using System.Data.Common;
using ClosedXML.Excel;
namespace agoravai.Infra
{

    public class ExpotaDadosRepository : Relatorio
    {

        public override string ExportaDados(List<ModeloRelatorio> listaDadosRelatorio)
        {
            //Buscadados();

            try
            {

                string relatorio = String.Empty;

                var userDirectoryTel = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                caminhoRelatorio = $"{userDirectoryTel}" + @"\Documents\Exporta Consulta\";

                if (!Directory.Exists(caminhoRelatorio))
                {
                    Directory.CreateDirectory(caminhoRelatorio);
                }


                relatorio = $"{caminhoRelatorio}" + $"Dados Consultas - {DateTime.Now.ToString("dd-MM-yyyy HH_mm")}.xlsx";

                using (var workbook = new XLWorkbook())
                {
                    int totalLinhas = listaDadosRelatorio.Count;
                    //progressBar1.Minimum = 0;
                    var worksheet = workbook.Worksheets.Add("DADOS");

                    worksheet.Cell("A" + (1)).Value = "CEP";
                    worksheet.Cell("B" + (1)).Value = "LOGRADOURO";
                    worksheet.Cell("C" + (1)).Value = "COMPLEMENTO";
                    worksheet.Cell("D" + (1)).Value = "BAIRRO";
                    worksheet.Cell("E" + (1)).Value = "LOCALIDADE";
                    worksheet.Cell("F" + (1)).Value = "UF";
                    worksheet.Cell("G" + (1)).Value = "IBGE";
                    worksheet.Cell("H" + (1)).Value = "GIA";
                    worksheet.Cell("I" + (1)).Value = "DDD";
                    worksheet.Cell("J" + (1)).Value = "SIAPE";



                    workbook.SaveAs(relatorio);

                    for (int i = 0; i < listaDadosRelatorio.Count; i++)
                    {

                        worksheet.Cell("A" + (2 + i)).Value = listaDadosRelatorio[i].cep;
                        worksheet.Cell("B" + (2 + i)).Value = listaDadosRelatorio[i].logradouro;
                        worksheet.Cell("C" + (2 + i)).Value = listaDadosRelatorio[i].complemento;
                        worksheet.Cell("D" + (2 + i)).Value = listaDadosRelatorio[i].bairro;
                        worksheet.Cell("E" + (2 + i)).Value = listaDadosRelatorio[i].localidade;
                        worksheet.Cell("F" + (2 + i)).Value = listaDadosRelatorio[i].uf;
                        worksheet.Cell("G" + (2 + i)).Value = listaDadosRelatorio[i].ibge;
                        worksheet.Cell("H" + (2 + i)).Value = listaDadosRelatorio[i].gia;
                        worksheet.Cell("I" + (2 + i)).Value = listaDadosRelatorio[i].ddd;
                        worksheet.Cell("J" + (2 + i)).Value = listaDadosRelatorio[i].siafi;

                        workbook.SaveAs(relatorio);
                    }
                }

                return relatorio;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

    
}
