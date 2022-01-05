namespace SistemaDeControleDeDespesas
{
    partial class frmContas
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
            System.Windows.Forms.Label iD_DESPESALabel;
            System.Windows.Forms.Label dESCRICAO_DESPESALabel;
            System.Windows.Forms.Label iD_CATEGORIALabel;
            System.Windows.Forms.Label vALORLabel;
            System.Windows.Forms.Label dATALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.despesas2DataSet = new SistemaDeControleDeDespesas.Despesas2DataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.ContasTableAdapter();
            this.tableAdapterManager = new SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.TableAdapterManager();
            this.contasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_DESPESATextBox = new System.Windows.Forms.TextBox();
            this.dESCRICAO_DESPESATextBox = new System.Windows.Forms.TextBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_CATEGORIAComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasTableAdapter = new SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.CategoriasTableAdapter();
            iD_DESPESALabel = new System.Windows.Forms.Label();
            dESCRICAO_DESPESALabel = new System.Windows.Forms.Label();
            iD_CATEGORIALabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesas2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).BeginInit();
            this.contasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_DESPESALabel
            // 
            iD_DESPESALabel.AutoSize = true;
            iD_DESPESALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_DESPESALabel.Location = new System.Drawing.Point(31, 44);
            iD_DESPESALabel.Name = "iD_DESPESALabel";
            iD_DESPESALabel.Size = new System.Drawing.Size(69, 21);
            iD_DESPESALabel.TabIndex = 1;
            iD_DESPESALabel.Text = "Código:";
            // 
            // dESCRICAO_DESPESALabel
            // 
            dESCRICAO_DESPESALabel.AutoSize = true;
            dESCRICAO_DESPESALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESCRICAO_DESPESALabel.Location = new System.Drawing.Point(12, 122);
            dESCRICAO_DESPESALabel.Name = "dESCRICAO_DESPESALabel";
            dESCRICAO_DESPESALabel.Size = new System.Drawing.Size(88, 21);
            dESCRICAO_DESPESALabel.TabIndex = 3;
            dESCRICAO_DESPESALabel.Text = "Descrição:";
            // 
            // iD_CATEGORIALabel
            // 
            iD_CATEGORIALabel.AutoSize = true;
            iD_CATEGORIALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CATEGORIALabel.Location = new System.Drawing.Point(12, 81);
            iD_CATEGORIALabel.Name = "iD_CATEGORIALabel";
            iD_CATEGORIALabel.Size = new System.Drawing.Size(88, 21);
            iD_CATEGORIALabel.TabIndex = 5;
            iD_CATEGORIALabel.Text = "Categoria:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vALORLabel.Location = new System.Drawing.Point(45, 187);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(55, 21);
            vALORLabel.TabIndex = 7;
            vALORLabel.Text = "Valor:";
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATALabel.Location = new System.Drawing.Point(265, 187);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(50, 21);
            dATALabel.TabIndex = 9;
            dATALabel.Text = "Data:";
            // 
            // despesas2DataSet
            // 
            this.despesas2DataSet.DataSetName = "Despesas2DataSet";
            this.despesas2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this.despesas2DataSet;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaDeControleDeDespesas.Despesas2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contasBindingNavigator
            // 
            this.contasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contasBindingNavigator.BindingSource = this.contasBindingSource;
            this.contasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contasBindingNavigatorSaveItem});
            this.contasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contasBindingNavigator.Name = "contasBindingNavigator";
            this.contasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contasBindingNavigator.Size = new System.Drawing.Size(467, 25);
            this.contasBindingNavigator.TabIndex = 0;
            this.contasBindingNavigator.Text = "bindingNavigator1";
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
            // contasBindingNavigatorSaveItem
            // 
            this.contasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contasBindingNavigatorSaveItem.Image")));
            this.contasBindingNavigatorSaveItem.Name = "contasBindingNavigatorSaveItem";
            this.contasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contasBindingNavigatorSaveItem.Text = "Save Data";
            this.contasBindingNavigatorSaveItem.Click += new System.EventHandler(this.contasBindingNavigatorSaveItem_Click);
            // 
            // iD_DESPESATextBox
            // 
            this.iD_DESPESATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "ID_DESPESA", true));
            this.iD_DESPESATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_DESPESATextBox.Location = new System.Drawing.Point(106, 41);
            this.iD_DESPESATextBox.Name = "iD_DESPESATextBox";
            this.iD_DESPESATextBox.ReadOnly = true;
            this.iD_DESPESATextBox.Size = new System.Drawing.Size(84, 29);
            this.iD_DESPESATextBox.TabIndex = 2;
            // 
            // dESCRICAO_DESPESATextBox
            // 
            this.dESCRICAO_DESPESATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "DESCRICAO_DESPESA", true));
            this.dESCRICAO_DESPESATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRICAO_DESPESATextBox.Location = new System.Drawing.Point(106, 119);
            this.dESCRICAO_DESPESATextBox.Multiline = true;
            this.dESCRICAO_DESPESATextBox.Name = "dESCRICAO_DESPESATextBox";
            this.dESCRICAO_DESPESATextBox.Size = new System.Drawing.Size(346, 52);
            this.dESCRICAO_DESPESATextBox.TabIndex = 0;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "VALOR", true));
            this.vALORTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vALORTextBox.Location = new System.Drawing.Point(106, 181);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(131, 29);
            this.vALORTextBox.TabIndex = 2;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "DATA", true));
            this.dATADateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(321, 181);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(131, 29);
            this.dATADateTimePicker.TabIndex = 3;
            // 
            // iD_CATEGORIAComboBox
            // 
            this.iD_CATEGORIAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasBindingSource, "ID_CATEGORIA", true));
            this.iD_CATEGORIAComboBox.DataSource = this.categoriasBindingSource;
            this.iD_CATEGORIAComboBox.DisplayMember = "NOME_CATEGORIA";
            this.iD_CATEGORIAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_CATEGORIAComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CATEGORIAComboBox.FormattingEnabled = true;
            this.iD_CATEGORIAComboBox.Location = new System.Drawing.Point(106, 78);
            this.iD_CATEGORIAComboBox.Name = "iD_CATEGORIAComboBox";
            this.iD_CATEGORIAComboBox.Size = new System.Drawing.Size(346, 29);
            this.iD_CATEGORIAComboBox.TabIndex = 1;
            this.iD_CATEGORIAComboBox.ValueMember = "ID_CATEGORIA";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.despesas2DataSet;
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.AllowUserToAddRows = false;
            this.dtgPesquisa.AllowUserToDeleteRows = false;
            this.dtgPesquisa.AutoGenerateColumns = false;
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgPesquisa.DataSource = this.contasBindingSource;
            this.dtgPesquisa.Location = new System.Drawing.Point(16, 233);
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.ReadOnly = true;
            this.dtgPesquisa.RowHeadersVisible = false;
            this.dtgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisa.Size = new System.Drawing.Size(436, 233);
            this.dtgPesquisa.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_DESPESA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_DESPESA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRICAO_DESPESA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 247;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_CATEGORIA";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_CATEGORIA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 93;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATA";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 478);
            this.Controls.Add(this.dtgPesquisa);
            this.Controls.Add(this.iD_CATEGORIAComboBox);
            this.Controls.Add(iD_DESPESALabel);
            this.Controls.Add(this.iD_DESPESATextBox);
            this.Controls.Add(dESCRICAO_DESPESALabel);
            this.Controls.Add(this.dESCRICAO_DESPESATextBox);
            this.Controls.Add(iD_CATEGORIALabel);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dATADateTimePicker);
            this.Controls.Add(this.contasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCD - Contas";
            this.Load += new System.EventHandler(this.frmContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesas2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).EndInit();
            this.contasBindingNavigator.ResumeLayout(false);
            this.contasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Despesas2DataSet despesas2DataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private Despesas2DataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private Despesas2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_DESPESATextBox;
        private System.Windows.Forms.TextBox dESCRICAO_DESPESATextBox;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.ComboBox iD_CATEGORIAComboBox;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private Despesas2DataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}