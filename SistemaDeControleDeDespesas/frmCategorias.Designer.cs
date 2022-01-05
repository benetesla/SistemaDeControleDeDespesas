namespace SistemaDeControleDeDespesas
{
    partial class frmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_CATEGORIALabel;
            System.Windows.Forms.Label nOME_CATEGORIALabel;
            System.Windows.Forms.Label dESCRICAO_CATEGORIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.despesas2DataSet = new SistemaDeControleDeDespesas.Despesas2DataSet();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.CategoriasTableAdapter();
            this.tableAdapterManager = new SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.TableAdapterManager();
            this.categoriasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CATEGORIATextBox = new System.Windows.Forms.TextBox();
            this.nOME_CATEGORIATextBox = new System.Windows.Forms.TextBox();
            this.dESCRICAO_CATEGORIATextBox = new System.Windows.Forms.TextBox();
            this.categoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CATEGORIALabel = new System.Windows.Forms.Label();
            nOME_CATEGORIALabel = new System.Windows.Forms.Label();
            dESCRICAO_CATEGORIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesas2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingNavigator)).BeginInit();
            this.categoriasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CATEGORIALabel
            // 
            iD_CATEGORIALabel.AutoSize = true;
            iD_CATEGORIALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CATEGORIALabel.Location = new System.Drawing.Point(8, 47);
            iD_CATEGORIALabel.Name = "iD_CATEGORIALabel";
            iD_CATEGORIALabel.Size = new System.Drawing.Size(69, 21);
            iD_CATEGORIALabel.TabIndex = 1;
            iD_CATEGORIALabel.Text = "Código:";
            // 
            // nOME_CATEGORIALabel
            // 
            nOME_CATEGORIALabel.AutoSize = true;
            nOME_CATEGORIALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_CATEGORIALabel.Location = new System.Drawing.Point(8, 82);
            nOME_CATEGORIALabel.Name = "nOME_CATEGORIALabel";
            nOME_CATEGORIALabel.Size = new System.Drawing.Size(88, 21);
            nOME_CATEGORIALabel.TabIndex = 3;
            nOME_CATEGORIALabel.Text = "Categoria:";
            // 
            // dESCRICAO_CATEGORIALabel
            // 
            dESCRICAO_CATEGORIALabel.AutoSize = true;
            dESCRICAO_CATEGORIALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESCRICAO_CATEGORIALabel.Location = new System.Drawing.Point(8, 117);
            dESCRICAO_CATEGORIALabel.Name = "dESCRICAO_CATEGORIALabel";
            dESCRICAO_CATEGORIALabel.Size = new System.Drawing.Size(88, 21);
            dESCRICAO_CATEGORIALabel.TabIndex = 5;
            dESCRICAO_CATEGORIALabel.Text = "Descrição:";
            // 
            // despesas2DataSet
            // 
            this.despesas2DataSet.DataSetName = "Despesas2DataSet";
            this.despesas2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.despesas2DataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasBindingNavigator
            // 
            this.categoriasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriasBindingNavigator.BindingSource = this.categoriasBindingSource;
            this.categoriasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriasBindingNavigatorSaveItem});
            this.categoriasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriasBindingNavigator.Name = "categoriasBindingNavigator";
            this.categoriasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriasBindingNavigator.Size = new System.Drawing.Size(467, 25);
            this.categoriasBindingNavigator.TabIndex = 0;
            this.categoriasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // categoriasBindingNavigatorSaveItem
            // 
            this.categoriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasBindingNavigatorSaveItem.Image")));
            this.categoriasBindingNavigatorSaveItem.Name = "categoriasBindingNavigatorSaveItem";
            this.categoriasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriasBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriasBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriasBindingNavigatorSaveItem_Click);
            // 
            // iD_CATEGORIATextBox
            // 
            this.iD_CATEGORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "ID_CATEGORIA", true));
            this.iD_CATEGORIATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CATEGORIATextBox.Location = new System.Drawing.Point(101, 44);
            this.iD_CATEGORIATextBox.Name = "iD_CATEGORIATextBox";
            this.iD_CATEGORIATextBox.ReadOnly = true;
            this.iD_CATEGORIATextBox.Size = new System.Drawing.Size(100, 29);
            this.iD_CATEGORIATextBox.TabIndex = 2;
            this.iD_CATEGORIATextBox.TabStop = false;
            // 
            // nOME_CATEGORIATextBox
            // 
            this.nOME_CATEGORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "NOME_CATEGORIA", true));
            this.nOME_CATEGORIATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_CATEGORIATextBox.Location = new System.Drawing.Point(101, 79);
            this.nOME_CATEGORIATextBox.Name = "nOME_CATEGORIATextBox";
            this.nOME_CATEGORIATextBox.Size = new System.Drawing.Size(354, 29);
            this.nOME_CATEGORIATextBox.TabIndex = 0;
            // 
            // dESCRICAO_CATEGORIATextBox
            // 
            this.dESCRICAO_CATEGORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "DESCRICAO_CATEGORIA", true));
            this.dESCRICAO_CATEGORIATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRICAO_CATEGORIATextBox.Location = new System.Drawing.Point(101, 114);
            this.dESCRICAO_CATEGORIATextBox.Multiline = true;
            this.dESCRICAO_CATEGORIATextBox.Name = "dESCRICAO_CATEGORIATextBox";
            this.dESCRICAO_CATEGORIATextBox.Size = new System.Drawing.Size(354, 62);
            this.dESCRICAO_CATEGORIATextBox.TabIndex = 1;
            // 
            // categoriasDataGridView
            // 
            this.categoriasDataGridView.AllowUserToAddRows = false;
            this.categoriasDataGridView.AllowUserToDeleteRows = false;
            this.categoriasDataGridView.AllowUserToResizeColumns = false;
            this.categoriasDataGridView.AllowUserToResizeRows = false;
            this.categoriasDataGridView.AutoGenerateColumns = false;
            this.categoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.categoriasDataGridView.DataSource = this.categoriasBindingSource;
            this.categoriasDataGridView.Location = new System.Drawing.Point(12, 194);
            this.categoriasDataGridView.Name = "categoriasDataGridView";
            this.categoriasDataGridView.ReadOnly = true;
            this.categoriasDataGridView.RowHeadersVisible = false;
            this.categoriasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriasDataGridView.Size = new System.Drawing.Size(443, 271);
            this.categoriasDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CATEGORIA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CATEGORIA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CATEGORIA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESCRICAO_CATEGORIA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 248;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 478);
            this.Controls.Add(this.categoriasDataGridView);
            this.Controls.Add(iD_CATEGORIALabel);
            this.Controls.Add(this.iD_CATEGORIATextBox);
            this.Controls.Add(nOME_CATEGORIALabel);
            this.Controls.Add(this.nOME_CATEGORIATextBox);
            this.Controls.Add(dESCRICAO_CATEGORIALabel);
            this.Controls.Add(this.dESCRICAO_CATEGORIATextBox);
            this.Controls.Add(this.categoriasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCD - Categorias das Contas";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesas2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingNavigator)).EndInit();
            this.categoriasBindingNavigator.ResumeLayout(false);
            this.categoriasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Despesas2DataSet despesas2DataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private Despesas2DataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private Despesas2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CATEGORIATextBox;
        private System.Windows.Forms.TextBox nOME_CATEGORIATextBox;
        private System.Windows.Forms.TextBox dESCRICAO_CATEGORIATextBox;
        private System.Windows.Forms.DataGridView categoriasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}