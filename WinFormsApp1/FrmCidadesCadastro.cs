using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplicationMVCAPI1.Models;

namespace WinFormsApp1
{
    public partial class FrmCidadesCadastro : Form
    {

        public FrmCidadesCadastro()
        {
            InitializeComponent();
        }

        public string opcaoProc = "";
        private bool registroValido = true;

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            erro.SetError(txtCodigo, string.Empty);

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) == true)
            {
                erro.SetError(txtCodigo, "Informe o código da cidade");
                registroValido = false;
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            erro.SetError(txtDescricao, string.Empty);

            if (string.IsNullOrWhiteSpace(txtDescricao.Text) == true)
            {
                erro.SetError(txtDescricao, "Informe o nome da cidade");
                registroValido = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCidadesCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private StringContent retornaContent()
        {
            Cidade cidade = new Cidade();
            cidade.cidadeCodigo = short.Parse(txtCodigo.Text);
            cidade.cidadeDescricao = txtDescricao.Text;
            var arquivoJson = JsonSerializer.Serialize(cidade);
            return new StringContent(arquivoJson, encoding: Encoding.UTF8, "application/json");
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                registroValido = true;
                if (this.ValidateChildren() && registroValido)
                {
                    HttpClient client = new HttpClient();

                    var content = retornaContent();

                    HttpResponseMessage response = new HttpResponseMessage();

                    if (opcaoProc == "I")
                    {
                        response =
                        await client.PostAsync("https://localhost:44333/cidade", content);
                    }

                    if (opcaoProc == "U")
                    {
                        response = await client.PutAsync("https://localhost:44333/cidade", content);
                    }

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Registro salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCodigo.Enabled = true;
                        txtCodigo.Focus();
                        txtCodigo.Clear();
                        txtDescricao.Clear();

                        if (opcaoProc == "U")
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro no cadastro de cidades \n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
