namespace CapaGUIwf
{
    partial class Ingreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btoGrabar = new System.Windows.Forms.Button();
            this.btoSalir = new System.Windows.Forms.Button();
            this.btoMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estatura (metros)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso (kilos)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IMC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(114, 31);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(158, 20);
            this.txtRut.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(114, 102);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(158, 20);
            this.txtEstatura.TabIndex = 8;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(114, 130);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(158, 20);
            this.txtPeso.TabIndex = 9;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(114, 159);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(158, 20);
            this.txtIMC.TabIndex = 10;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(114, 185);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(158, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // btoGrabar
            // 
            this.btoGrabar.Location = new System.Drawing.Point(28, 226);
            this.btoGrabar.Name = "btoGrabar";
            this.btoGrabar.Size = new System.Drawing.Size(75, 23);
            this.btoGrabar.TabIndex = 12;
            this.btoGrabar.Text = "Grabar";
            this.btoGrabar.UseVisualStyleBackColor = true;
            this.btoGrabar.Click += new System.EventHandler(this.btoGrabar_Click);
            // 
            // btoSalir
            // 
            this.btoSalir.Location = new System.Drawing.Point(204, 226);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(75, 23);
            this.btoSalir.TabIndex = 13;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            this.btoSalir.Click += new System.EventHandler(this.btoSalir_Click);
            // 
            // btoMostrar
            // 
            this.btoMostrar.Location = new System.Drawing.Point(115, 226);
            this.btoMostrar.Name = "btoMostrar";
            this.btoMostrar.Size = new System.Drawing.Size(75, 23);
            this.btoMostrar.TabIndex = 14;
            this.btoMostrar.Text = "Mostrar";
            this.btoMostrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btoMostrar);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.btoGrabar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btoGrabar;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.Button btoMostrar;
        private System.Windows.Forms.Label label2;
    }
}