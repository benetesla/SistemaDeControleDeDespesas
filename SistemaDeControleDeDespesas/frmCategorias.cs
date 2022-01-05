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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.despesas2DataSet);

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'despesas2DataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.despesas2DataSet.Categorias);

        }
    }
}
