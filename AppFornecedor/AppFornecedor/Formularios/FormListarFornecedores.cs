using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFornecedor.Contexto;

namespace AppFornecedor.Formularios
{
    public partial class FormListarFornecedores: Form
    {
        public FormListarFornecedores()
        {
            InitializeComponent();
            dtTabela.DataSource = Context.ListaFornecedor;
        }
    }
}
