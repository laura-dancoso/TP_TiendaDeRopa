namespace TiendaDeRopa.UI
{
    partial class Ingreso
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
            this.BtnIngresarUser = new System.Windows.Forms.Button();
            this.BtnIngresarAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIngresarUser
            // 
            this.BtnIngresarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresarUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIngresarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnIngresarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarUser.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnIngresarUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIngresarUser.Location = new System.Drawing.Point(250, 129);
            this.BtnIngresarUser.Name = "BtnIngresarUser";
            this.BtnIngresarUser.Size = new System.Drawing.Size(324, 45);
            this.BtnIngresarUser.TabIndex = 3;
            this.BtnIngresarUser.Text = "Ingresar";
            this.BtnIngresarUser.UseVisualStyleBackColor = true;
            this.BtnIngresarUser.Click += new System.EventHandler(this.BtnIngresarUser_Click);
            // 
            // BtnIngresarAdmin
            // 
            this.BtnIngresarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresarAdmin.Enabled = false;
            this.BtnIngresarAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIngresarAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnIngresarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnIngresarAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIngresarAdmin.Location = new System.Drawing.Point(250, 209);
            this.BtnIngresarAdmin.Name = "BtnIngresarAdmin";
            this.BtnIngresarAdmin.Size = new System.Drawing.Size(324, 45);
            this.BtnIngresarAdmin.TabIndex = 4;
            this.BtnIngresarAdmin.Text = "Ingresar como administrador";
            this.BtnIngresarAdmin.UseVisualStyleBackColor = true;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIngresarAdmin);
            this.Controls.Add(this.BtnIngresarUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnIngresarUser;
        private Button BtnIngresarAdmin;
    }
}