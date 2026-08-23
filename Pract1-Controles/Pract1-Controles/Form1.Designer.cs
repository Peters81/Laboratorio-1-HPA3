namespace Pract1_Controles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDia = new Label();
            lblMes = new Label();
            lblAnio = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            btnEnviar = new Button();
            btnSalir = new Button();
            respuesta = new Label();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(59, 63);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(26, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "DIA";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(59, 124);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(30, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "MES";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(59, 193);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(36, 15);
            lblAnio.TabIndex = 2;
            lblAnio.Text = "ANIO";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(107, 60);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(107, 121);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(107, 190);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(132, 272);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(281, 272);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // respuesta
            // 
            respuesta.AutoSize = true;
            respuesta.Location = new Point(575, 116);
            respuesta.Name = "respuesta";
            respuesta.Size = new Size(68, 15);
            respuesta.TabIndex = 8;
            respuesta.Text = "La fecha es:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(respuesta);
            Controls.Add(btnSalir);
            Controls.Add(btnEnviar);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblAnio);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblMes;
        private Label lblAnio;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Button btnEnviar;
        private Button btnSalir;
        private Label respuesta;
    }
}
