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
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(342, 168);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 30);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 570);
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
    }
}

