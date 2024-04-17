namespace ExamenRecuperacion_Abraham
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCantidadPersonas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoRuta = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxImporteBruto = new System.Windows.Forms.TextBox();
            this.tbxPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.tbxMontoDescuento = new System.Windows.Forms.TextBox();
            this.tbxImportePago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese tipo de cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "[A] Promoción colegios, [B] Adultos mayores, [C] Adultos menores";
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "A-Promoción de colegios",
            "B-Adultos mayores de 60 años",
            "C-Adultos menores de 60 y jóvenes"});
            this.cbxTipoCliente.Location = new System.Drawing.Point(586, 48);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(202, 24);
            this.cbxTipoCliente.TabIndex = 2;
            this.cbxTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbxTipoCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de personas:";
            // 
            // tbxCantidadPersonas
            // 
            this.tbxCantidadPersonas.Location = new System.Drawing.Point(229, 90);
            this.tbxCantidadPersonas.Name = "tbxCantidadPersonas";
            this.tbxCantidadPersonas.Size = new System.Drawing.Size(166, 22);
            this.tbxCantidadPersonas.TabIndex = 4;
            this.tbxCantidadPersonas.TextChanged += new System.EventHandler(this.tbxCantidadPersonas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de ruta:";
            // 
            // cbxTipoRuta
            // 
            this.cbxTipoRuta.FormattingEnabled = true;
            this.cbxTipoRuta.Items.AddRange(new object[] {
            "1-Sacsayhuaman – Puka Pukara – Tambomachay (S/. 100)",
            "2-Tipon -Lucre-Piquillaqta (S/. 120)",
            "3-Ollantaytambo-Machupicchu (S/. 150)"});
            this.cbxTipoRuta.Location = new System.Drawing.Point(146, 123);
            this.cbxTipoRuta.Name = "cbxTipoRuta";
            this.cbxTipoRuta.Size = new System.Drawing.Size(408, 24);
            this.cbxTipoRuta.TabIndex = 6;
            this.cbxTipoRuta.SelectedIndexChanged += new System.EventHandler(this.cbxTipoRuta_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(342, 168);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 30);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.ImportePago});
            this.dataGridView1.Location = new System.Drawing.Point(43, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 308);
            this.dataGridView1.TabIndex = 8;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // ImportePago
            // 
            this.ImportePago.HeaderText = "ImportePago";
            this.ImportePago.MinimumWidth = 6;
            this.ImportePago.Name = "ImportePago";
            this.ImportePago.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxImportePago);
            this.groupBox1.Controls.Add(this.tbxMontoDescuento);
            this.groupBox1.Controls.Add(this.tbxPorcentajeDescuento);
            this.groupBox1.Controls.Add(this.tbxImporteBruto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(586, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 308);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Importe Bruto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Porcentaje Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Monto Descuento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Importe Pago:";
            // 
            // tbxImporteBruto
            // 
            this.tbxImporteBruto.Location = new System.Drawing.Point(179, 34);
            this.tbxImporteBruto.Name = "tbxImporteBruto";
            this.tbxImporteBruto.Size = new System.Drawing.Size(100, 22);
            this.tbxImporteBruto.TabIndex = 4;
            // 
            // tbxPorcentajeDescuento
            // 
            this.tbxPorcentajeDescuento.Location = new System.Drawing.Point(179, 69);
            this.tbxPorcentajeDescuento.Name = "tbxPorcentajeDescuento";
            this.tbxPorcentajeDescuento.Size = new System.Drawing.Size(100, 22);
            this.tbxPorcentajeDescuento.TabIndex = 5;
            // 
            // tbxMontoDescuento
            // 
            this.tbxMontoDescuento.Location = new System.Drawing.Point(179, 103);
            this.tbxMontoDescuento.Name = "tbxMontoDescuento";
            this.tbxMontoDescuento.Size = new System.Drawing.Size(100, 22);
            this.tbxMontoDescuento.TabIndex = 6;
            // 
            // tbxImportePago
            // 
            this.tbxImportePago.Location = new System.Drawing.Point(179, 142);
            this.tbxImportePago.Name = "tbxImportePago";
            this.tbxImportePago.Size = new System.Drawing.Size(100, 22);
            this.tbxImportePago.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxTipoRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCantidadPersonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCantidadPersonas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoRuta;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportePago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxImportePago;
        private System.Windows.Forms.TextBox tbxMontoDescuento;
        private System.Windows.Forms.TextBox tbxPorcentajeDescuento;
        private System.Windows.Forms.TextBox tbxImporteBruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

