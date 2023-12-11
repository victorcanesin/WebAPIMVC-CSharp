
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using WebApplicationMVCAPI1.Models;
using System.Security.Permissions;
using System.Net;
using System.Reflection.Metadata;

namespace WinFormsApp1
{
    public partial class FrmCidades : UserControl
    {
        public FrmCidades()
        {
            InitializeComponent();
            dgvDados.AutoGenerateColumns = false;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44333");
                var response = await client.GetAsync("cidade");

                var body = await response.Content.ReadAsStringAsync();

                // Converta a string em um objeto JSON
                var cidades = JsonSerializer.Deserialize<List<Cidade>>(body);

                dgvDados.Rows.Clear();

                foreach (Cidade cidade in cidades)
                {
                    dgvDados.Rows.Add(cidade.cidadeCodigo, cidade.cidadeDescricao);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao consultar as cidades \n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCidades>().Count() == 0)
            {
                FrmCidadesCadastro cadastro = new FrmCidadesCadastro() { opcaoProc = "I" };
                cadastro.Show();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvDados.RowCount == 0 || dgvDados.CurrentRow == null)
            {
                MessageBox.Show($"Não possui registro para alterar selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmCidadesCadastro cadastro = new FrmCidadesCadastro() { opcaoProc = "U" };
                cadastro.txtCodigo.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
                cadastro.txtDescricao.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
                cadastro.txtCodigo.Enabled = false;
                cadastro.Show();
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.RowCount == 0 || dgvDados.CurrentRow == null)
                {
                    MessageBox.Show($"Não possui registro para excluir selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HttpClient client = new HttpClient();
                    HttpResponseMessage response =  await client.DeleteAsync($"https://localhost:44333/cidade/{dgvDados.CurrentRow.Cells[0].Value}");

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Cidade excluida com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao excluir\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}