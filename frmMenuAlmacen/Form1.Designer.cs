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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistroProducto = new System.Windows.Forms.Button();
            this.btnMovimientoInventario = new System.Windows.Forms.Button();
            this.btnConsultaProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Control de Almacén";
            // 
            // btnRegistroProducto
            // 
            this.btnRegistroProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistroProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistroProducto.Location = new System.Drawing.Point(70, 202);
            this.btnRegistroProducto.Name = "btnRegistroProducto";
            this.btnRegistroProducto.Size = new System.Drawing.Size(178, 61);
            this.btnRegistroProducto.TabIndex = 1;
            this.btnRegistroProducto.Text = "Registar Producto";
            this.btnRegistroProducto.UseVisualStyleBackColor = false;
            this.btnRegistroProducto.Click += new System.EventHandler(this.btnRegistroProducto_Click);
            // 
            // btnMovimientoInventario
            // 
            this.btnMovimientoInventario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMovimientoInventario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMovimientoInventario.Location = new System.Drawing.Point(293, 202);
            this.btnMovimientoInventario.Name = "btnMovimientoInventario";
            this.btnMovimientoInventario.Size = new System.Drawing.Size(179, 61);
            this.btnMovimientoInventario.TabIndex = 2;
            this.btnMovimientoInventario.Text = "Movimiento ";
            this.btnMovimientoInventario.UseVisualStyleBackColor = false;
            this.btnMovimientoInventario.Click += new System.EventHandler(this.btnMovimientoInventario_Click);
            // 
            // btnConsultaProductos
            // 
            this.btnConsultaProductos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultaProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultaProductos.Location = new System.Drawing.Point(516, 202);
            this.btnConsultaProductos.Name = "btnConsultaProductos";
            this.btnConsultaProductos.Size = new System.Drawing.Size(199, 61);
            this.btnConsultaProductos.TabIndex = 3;
            this.btnConsultaProductos.Text = "Consultar Producto";
            this.btnConsultaProductos.UseVisualStyleBackColor = false;
            this.btnConsultaProductos.Click += new System.EventHandler(this.btnConsultaProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

