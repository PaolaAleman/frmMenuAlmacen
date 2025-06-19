namespace frmMenuAlmacen
{
    partial class Form1
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
            this.btnRegistroProducto = new System.Windows.Forms.Button();
            this.btnMovimientoInventario = new System.Windows.Forms.Button();
            this.btnConsultaProductos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Control de Almacén";
            // 
            // btnRegistroProducto
            // 
            this.btnRegistroProducto.Location = new System.Drawing.Point(41, 63);
            this.btnRegistroProducto.Name = "btnRegistroProducto";
            this.btnRegistroProducto.Size = new System.Drawing.Size(132, 34);
            this.btnRegistroProducto.TabIndex = 1;
            this.btnRegistroProducto.Text = "Reguistar Producto";
            this.btnRegistroProducto.UseVisualStyleBackColor = true;
            // 
            // btnMovimientoInventario
            // 
            this.btnMovimientoInventario.Location = new System.Drawing.Point(193, 63);
            this.btnMovimientoInventario.Name = "btnMovimientoInventario";
            this.btnMovimientoInventario.Size = new System.Drawing.Size(163, 34);
            this.btnMovimientoInventario.TabIndex = 2;
            this.btnMovimientoInventario.Text = "Movimiento (Entrada /Salida)";
            this.btnMovimientoInventario.UseVisualStyleBackColor = true;
            // 
            // btnConsultaProductos
            // 
            this.btnConsultaProductos.Location = new System.Drawing.Point(372, 63);
            this.btnConsultaProductos.Name = "btnConsultaProductos";
            this.btnConsultaProductos.Size = new System.Drawing.Size(160, 34);
            this.btnConsultaProductos.TabIndex = 3;
            this.btnConsultaProductos.Text = "Consultar Producto";
            this.btnConsultaProductos.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(557, 63);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(109, 34);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(193, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnConsultaProductos);
            this.Controls.Add(this.btnMovimientoInventario);
            this.Controls.Add(this.btnRegistroProducto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroProducto;
        private System.Windows.Forms.Button btnMovimientoInventario;
        private System.Windows.Forms.Button btnConsultaProductos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}

