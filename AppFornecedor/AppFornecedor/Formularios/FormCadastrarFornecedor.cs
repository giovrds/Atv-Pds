using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFornecedor.Models;
using AppFornecedor.Contexto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace AppFornecedor.Formularios
{
    public partial class FormCadastrarFornecedor : Form
    {
        //usar combobox pros estados e tal -> feito
        //verificar se os campos estão vazios -> feito
        //verificar cnpj --> feito

        public static int idFornecedor = 1;

        public FormCadastrarFornecedor()
        {
            InitializeComponent();
            EscolherEstados();
            cbEstado.SelectedIndex = -1;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCidade.Text) || string.IsNullOrWhiteSpace(txtCNPJ.Text) || string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtNomeFantasia.Text) || string.IsNullOrWhiteSpace(txtRazaoSoc.Text) ||
                string.IsNullOrWhiteSpace(txtResponsavel.Text) || string.IsNullOrWhiteSpace(txtTelefone.Text) || cbEstado.SelectedItem == null)
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "GIOVANNA RODRIGUES - 3º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!VerificarCNPJ(txtCNPJ.Text))
            {
                MessageBox.Show("CNPJ INVÁLIDO", "GIOVANNA RODRIGUES - 3º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Cidade = txtCidade.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.Estado = cbEstado.Text;
            fornecedor.nomeFantasia = txtNomeFantasia.Text;
            fornecedor.Responsavel = txtResponsavel.Text;
            fornecedor.razaoSocial = txtRazaoSoc.Text;
            fornecedor.Telefone = txtTelefone.Text;

            idFornecedor++;
            Context.ListaFornecedor.Add(fornecedor);

            MessageBox.Show("CADASTRADO COM SUCESSO", "GIOVANNA RODRIGUES - 3º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCidade.Clear(); txtCNPJ.Clear(); txtEmail.Clear(); txtEndereco.Clear();
            txtNomeFantasia.Clear(); txtRazaoSoc.Clear(); txtResponsavel.Clear(); txtTelefone.Clear(); cbEstado.SelectedIndex = -1;
        }

        private bool VerificarCNPJ(string cnpj)
        {
            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
                return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            tempCnpj += digito1;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cnpj[12] == digito1.ToString()[0] && cnpj[13] == digito2.ToString()[0];
        }

        private void EscolherEstados()
        {
            string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT",
                "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

            cbEstado.DataSource = estados;
        }
    }
}
