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
    public partial class frmContas : Form
    {
        public frmContas()
        {
            InitializeComponent();
        }

        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.despesas2DataSet);

        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'despesas2DataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.despesas2DataSet.Categorias);
            // TODO: This line of code loads data into the 'despesas2DataSet.Contas' table. You can move, or remove it, as needed.
            this.contasTableAdapter.Fill(this.despesas2DataSet.Contas);

        }
    }
}
