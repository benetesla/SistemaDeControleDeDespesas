using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControleDeDespesas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
           
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //evento Click do btnCategorias onde o formulário frmCategorias é instanciado e exibido.
            frmCategorias novaCategoria = new frmCategorias();
            novaCategoria.ShowDialog();
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            //evento Click do btnContas onde o formulário frmContas é instanciado e exibido.
            frmContas novaConta = new frmContas();
            novaConta.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        { /* evento Load do frmPrincipal, que utiliza a query ListarDespesas criada no tableAdapter da tabela Contas
           * para buscar todos os registros da mesma e exibir no DataGridView */
            dtgPesquisa.DataSource = contasTableAdapter1.ListarDespesas();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /* evento do botão pesquisar, o qual verifica se o txtPesquisa está vazio, se estiver, irá listar todos os registros da tabela Contas.
             * Senão, verificará qual RadioButton está marcado e irá pesquisar de acordo com a data especificada nos DateTimePickers
             * e também com o que o usuário digitar no txtPesquisa, utilizando as respectivas queries criadas no tableAdapter da table Contas.
             * E o resultado será exibido no dataGridView.*/

            if (txtPesquisa.Text == "")
            {
                dtgPesquisa.DataSource = contasTableAdapter1.ListarDespesas();
            }
            else
            {
                if (rbValor.Checked == true)
                {
                    dtgPesquisa.DataSource = contasTableAdapter1.PesquisarValor(dtpDataInicial.Value, dtpDataFinal.Value, Convert.ToDecimal(txtPesquisa.Text));
                }
                else
                {
                    if (rbCategoria.Checked == true)
                    {
                        dtgPesquisa.DataSource = contasTableAdapter1.PesquisarCategoria(dtpDataInicial.Value, dtpDataFinal.Value, txtPesquisa.Text);
                    }
                }
            }
        }
    }
}
