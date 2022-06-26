namespace TiendaDeRopa.UI
{
    partial class Carrito
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.BtnIniciarCompra = new System.Windows.Forms.Button();
            this.BtnSeguirComprando = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(184, 238);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(105, 37);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total: $";
            this.labelTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnIniciarCompra
            // 
            this.BtnIniciarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarCompra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIniciarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnIniciarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarCompra.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnIniciarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIniciarCompra.Location = new System.Drawing.Point(74, 297);
            this.BtnIniciarCompra.Name = "BtnIniciarCompra";
            this.BtnIniciarCompra.Size = new System.Drawing.Size(324, 45);
            this.BtnIniciarCompra.TabIndex = 1;
            this.BtnIniciarCompra.Text = "Iniciar compra";
            this.BtnIniciarCompra.UseVisualStyleBackColor = true;
            // 
            // BtnSeguirComprando
            // 
            this.BtnSeguirComprando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeguirComprando.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSeguirComprando.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnSeguirComprando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeguirComprando.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSeguirComprando.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSeguirComprando.Location = new System.Drawing.Point(74, 348);
            this.BtnSeguirComprando.Name = "BtnSeguirComprando";
            this.BtnSeguirComprando.Size = new System.Drawing.Size(324, 45);
            this.BtnSeguirComprando.TabIndex = 2;
            this.BtnSeguirComprando.Text = "Seguir comprando";
            this.BtnSeguirComprando.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(74, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Descargar factura";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnSeguirComprando);
            this.Controls.Add(this.BtnIniciarCompra);
            this.Controls.Add(this.labelTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTotal;
        private Button BtnIniciarCompra;
        private Button BtnSeguirComprando;
        private Button button3;
    }
}