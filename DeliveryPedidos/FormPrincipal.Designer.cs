namespace DeliveryPedidos
{
    partial class FormPrincipal
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
            this.tituloPedidosLbl = new System.Windows.Forms.Label();
            this.pedidosPreparacionLbl = new System.Windows.Forms.Label();
            this.pedidosCompletadosLbl = new System.Windows.Forms.Label();
            this.dataGridPreparacion = new System.Windows.Forms.DataGridView();
            this.dataGridCompletados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompletados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloPedidosLbl
            // 
            this.tituloPedidosLbl.AutoSize = true;
            this.tituloPedidosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPedidosLbl.Location = new System.Drawing.Point(479, 38);
            this.tituloPedidosLbl.Name = "tituloPedidosLbl";
            this.tituloPedidosLbl.Size = new System.Drawing.Size(97, 25);
            this.tituloPedidosLbl.TabIndex = 4;
            this.tituloPedidosLbl.Text = "Pedidos";
            // 
            // pedidosPreparacionLbl
            // 
            this.pedidosPreparacionLbl.AutoSize = true;
            this.pedidosPreparacionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidosPreparacionLbl.Location = new System.Drawing.Point(191, 88);
            this.pedidosPreparacionLbl.Name = "pedidosPreparacionLbl";
            this.pedidosPreparacionLbl.Size = new System.Drawing.Size(131, 20);
            this.pedidosPreparacionLbl.TabIndex = 5;
            this.pedidosPreparacionLbl.Text = "En preparación";
            // 
            // pedidosCompletadosLbl
            // 
            this.pedidosCompletadosLbl.AutoSize = true;
            this.pedidosCompletadosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidosCompletadosLbl.Location = new System.Drawing.Point(717, 88);
            this.pedidosCompletadosLbl.Name = "pedidosCompletadosLbl";
            this.pedidosCompletadosLbl.Size = new System.Drawing.Size(114, 20);
            this.pedidosCompletadosLbl.TabIndex = 6;
            this.pedidosCompletadosLbl.Text = "Completados";
            // 
            // dataGridPreparacion
            // 
            this.dataGridPreparacion.AllowUserToAddRows = false;
            this.dataGridPreparacion.AllowUserToDeleteRows = false;
            this.dataGridPreparacion.AllowUserToResizeColumns = false;
            this.dataGridPreparacion.AllowUserToResizeRows = false;
            this.dataGridPreparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPreparacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPreparacion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridPreparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPreparacion.Enabled = false;
            this.dataGridPreparacion.Location = new System.Drawing.Point(12, 127);
            this.dataGridPreparacion.MultiSelect = false;
            this.dataGridPreparacion.Name = "dataGridPreparacion";
            this.dataGridPreparacion.ReadOnly = true;
            this.dataGridPreparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPreparacion.Size = new System.Drawing.Size(512, 295);
            this.dataGridPreparacion.TabIndex = 7;
            // 
            // dataGridCompletados
            // 
            this.dataGridCompletados.AllowUserToAddRows = false;
            this.dataGridCompletados.AllowUserToDeleteRows = false;
            this.dataGridCompletados.AllowUserToResizeColumns = false;
            this.dataGridCompletados.AllowUserToResizeRows = false;
            this.dataGridCompletados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCompletados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCompletados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCompletados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCompletados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompletados.Enabled = false;
            this.dataGridCompletados.Location = new System.Drawing.Point(530, 127);
            this.dataGridCompletados.MultiSelect = false;
            this.dataGridCompletados.Name = "dataGridCompletados";
            this.dataGridCompletados.ReadOnly = true;
            this.dataGridCompletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCompletados.Size = new System.Drawing.Size(499, 295);
            this.dataGridCompletados.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPedidoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 503);
            this.Controls.Add(this.dataGridCompletados);
            this.Controls.Add(this.dataGridPreparacion);
            this.Controls.Add(this.pedidosCompletadosLbl);
            this.Controls.Add(this.pedidosPreparacionLbl);
            this.Controls.Add(this.tituloPedidosLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Menú principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompletados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPedidosLbl;
        private System.Windows.Forms.Label pedidosPreparacionLbl;
        private System.Windows.Forms.Label pedidosCompletadosLbl;
        private System.Windows.Forms.DataGridView dataGridPreparacion;
        private System.Windows.Forms.DataGridView dataGridCompletados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

