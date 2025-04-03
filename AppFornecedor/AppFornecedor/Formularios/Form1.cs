using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFornecedor.Formularios;

namespace AppFornecedor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            FormCadastrarFornecedor form = new FormCadastrarFornecedor();
            form.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListarFornecedores form = new FormListarFornecedores();
            form.ShowDialog();
        }
    }
}
