namespace BancoDeSangre
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeSangreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donantesSanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciaDeSangreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentaDeSangreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.transaccionToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donantesToolStripMenuItem,
            this.tiposDeSangreToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // donantesToolStripMenuItem
            // 
            this.donantesToolStripMenuItem.Name = "donantesToolStripMenuItem";
            this.donantesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.donantesToolStripMenuItem.Text = "Donantes";
            this.donantesToolStripMenuItem.Click += new System.EventHandler(this.donantesToolStripMenuItem_Click);
            // 
            // tiposDeSangreToolStripMenuItem
            // 
            this.tiposDeSangreToolStripMenuItem.Name = "tiposDeSangreToolStripMenuItem";
            this.tiposDeSangreToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.tiposDeSangreToolStripMenuItem.Text = "Tipos de Sangre";
            this.tiposDeSangreToolStripMenuItem.Click += new System.EventHandler(this.tiposDeSangreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // transaccionToolStripMenuItem
            // 
            this.transaccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprobanteToolStripMenuItem,
            this.donantesSanosToolStripMenuItem});
            this.transaccionToolStripMenuItem.Name = "transaccionToolStripMenuItem";
            this.transaccionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transaccionToolStripMenuItem.Text = "Transaccion";
            // 
            // comprobanteToolStripMenuItem
            // 
            this.comprobanteToolStripMenuItem.Name = "comprobanteToolStripMenuItem";
            this.comprobanteToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.comprobanteToolStripMenuItem.Text = "Comprobante";
            this.comprobanteToolStripMenuItem.Click += new System.EventHandler(this.comprobanteToolStripMenuItem_Click);
            // 
            // donantesSanosToolStripMenuItem
            // 
            this.donantesSanosToolStripMenuItem.Name = "donantesSanosToolStripMenuItem";
            this.donantesSanosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.donantesSanosToolStripMenuItem.Text = "Donantes Sanos";
            this.donantesSanosToolStripMenuItem.Click += new System.EventHandler(this.donantesSanosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existenciaDeSangreToolStripMenuItem,
            this.reporteDeVentaDeSangreToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // existenciaDeSangreToolStripMenuItem
            // 
            this.existenciaDeSangreToolStripMenuItem.Name = "existenciaDeSangreToolStripMenuItem";
            this.existenciaDeSangreToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.existenciaDeSangreToolStripMenuItem.Text = "Existencia de Sangre";
            this.existenciaDeSangreToolStripMenuItem.Click += new System.EventHandler(this.existenciaDeSangreToolStripMenuItem_Click);
            // 
            // reporteDeVentaDeSangreToolStripMenuItem
            // 
            this.reporteDeVentaDeSangreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalesToolStripMenuItem});
            this.reporteDeVentaDeSangreToolStripMenuItem.Name = "reporteDeVentaDeSangreToolStripMenuItem";
            this.reporteDeVentaDeSangreToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.reporteDeVentaDeSangreToolStripMenuItem.Text = "Reporte de Venta de Sangre";
            // 
            // totalesToolStripMenuItem
            // 
            this.totalesToolStripMenuItem.Name = "totalesToolStripMenuItem";
            this.totalesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.totalesToolStripMenuItem.Text = "Totales";
            this.totalesToolStripMenuItem.Click += new System.EventHandler(this.totalesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 591);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeSangreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciaDeSangreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donantesSanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentaDeSangreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalesToolStripMenuItem;
    }
}