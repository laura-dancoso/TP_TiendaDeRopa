using System.Data;
using TiendaDeRopa.Logica;

namespace TiendaDeRopa.UI
{
    public partial class Carrito : Form
    {
        private TiendaDeRopaService _tiendaService;
        public Carrito(TiendaDeRopaService tienda)
        {
            InitializeComponent();
            _tiendaService = tienda;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            if (_tiendaService.MostrarCarrito().Detalles.Any())
            {
                LogicUI.CargarProductos(flowLy, _tiendaService);

                labelTotal.Text = "$" + _tiendaService.TotalCompra().ToString();
                BtnDescargaFactura.Enabled = true;
            }
            else
            {
                //TODO!!
                // DEBERÍA CERRARSE LA PESTAÑA DEL CARRITO Y VOLVER AL DE PRODUCTOS O MOSTRAR EL COSO VACIO
                MessageBox.Show("El carrito está vacio!!");
                BtnDescargaFactura.Enabled = false;
                //SE ELIMINAN ESTAS LINEAS YA QUE SE SUPERPONEN LOS FORMS. REVISAR
                //new Productos(_tiendaService).Show();
                //this.Hide(); 
            }


        }

    }
}
