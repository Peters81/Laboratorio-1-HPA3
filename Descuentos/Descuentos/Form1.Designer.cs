namespace Descuentos
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
            lblValorVenta = new Label();
            lblDescuento1 = new Label();
            lblDescuento = new Label();
            lblVentaFinal = new Label();
            txtVENTA = new TextBox();
            txtDescuento1 = new TextBox();
            txtDescuento2 = new TextBox();
            txtVentaFinal = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblValorVenta
            // 
            lblValorVenta.AutoSize = true;
            lblValorVenta.Location = new Point(51, 97);
            lblValorVenta.Name = "lblValorVenta";
            lblValorVenta.Size = new Size(65, 15);
            lblValorVenta.TabIndex = 0;
            lblValorVenta.Text = "Valor Venta";
            // 
            // lblDescuento1
            // 
            lblDescuento1.AutoSize = true;
            lblDescuento1.Location = new Point(51, 140);
            lblDescuento1.Name = "lblDescuento1";
            lblDescuento1.Size = new Size(72, 15);
            lblDescuento1.TabIndex = 1;
            lblDescuento1.Text = "Descuento $";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(51, 188);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(76, 15);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            lblVentaFinal.AutoSize = true;
            lblVentaFinal.Location = new Point(59, 255);
            lblVentaFinal.Name = "lblVentaFinal";
            lblVentaFinal.Size = new Size(64, 15);
            lblVentaFinal.TabIndex = 3;
            lblVentaFinal.Text = "Venta Final";
            // 
            // txtVENTA
            // 
            txtVENTA.Location = new Point(138, 94);
            txtVENTA.Name = "txtVENTA";
            txtVENTA.Size = new Size(100, 23);
            txtVENTA.TabIndex = 4;
            // 
            // txtDescuento1
            // 
            txtDescuento1.Location = new Point(138, 140);
            txtDescuento1.Name = "txtDescuento1";
            txtDescuento1.Size = new Size(100, 23);
            txtDescuento1.TabIndex = 5;
            // 
            // txtDescuento2
            // 
            txtDescuento2.Location = new Point(138, 185);
            txtDescuento2.Name = "txtDescuento2";
            txtDescuento2.Size = new Size(100, 23);
            txtDescuento2.TabIndex = 6;
            // 
            // txtVentaFinal
            // 
            txtVentaFinal.Location = new Point(138, 247);
            txtVentaFinal.Name = "txtVentaFinal";
            txtVentaFinal.Size = new Size(100, 23);
            txtVentaFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(192, 255, 255);
            btnCalcular.Location = new Point(398, 118);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnLimpiar.Location = new Point(398, 157);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 255, 255);
            btnSalir.Location = new Point(398, 255);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtVentaFinal);
            Controls.Add(txtDescuento2);
            Controls.Add(txtDescuento1);
            Controls.Add(txtVENTA);
            Controls.Add(lblVentaFinal);
            Controls.Add(lblDescuento);
            Controls.Add(lblDescuento1);
            Controls.Add(lblValorVenta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValorVenta;
        private Label lblDescuento1;
        private Label lblDescuento;
        private Label lblVentaFinal;
        private TextBox txtVENTA;
        private TextBox txtDescuento1;
        private TextBox txtDescuento2;
        private TextBox txtVentaFinal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
