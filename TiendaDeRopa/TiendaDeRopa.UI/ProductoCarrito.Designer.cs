namespace TiendaDeRopa.UI
{
    partial class ProductoCarrito
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.talle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombre.Location = new System.Drawing.Point(3, 9);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(126, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "REMERA BLACK TOTAL";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.precio.Location = new System.Drawing.Point(285, 9);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(49, 13);
            this.precio.TabIndex = 2;
            this.precio.Text = "$198123";
            // 
            // btnCarrito
            // 
            this.btnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrito.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarrito.Location = new System.Drawing.Point(387, 3);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(148, 26);
            this.btnCarrito.TabIndex = 3;
            this.btnCarrito.Text = "Eliminar del carrito";
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // talle
            // 
            this.talle.AutoSize = true;
            this.talle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.talle.Location = new System.Drawing.Point(193, 9);
            this.talle.Name = "talle";
            this.talle.Size = new System.Drawing.Size(38, 13);
            this.talle.TabIndex = 4;
            this.talle.Text = "label1";
            // 
            // ProductoCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.talle);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombre);
            this.Name = "ProductoCarrito";
            this.Size = new System.Drawing.Size(538, 37);
            this.Load += new System.EventHandler(this.Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label nombre;
        private Label precio;
        private Button btnCarrito;
        private Label talle;
    }
}
