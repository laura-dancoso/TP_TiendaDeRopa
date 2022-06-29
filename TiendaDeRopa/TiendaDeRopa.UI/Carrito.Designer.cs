

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
            this.BtnDescargaFactura = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLy = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTextoTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(137, 393);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 37);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "$ 0";
            // 
            // BtnDescargaFactura
            // 
            this.BtnDescargaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDescargaFactura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDescargaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnDescargaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescargaFactura.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDescargaFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDescargaFactura.Location = new System.Drawing.Point(452, 393);
            this.BtnDescargaFactura.Name = "BtnDescargaFactura";
            this.BtnDescargaFactura.Size = new System.Drawing.Size(324, 45);
            this.BtnDescargaFactura.TabIndex = 3;
            this.BtnDescargaFactura.Text = "Descargar factura";
            this.BtnDescargaFactura.UseVisualStyleBackColor = true;
            this.BtnDescargaFactura.Click += new System.EventHandler(this.BtnDescargaFactura_Click);
            // 
            // flowLy
            // 
            this.flowLy.Location = new System.Drawing.Point(54, 40);
            this.flowLy.Name = "flowLy";
            this.flowLy.Size = new System.Drawing.Size(722, 331);
            this.flowLy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carrito";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTextoTotal
            // 
            this.labelTextoTotal.AutoSize = true;
            this.labelTextoTotal.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTextoTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTextoTotal.Location = new System.Drawing.Point(54, 393);
            this.labelTextoTotal.Name = "labelTextoTotal";
            this.labelTextoTotal.Size = new System.Drawing.Size(90, 37);
            this.labelTextoTotal.TabIndex = 6;
            this.labelTextoTotal.Text = "Total: ";
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTextoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLy);
            this.Controls.Add(this.BtnDescargaFactura);
            this.Controls.Add(this.labelTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Carrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTotal;
        private Button BtnDescargaFactura;
        private SaveFileDialog saveFileDialog1;
        private FlowLayoutPanel flowLy;
        private Label label1;
        private Label labelTextoTotal;
    }
}