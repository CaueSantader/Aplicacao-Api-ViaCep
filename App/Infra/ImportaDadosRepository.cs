using agoravai.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agoravai.Infra
{
    public class ImportaDadosRepository : ModeloRelatorio
    {

        public void ImportaDados()
        {
            var Insere = new InsereDadosRepository();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "CSV(separado por vírgulas) | (*.csv)";
            // CSV(separado por vírgulas)(*.csv)
            open.ShowDialog();


            if (string.IsNullOrEmpty(open.Filter) == false)
            {
                try
                {
                    StreamReader csv = new StreamReader(open.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)) ;
                    string linha;
                    string[] campo;

                    while ((linha = csv.ReadLine()) != null)
                    {
                       campo = linha.Split(';');

                        Insere.InsereDados(campo);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
