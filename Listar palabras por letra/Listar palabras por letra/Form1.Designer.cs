namespace Listar_palabras_por_letra
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(30, 30);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(200, 20);
            this.txtPalabra.TabIndex = 0;

            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Palabra";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(250, 30);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(300, 200);
            this.lstPalabras.TabIndex = 2;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Estado";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPalabra);
            this.Name = "Form1";
            this.Text = "Listar Palabras por Letra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label lblStatus;
    }
}

