namespace BancoDeSangre
{
    partial class Donantes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label enfermedadLabel;
            System.Windows.Forms.Label mensajeLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label descripcionLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donantes));
            this.listaDeDonantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaDeDonantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listaDeDonantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tiposDeSangreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoSangreBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.enfermedadCheckBox = new System.Windows.Forms.CheckBox();
            this.mensajeTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaDeDonantesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposDeSangreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cedulaLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            enfermedadLabel = new System.Windows.Forms.Label();
            mensajeLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDonantesBindingNavigator)).BeginInit();
            this.listaDeDonantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDonantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeSangreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoSangreBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDonantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeSangreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(73, 91);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(56, 17);
            cedulaLabel.TabIndex = 2;
            cedulaLabel.Text = "Cedula:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(73, 119);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(45, 17);
            edadLabel.TabIndex = 4;
            edadLabel.Text = "Edad:";
            // 
            // enfermedadLabel
            // 
            enfermedadLabel.AutoSize = true;
            enfermedadLabel.Location = new System.Drawing.Point(73, 149);
            enfermedadLabel.Name = "enfermedadLabel";
            enfermedadLabel.Size = new System.Drawing.Size(89, 17);
            enfermedadLabel.TabIndex = 6;
            enfermedadLabel.Text = "Enfermedad:";
            // 
            // mensajeLabel
            // 
            mensajeLabel.AutoSize = true;
            mensajeLabel.Location = new System.Drawing.Point(73, 177);
            mensajeLabel.Name = "mensajeLabel";
            mensajeLabel.Size = new System.Drawing.Size(65, 17);
            mensajeLabel.TabIndex = 10;
            mensajeLabel.Text = "Mensaje:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(70, 62);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(309, 91);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(60, 17);
            descripcionLabel.TabIndex = 16;
            descripcionLabel.Text = "Genero:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Location = new System.Drawing.Point(309, 60);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(110, 17);
            descripcionLabel1.TabIndex = 20;
            descripcionLabel1.Text = "Tipo de Sangre:";
            // 
            // listaDeDonantesBindingNavigator
            // 
            this.listaDeDonantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaDeDonantesBindingNavigator.BindingSource = this.listaDeDonantesBindingSource;
            this.listaDeDonantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaDeDonantesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaDeDonantesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaDeDonantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaDeDonantesBindingNavigatorSaveItem});
            this.listaDeDonantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaDeDonantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaDeDonantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaDeDonantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaDeDonantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaDeDonantesBindingNavigator.Name = "listaDeDonantesBindingNavigator";
            this.listaDeDonantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaDeDonantesBindingNavigator.Size = new System.Drawing.Size(1243, 27);
            this.listaDeDonantesBindingNavigator.TabIndex = 0;
            this.listaDeDonantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // listaDeDonantesBindingSource
            // 
            this.listaDeDonantesBindingSource.DataSource = typeof(BancoDeSangre.Modelos.Donante);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listaDeDonantesBindingNavigatorSaveItem
            // 
            this.listaDeDonantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaDeDonantesBindingNavigatorSaveItem.Enabled = false;
            this.listaDeDonantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeDonantesBindingNavigatorSaveItem.Image")));
            this.listaDeDonantesBindingNavigatorSaveItem.Name = "listaDeDonantesBindingNavigatorSaveItem";
            this.listaDeDonantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaDeDonantesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // tiposDeSangreBindingSource
            // 
            this.tiposDeSangreBindingSource.DataMember = "TiposDeSangre";
            this.tiposDeSangreBindingSource.DataSource = this.tipoSangreBLBindingSource;
            // 
            // tipoSangreBLBindingSource
            // 
            this.tipoSangreBLBindingSource.DataSource = typeof(BancoDeSangre.BL.TipoSangreBL);
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeDonantesBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(168, 88);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(104, 22);
            this.cedulaTextBox.TabIndex = 3;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeDonantesBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(168, 116);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(104, 22);
            this.edadTextBox.TabIndex = 5;
            // 
            // enfermedadCheckBox
            // 
            this.enfermedadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaDeDonantesBindingSource, "Enfermedad", true));
            this.enfermedadCheckBox.Location = new System.Drawing.Point(168, 144);
            this.enfermedadCheckBox.Name = "enfermedadCheckBox";
            this.enfermedadCheckBox.Size = new System.Drawing.Size(104, 24);
            this.enfermedadCheckBox.TabIndex = 7;
            this.enfermedadCheckBox.Text = "checkBox1";
            this.enfermedadCheckBox.UseVisualStyleBackColor = true;
            // 
            // mensajeTextBox
            // 
            this.mensajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeDonantesBindingSource, "Mensaje", true));
            this.mensajeTextBox.Location = new System.Drawing.Point(168, 174);
            this.mensajeTextBox.Name = "mensajeTextBox";
            this.mensajeTextBox.Size = new System.Drawing.Size(104, 22);
            this.mensajeTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeDonantesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(165, 59);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 22);
            this.nombreTextBox.TabIndex = 13;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeDonantesBindingSource, "Genero.Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(425, 91);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(122, 22);
            this.descripcionTextBox.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiposDeSangreBindingSource1;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(426, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "Descripcion";
            // 
            // listaDeDonantesDataGridView
            // 
            this.listaDeDonantesDataGridView.AutoGenerateColumns = false;
            this.listaDeDonantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDeDonantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.listaDeDonantesDataGridView.DataSource = this.listaDeDonantesBindingSource;
            this.listaDeDonantesDataGridView.Location = new System.Drawing.Point(43, 225);
            this.listaDeDonantesDataGridView.Name = "listaDeDonantesDataGridView";
            this.listaDeDonantesDataGridView.RowTemplate.Height = 24;
            this.listaDeDonantesDataGridView.Size = new System.Drawing.Size(823, 345);
            this.listaDeDonantesDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Enfermedad";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Enfermedad";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mensaje";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mensaje";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sangre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sangre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn8.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tiposDeSangreBindingSource1
            // 
            this.tiposDeSangreBindingSource1.DataMember = "TiposDeSangre";
            this.tiposDeSangreBindingSource1.DataSource = this.tipoSangreBLBindingSource;
            // 
            // Donantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 673);
            this.Controls.Add(this.listaDeDonantesDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(descripcionLabel1);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(enfermedadLabel);
            this.Controls.Add(this.enfermedadCheckBox);
            this.Controls.Add(mensajeLabel);
            this.Controls.Add(this.mensajeTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaDeDonantesBindingNavigator);
            this.Name = "Donantes";
            this.Text = "Donante";
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDonantesBindingNavigator)).EndInit();
            this.listaDeDonantesBindingNavigator.ResumeLayout(false);
            this.listaDeDonantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDonantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeSangreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoSangreBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDonantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeSangreBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaDeDonantesBindingSource;
        private System.Windows.Forms.BindingNavigator listaDeDonantesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaDeDonantesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.CheckBox enfermedadCheckBox;
        private System.Windows.Forms.TextBox mensajeTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tipoSangreBLBindingSource;
        private System.Windows.Forms.BindingSource tiposDeSangreBindingSource;
        private System.Windows.Forms.DataGridView listaDeDonantesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource tiposDeSangreBindingSource1;
    }
}

