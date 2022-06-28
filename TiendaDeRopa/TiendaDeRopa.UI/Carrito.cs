using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeRopa.UI
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDescargaFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoGuardar = File.CreateText(txt);
                        textoGuardar.WriteLine("Detalles de la compra ------------");
                        textoGuardar.Flush();
                        textoGuardar.Close();

                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoGuardar = File.CreateText(txt);
                        textoGuardar.WriteLine("Detalles de la compra");
                        textoGuardar.Flush();
                        textoGuardar.Close();
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar guardar");
            }
        }

        private void BtnSeguirComprando_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
