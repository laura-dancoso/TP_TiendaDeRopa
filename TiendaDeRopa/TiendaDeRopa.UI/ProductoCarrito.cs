using TiendaDeRopa.Logica;

namespace TiendaDeRopa.UI
{
    public partial class ProductoCarrito : UserControl
    {
        private TiendaDeRopaService _tiendaService;
        public int Id { get; set; }
        public string Nombre { get => nombre.Text; set => nombre.Text = value; }
        public string Talle { get => nombre.Text; set => talle.Text = "Talle: " + value; }
        public float Precio { get => float.Parse(precio.Text); set => precio.Text = "$" + value.ToString(); }
        FlowLayoutPanel flowLy;

        public ProductoCarrito(int id, string nombre, string talle, float precio ,TiendaDeRopaService service, FlowLayoutPanel fl)
        {
            InitializeComponent();
            _tiendaService = service;
            Id = id;
            Nombre = nombre;
            Talle = talle;
            Precio = precio;
            flowLy = fl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _tiendaService.EliminarDetalleCarrito(Id);
                LogicUI.CargarProductos(flowLy, _tiendaService);

            }
            catch
            {
                MessageBox.Show("Hubo un error!");
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void img_Click(object sender, EventArgs e)
        {

        }
    }
}
