﻿namespace Invertidor_de_palabras
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(30, 30);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(200, 20);
            this.txtPalabra.TabIndex = 0;

            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(30, 70);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(100, 23);
            this.btnInvertir.TabIndex = 1;
            this.btnInvertir.Text = "Invertir Palabra";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Palabra invertida: ";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtPalabra);
            this.Name = "Form1";
            this.Text = "Invertir Palabra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}
