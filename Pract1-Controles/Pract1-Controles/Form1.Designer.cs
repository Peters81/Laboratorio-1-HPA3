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
            DIA = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            btnEnviar = new Button();
            btnSalir = new Button();
            respuesta = new Label();
            SuspendLayout();
            // 
            // DIA
            // 
            DIA.AutoSize = true;
            DIA.Location = new Point(59, 63);
            DIA.Name = "DIA";
            DIA.Size = new Size(26, 15);
            DIA.TabIndex = 0;
            DIA.Text = "DIA";
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 124);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "MES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 193);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "ANIO";
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
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(DIA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DIA;
        private Label label2;
        private Label label1;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Button btnEnviar;
        private Button btnSalir;
        private Label respuesta;
    }
}
