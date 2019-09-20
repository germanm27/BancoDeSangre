namespace BancoDeSangre
{
    partial class DonantesSanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonantesSanos));
            this.listadeDonantesDataGridView = new System.Windows.Forms.DataGridView();
            this.listaDeGenerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeSangreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeDonantesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaDonantesSanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeDonantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listadeDonantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listadeDonantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.generoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangreIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.generoIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeGenerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeSangreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDonantesSanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesBindingNavigator)).BeginInit();
            this.listadeDonantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listadeDonantesDataGridView
            // 
            this.listadeDonantesDataGridView.AutoGenerateColumns = false;
            this.listadeDonantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeDonantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.sangreIdDataGridViewTextBoxColumn,
            this.generoIdDataGridViewTextBoxColumn});
            this.listadeDonantesDataGridView.DataSource = this.listadeDonantesBindingSource;
            this.listadeDonantesDataGridView.Location = new System.Drawing.Point(54, 58);
            this.listadeDonantesDataGridView.Name = "listadeDonantesDataGridView";
            this.listadeDonantesDataGridView.RowTemplate.Height = 24;
            this.listadeDonantesDataGridView.Size = new System.Drawing.Size(666, 264);
            this.listadeDonantesDataGridView.TabIndex = 1;
            // 
            // listaDeGenerosBindingSource
            // 
            this.listaDeGenerosBindingSource.DataSource = typeof(BancoDeSangre.Modelos.Genero);
            // 
            // listadeSangreBindingSource
            // 
            this.listadeSangreBindingSource.DataSource = typeof(BancoDeSangre.Modelos.TipodeSangre);
            // 
            // listadeDonantesDataGridView1
            // 
            this.listadeDonantesDataGridView1.AutoGenerateColumns = false;
            this.listadeDonantesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeDonantesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.edadDataGridViewTextBoxColumn1,
            this.cedulaDataGridViewTextBoxColumn1,
            this.sangreIdDataGridViewTextBoxColumn1,
            this.generoIdDataGridViewTextBoxColumn1});
            this.listadeDonantesDataGridView1.DataSource = this.listaDonantesSanosBindingSource;
            this.listadeDonantesDataGridView1.Location = new System.Drawing.Point(54, 378);
            this.listadeDonantesDataGridView1.Name = "listadeDonantesDataGridView1";
            this.listadeDonantesDataGridView1.RowTemplate.Height = 24;
            this.listadeDonantesDataGridView1.Size = new System.Drawing.Size(666, 265);
            this.listadeDonantesDataGridView1.TabIndex = 2;
            // 
            // listaDonantesSanosBindingSource
            // 
            this.listaDonantesSanosBindingSource.DataSource = typeof(BancoDeSangre.Modelos.Donantes);
            // 
            // listadeDonantesBindingNavigator
            // 
            this.listadeDonantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listadeDonantesBindingNavigator.BindingSource = this.listadeDonantesBindingSource;
            this.listadeDonantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeDonantesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listadeDonantesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listadeDonantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listadeDonantesBindingNavigatorSaveItem});
            this.listadeDonantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeDonantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeDonantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeDonantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeDonantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeDonantesBindingNavigator.Name = "listadeDonantesBindingNavigator";
            this.listadeDonantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeDonantesBindingNavigator.Size = new System.Drawing.Size(1008, 27);
            this.listadeDonantesBindingNavigator.TabIndex = 3;
            this.listadeDonantesBindingNavigator.Text = "bindingNavigator1";
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
            // listadeDonantesBindingSource
            // 
            this.listadeDonantesBindingSource.DataSource = typeof(BancoDeSangre.Modelos.Donantes);
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
            // listadeDonantesBindingNavigatorSaveItem
            // 
            this.listadeDonantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeDonantesBindingNavigatorSaveItem.Enabled = false;
            this.listadeDonantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeDonantesBindingNavigatorSaveItem.Image")));
            this.listadeDonantesBindingNavigatorSaveItem.Name = "listadeDonantesBindingNavigatorSaveItem";
            this.listadeDonantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listadeDonantesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // sangreIdDataGridViewTextBoxColumn
            // 
            this.sangreIdDataGridViewTextBoxColumn.DataPropertyName = "SangreId";
            this.sangreIdDataGridViewTextBoxColumn.DataSource = this.listadeSangreBindingSource;
            this.sangreIdDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.sangreIdDataGridViewTextBoxColumn.HeaderText = "Tipo de Sangre";
            this.sangreIdDataGridViewTextBoxColumn.Name = "sangreIdDataGridViewTextBoxColumn";
            this.sangreIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sangreIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sangreIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // generoIdDataGridViewTextBoxColumn
            // 
            this.generoIdDataGridViewTextBoxColumn.DataPropertyName = "GeneroId";
            this.generoIdDataGridViewTextBoxColumn.DataSource = this.listadeDonantesBindingSource;
            this.generoIdDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.generoIdDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoIdDataGridViewTextBoxColumn.Name = "generoIdDataGridViewTextBoxColumn";
            this.generoIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.generoIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.generoIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // edadDataGridViewTextBoxColumn1
            // 
            this.edadDataGridViewTextBoxColumn1.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn1.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn1.Name = "edadDataGridViewTextBoxColumn1";
            // 
            // cedulaDataGridViewTextBoxColumn1
            // 
            this.cedulaDataGridViewTextBoxColumn1.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn1.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn1.Name = "cedulaDataGridViewTextBoxColumn1";
            // 
            // sangreIdDataGridViewTextBoxColumn1
            // 
            this.sangreIdDataGridViewTextBoxColumn1.DataPropertyName = "SangreId";
            this.sangreIdDataGridViewTextBoxColumn1.DataSource = this.listadeSangreBindingSource;
            this.sangreIdDataGridViewTextBoxColumn1.DisplayMember = "Descripcion";
            this.sangreIdDataGridViewTextBoxColumn1.HeaderText = "Tipo de Sangre";
            this.sangreIdDataGridViewTextBoxColumn1.Name = "sangreIdDataGridViewTextBoxColumn1";
            this.sangreIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sangreIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sangreIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            // 
            // generoIdDataGridViewTextBoxColumn1
            // 
            this.generoIdDataGridViewTextBoxColumn1.DataPropertyName = "GeneroId";
            this.generoIdDataGridViewTextBoxColumn1.DataSource = this.listaDeGenerosBindingSource;
            this.generoIdDataGridViewTextBoxColumn1.DisplayMember = "Descripcion";
            this.generoIdDataGridViewTextBoxColumn1.HeaderText = "Genero";
            this.generoIdDataGridViewTextBoxColumn1.Name = "generoIdDataGridViewTextBoxColumn1";
            this.generoIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.generoIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.generoIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Donantes Sanos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 79);
            this.button2.TabIndex = 5;
            this.button2.Text = "<---Eliminar Donante No Sano";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(805, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 79);
            this.button3.TabIndex = 6;
            this.button3.Text = "<---Eliminar Donante Sano";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DonantesSanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 725);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listadeDonantesBindingNavigator);
            this.Controls.Add(this.listadeDonantesDataGridView1);
            this.Controls.Add(this.listadeDonantesDataGridView);
            this.Name = "DonantesSanos";
            this.Text = "Donantes Sanos";
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeGenerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeSangreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDonantesSanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesBindingNavigator)).EndInit();
            this.listadeDonantesBindingNavigator.ResumeLayout(false);
            this.listadeDonantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeDonantesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listadeDonantesDataGridView;
        private System.Windows.Forms.BindingSource listadeSangreBindingSource;
        private System.Windows.Forms.BindingSource listaDeGenerosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sangreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn generoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listadeDonantesBindingSource;
        private System.Windows.Forms.DataGridView listadeDonantesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sangreIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn generoIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource listaDonantesSanosBindingSource;
        private System.Windows.Forms.BindingNavigator listadeDonantesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listadeDonantesBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}