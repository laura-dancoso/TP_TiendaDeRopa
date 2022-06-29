namespace TiendaDeRopa.UI
{
    partial class Producto
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
            this.img = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.talle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.Transparent;
            this.img.Image = global::TiendaDeRopa.UI.Properties.Resources._1;
            this.img.Location = new System.Drawing.Point(0, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(147, 196);
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombre.Location = new System.Drawing.Point(7, 209);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(126, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "REMERA BLACK TOTAL";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.precio.Location = new System.Drawing.Point(7, 260);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(49, 13);
            this.precio.TabIndex = 2;
            this.precio.Text = "$198123";
            // 
            // btnCarrito
            // 
            this.btnCarrito.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarrito.Location = new System.Drawing.Point(0, 276);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(148, 26);
            this.btnCarrito.TabIndex = 3;
            this.btnCarrito.Text = "Agregar al carrito";
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // talle
            // 
            this.talle.AutoSize = true;
            this.talle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.talle.Location = new System.Drawing.Point(7, 233);
            this.talle.Name = "talle";
            this.talle.Size = new System.Drawing.Size(38, 13);
            this.talle.TabIndex = 4;
            this.talle.Text = "label1";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.talle);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.img);
            this.Name = "Producto";
            this.Size = new System.Drawing.Size(148, 302);
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox img;
        private Label nombre;
        private Label precio;
        private Button btnCarrito;
        private Label talle;
    }
}
