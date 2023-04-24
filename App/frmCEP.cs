using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using agoravai.Controllers;
using agoravai.Infra;
using agoravai.Models;
using Newtonsoft.Json;

namespace agoravai
{
    public partial class frmCEP : Form
    {
        public frmCEP()
        {
            InitializeComponent();
        }
  

        private void btnloc_Click(object sender, EventArgs e)
        {

            var importacao = new EsImportaRepository();

            string txtCEP_Str;
            txtCEP_Str = btncep.Text;

            if (txtCEP_Str.Length == 8)
            {
                //MessageBox.Show("campo" + txtCEP_Str, "Atencao!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                EnderecoController rb = new EnderecoController();

                string retorno = rb.BuscarEssaBomba(txtCEP_Str);

                if (!string.IsNullOrEmpty(retorno))
                {
                    var jsonObject = JsonConvert.DeserializeObject<DadosRetorno>(retorno);
                    var ObjectToJson = JsonConvert.SerializeObject(jsonObject);

                    txtLocalidade.Text = jsonObject.localidade;
                    txtUf.Text = jsonObject.uf;
                    txtLogradouro.Text = jsonObject.logradouro;
                    txtComplemento.Text = jsonObject.complemento;
                    txtBairro.Text = jsonObject.bairro;
                    txtIbge.Text = jsonObject.ibge;
                    txtGia.Text = jsonObject.gia;
                    txtDdd.Text = jsonObject.ddd;
                    txtSiafi.Text = jsonObject.siafi;


                    importacao.EsImportaUpdateBanco(jsonObject);
                }
            }
            else
            {
                MessageBox.Show("CEP Inválido ou Vazio, Pesquise um CEP Valido e após Clique em 'BUSCAR CEP' . ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnsair_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Dejesa Sair da Aplicação?", "Saindo...",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Dejesa Realizar Uma Nova Consulta?", "Limpando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btncep.Text = "";
                    txtLocalidade.Text = "";
                    txtUf.Text = "";
                    txtLogradouro.Text = "";
                    txtComplemento.Text = "";
                    txtBairro.Text = "";
                    txtIbge.Text = "";
                    txtGia.Text = "";
                    txtDdd.Text = "";
                    txtSiafi.Text = "";
                }
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var Exportar = new ExpotaDadosRepository();
            var Buscar = new BuscaDadosRepository();
            try
            {
                List<ModeloRelatorio> listaDadosRelatorio = Buscar.Buscadados();
                string arquivo = String.Empty;
                arquivo = Exportar.ExportaDados(listaDadosRelatorio);

                MessageBox.Show("Dados Exportados Com Sucesso. Verifique o Diretório 'C:\\Users\\Usuario\\Documents\\Exporta Consulta\\' ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro inesperado {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            var Importar = new ImportaDadosRepository();
            try
            {
                Importar.ImportaDados();
                MessageBox.Show("Dados Importados Com Sucesso. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro inesperado {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnbuscacepbd_Click(object sender, EventArgs e)
        {
            string txtCepExcluir;
            txtCepExcluir = txtcepbd.Text;

            if (txtCepExcluir.Length == 8)
            {
                txtCepExcluir = txtCepExcluir.Substring(0, 5) + "-" + txtCepExcluir.Substring(5, 3);

                BuscaDadosExcluir rb = new BuscaDadosExcluir();

                List<ModeloRelatorio> listaDadosRelatorio = rb.BuscaParaExcluir(txtCepExcluir);

                for (int i = 0; i < listaDadosRelatorio.Count; i++)
                {
                    txtLogradouroexc.Text = listaDadosRelatorio[i].logradouro;

                    txtcepbd.Text = listaDadosRelatorio[i].cep;
                }
            }
            else
            {
                MessageBox.Show("CEP Inválido ou Vazio, Pesquise um CEP Valido e após Clique em 'BUSCAR CEP' . ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Deletar = new ExcluiDadosRepository();
            string txtCepPreenchido;
            txtCepPreenchido = txtcepbd.Text;


            if (txtCepPreenchido.Length == 8)
            {
                try
                {
                    txtCepPreenchido = txtCepPreenchido.Substring(0, 5) + "-" + txtCepPreenchido.Substring(5, 3);
                    Deletar.ExcluiDados(txtCepPreenchido);
                    MessageBox.Show($"CEP {txtCepPreenchido} Excluido Com Sucesso. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro inesperado {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("CEP Inválido ou Vazio, Pesquise um CEP Valido e após Clique em 'BUSCAR CEP' . ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dejesa Realizar Uma Nova Consulta?", "Limpando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtcepbd.Text = "";
                txtLogradouroexc.Text = "";

            }
        }
    }
}
