namespace Problema_3_Lab_1
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
            label1 = new Label();
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            txtResultado = new TextBox();
            lbloperador = new Label();
            lbligual = new Label();
            groupBox1 = new GroupBox();
            RbtnDivision = new RadioButton();
            RbtnMultiplicacion = new RadioButton();
            RbtnResta = new RadioButton();
            RbtnSuma = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 65);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese lo valores y seleccione una opcion";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(91, 120);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(110, 23);
            txtnumero1.TabIndex = 1;
            txtnumero1.TextChanged += txtnumero1_TextChanged;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(280, 120);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(110, 23);
            txtnumero2.TabIndex = 2;
            txtnumero2.TextChanged += txtnumero2_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(470, 120);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(110, 23);
            txtResultado.TabIndex = 3;
            // 
            // lbloperador
            // 
            lbloperador.AutoSize = true;
            lbloperador.Location = new Point(232, 128);
            lbloperador.Name = "lbloperador";
            lbloperador.Size = new Size(15, 15);
            lbloperador.TabIndex = 4;
            lbloperador.Text = "+";
            // 
            // lbligual
            // 
            lbligual.AutoSize = true;
            lbligual.Location = new Point(427, 128);
            lbligual.Name = "lbligual";
            lbligual.Size = new Size(15, 15);
            lbligual.TabIndex = 5;
            lbligual.Text = "=";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbtnDivision);
            groupBox1.Controls.Add(RbtnMultiplicacion);
            groupBox1.Controls.Add(RbtnResta);
            groupBox1.Controls.Add(RbtnSuma);
            groupBox1.Location = new Point(91, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 148);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // RbtnDivision
            // 
            RbtnDivision.AutoSize = true;
            RbtnDivision.Location = new Point(24, 97);
            RbtnDivision.Name = "RbtnDivision";
            RbtnDivision.Size = new Size(67, 19);
            RbtnDivision.TabIndex = 10;
            RbtnDivision.TabStop = true;
            RbtnDivision.Text = "Division";
            RbtnDivision.UseVisualStyleBackColor = true;
            RbtnDivision.CheckedChanged += RbtnDivision_CheckedChanged;
            // 
            // RbtnMultiplicacion
            // 
            RbtnMultiplicacion.AutoSize = true;
            RbtnMultiplicacion.Location = new Point(24, 72);
            RbtnMultiplicacion.Name = "RbtnMultiplicacion";
            RbtnMultiplicacion.Size = new Size(101, 19);
            RbtnMultiplicacion.TabIndex = 9;
            RbtnMultiplicacion.TabStop = true;
            RbtnMultiplicacion.Text = "Multiplicacion";
            RbtnMultiplicacion.UseVisualStyleBackColor = true;
            RbtnMultiplicacion.CheckedChanged += RbtnMultiplicacion_CheckedChanged;
            // 
            // RbtnResta
            // 
            RbtnResta.AutoSize = true;
            RbtnResta.Location = new Point(24, 47);
            RbtnResta.Name = "RbtnResta";
            RbtnResta.Size = new Size(53, 19);
            RbtnResta.TabIndex = 8;
            RbtnResta.TabStop = true;
            RbtnResta.Text = "Resta";
            RbtnResta.UseVisualStyleBackColor = true;
            RbtnResta.CheckedChanged += RbtnResta_CheckedChanged;
            // 
            // RbtnSuma
            // 
            RbtnSuma.AutoSize = true;
            RbtnSuma.Location = new Point(24, 22);
            RbtnSuma.Name = "RbtnSuma";
            RbtnSuma.Size = new Size(55, 19);
            RbtnSuma.TabIndex = 7;
            RbtnSuma.TabStop = true;
            RbtnSuma.Text = "Suma";
            RbtnSuma.UseVisualStyleBackColor = true;
            RbtnSuma.CheckedChanged += RbtnSuma_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lbligual);
            Controls.Add(lbloperador);
            Controls.Add(txtResultado);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private TextBox txtResultado;
        private Label lbloperador;
        private Label lbligual;
        private GroupBox groupBox1;
        private RadioButton RbtnDivision;
        private RadioButton RbtnMultiplicacion;
        private RadioButton RbtnResta;
        private RadioButton RbtnSuma;
    }
}
