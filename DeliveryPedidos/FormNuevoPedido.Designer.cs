namespace DeliveryPedidos
{
    partial class FormNuevoPedido
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
            this.tituloNuevoPedidoLbl = new System.Windows.Forms.Label();
            this.nombrePedidoLbl = new System.Windows.Forms.Label();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.precioLbl = new System.Windows.Forms.Label();
            this.precioTxtBox = new System.Windows.Forms.TextBox();
            this.deliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.datosEntregaLbl = new System.Windows.Forms.Label();
            this.clienteLbl = new System.Windows.Forms.Label();
            this.clienteTxtBox = new System.Windows.Forms.TextBox();
            this.localidadLbl = new System.Windows.Forms.Label();
            this.localidadTxtBox = new System.Windows.Forms.TextBox();
            this.direccionLbl = new System.Windows.Forms.Label();
            this.direccionTxtBox = new System.Windows.Forms.TextBox();
            this.numeroLbl = new System.Windows.Forms.Label();
            this.numeroTxtBox = new System.Windows.Forms.TextBox();
            this.pedidoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloNuevoPedidoLbl
            // 
            this.tituloNuevoPedidoLbl.AutoSize = true;
            this.tituloNuevoPedidoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloNuevoPedidoLbl.Location = new System.Drawing.Point(100, 18);
            this.tituloNuevoPedidoLbl.Name = "tituloNuevoPedidoLbl";
            this.tituloNuevoPedidoLbl.Size = new System.Drawing.Size(322, 25);
            this.tituloNuevoPedidoLbl.TabIndex = 5;
            this.tituloNuevoPedidoLbl.Text = "Información del nuevo pedido";
            // 
            // nombrePedidoLbl
            // 
            this.nombrePedidoLbl.AutoSize = true;
            this.nombrePedidoLbl.Location = new System.Drawing.Point(36, 76);
            this.nombrePedidoLbl.Name = "nombrePedidoLbl";
            this.nombrePedidoLbl.Size = new System.Drawing.Size(96, 13);
            this.nombrePedidoLbl.TabIndex = 6;
            this.nombrePedidoLbl.Text = "Nombre del pedido";
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.Location = new System.Drawing.Point(147, 73);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTxtBox.TabIndex = 7;
            this.nombreTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.nombreTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Location = new System.Drawing.Point(36, 117);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(37, 13);
            this.precioLbl.TabIndex = 8;
            this.precioLbl.Text = "Precio";
            // 
            // precioTxtBox
            // 
            this.precioTxtBox.Location = new System.Drawing.Point(147, 114);
            this.precioTxtBox.Name = "precioTxtBox";
            this.precioTxtBox.Size = new System.Drawing.Size(121, 20);
            this.precioTxtBox.TabIndex = 9;
            this.precioTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.precioTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // deliveryCheckBox
            // 
            this.deliveryCheckBox.AutoSize = true;
            this.deliveryCheckBox.Location = new System.Drawing.Point(302, 75);
            this.deliveryCheckBox.Name = "deliveryCheckBox";
            this.deliveryCheckBox.Size = new System.Drawing.Size(104, 17);
            this.deliveryCheckBox.TabIndex = 11;
            this.deliveryCheckBox.Text = "¿Tiene delivery?";
            this.deliveryCheckBox.UseVisualStyleBackColor = true;
            this.deliveryCheckBox.CheckedChanged += new System.EventHandler(this.deliveryCheckBox_CheckedChanged);
            // 
            // datosEntregaLbl
            // 
            this.datosEntregaLbl.AutoSize = true;
            this.datosEntregaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosEntregaLbl.Location = new System.Drawing.Point(100, 159);
            this.datosEntregaLbl.Name = "datosEntregaLbl";
            this.datosEntregaLbl.Size = new System.Drawing.Size(193, 25);
            this.datosEntregaLbl.TabIndex = 12;
            this.datosEntregaLbl.Text = "Datos de entrega";
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.Location = new System.Drawing.Point(36, 211);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(95, 13);
            this.clienteLbl.TabIndex = 13;
            this.clienteLbl.Text = "Nombre del cliente";
            // 
            // clienteTxtBox
            // 
            this.clienteTxtBox.Location = new System.Drawing.Point(147, 208);
            this.clienteTxtBox.Name = "clienteTxtBox";
            this.clienteTxtBox.Size = new System.Drawing.Size(121, 20);
            this.clienteTxtBox.TabIndex = 14;
            this.clienteTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.clienteTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // localidadLbl
            // 
            this.localidadLbl.AutoSize = true;
            this.localidadLbl.Location = new System.Drawing.Point(36, 250);
            this.localidadLbl.Name = "localidadLbl";
            this.localidadLbl.Size = new System.Drawing.Size(53, 13);
            this.localidadLbl.TabIndex = 15;
            this.localidadLbl.Text = "Localidad";
            // 
            // localidadTxtBox
            // 
            this.localidadTxtBox.Location = new System.Drawing.Point(147, 247);
            this.localidadTxtBox.Name = "localidadTxtBox";
            this.localidadTxtBox.Size = new System.Drawing.Size(121, 20);
            this.localidadTxtBox.TabIndex = 16;
            this.localidadTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.localidadTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.Location = new System.Drawing.Point(36, 289);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(83, 13);
            this.direccionLbl.TabIndex = 17;
            this.direccionLbl.Text = "Dirección (calle)";
            // 
            // direccionTxtBox
            // 
            this.direccionTxtBox.Location = new System.Drawing.Point(147, 286);
            this.direccionTxtBox.Name = "direccionTxtBox";
            this.direccionTxtBox.Size = new System.Drawing.Size(121, 20);
            this.direccionTxtBox.TabIndex = 18;
            this.direccionTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.direccionTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // numeroLbl
            // 
            this.numeroLbl.AutoSize = true;
            this.numeroLbl.Location = new System.Drawing.Point(36, 327);
            this.numeroLbl.Name = "numeroLbl";
            this.numeroLbl.Size = new System.Drawing.Size(102, 13);
            this.numeroLbl.TabIndex = 19;
            this.numeroLbl.Text = "Número de domicilio";
            // 
            // numeroTxtBox
            // 
            this.numeroTxtBox.Location = new System.Drawing.Point(147, 324);
            this.numeroTxtBox.Name = "numeroTxtBox";
            this.numeroTxtBox.Size = new System.Drawing.Size(121, 20);
            this.numeroTxtBox.TabIndex = 20;
            this.numeroTxtBox.TextChanged += new System.EventHandler(this.oyenteTextosCambiados);
            this.numeroTxtBox.Leave += new System.EventHandler(this.oyenteFocoSalidaTextos);
            // 
            // pedidoButton
            // 
            this.pedidoButton.Enabled = false;
            this.pedidoButton.Location = new System.Drawing.Point(39, 366);
            this.pedidoButton.Name = "pedidoButton";
            this.pedidoButton.Size = new System.Drawing.Size(254, 23);
            this.pedidoButton.TabIndex = 21;
            this.pedidoButton.Text = "Realizar pedido";
            this.pedidoButton.UseVisualStyleBackColor = true;
            this.pedidoButton.Click += new System.EventHandler(this.pedidoButton_Click);
            // 
            // FormNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 401);
            this.Controls.Add(this.pedidoButton);
            this.Controls.Add(this.numeroTxtBox);
            this.Controls.Add(this.numeroLbl);
            this.Controls.Add(this.direccionTxtBox);
            this.Controls.Add(this.direccionLbl);
            this.Controls.Add(this.localidadTxtBox);
            this.Controls.Add(this.localidadLbl);
            this.Controls.Add(this.clienteTxtBox);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.datosEntregaLbl);
            this.Controls.Add(this.deliveryCheckBox);
            this.Controls.Add(this.precioTxtBox);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.nombreTxtBox);
            this.Controls.Add(this.nombrePedidoLbl);
            this.Controls.Add(this.tituloNuevoPedidoLbl);
            this.Name = "FormNuevoPedido";
            this.Text = "Nuevo pedido";
            this.Load += new System.EventHandler(this.FormNuevoPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloNuevoPedidoLbl;
        private System.Windows.Forms.Label nombrePedidoLbl;
        private System.Windows.Forms.TextBox nombreTxtBox;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.TextBox precioTxtBox;
        private System.Windows.Forms.CheckBox deliveryCheckBox;
        private System.Windows.Forms.Label datosEntregaLbl;
        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.TextBox clienteTxtBox;
        private System.Windows.Forms.Label localidadLbl;
        private System.Windows.Forms.TextBox localidadTxtBox;
        private System.Windows.Forms.Label direccionLbl;
        private System.Windows.Forms.TextBox direccionTxtBox;
        private System.Windows.Forms.Label numeroLbl;
        private System.Windows.Forms.TextBox numeroTxtBox;
        private System.Windows.Forms.Button pedidoButton;
    }
}