using TiendaDeRopa.Logica;

namespace TiendaDeRopa.UI
{
    public partial class Producto : UserControl
    {
        private TiendaDeRopaService _tiendaService;
        public int Id { get ; set; }
        public string Nombre { get => nombre.Text; set => nombre.Text = value; }
        public string Talle { get => nombre.Text; set => talle.Text = "Talle: "+ value; }
        public float Precio { get => float.Parse(precio.Text); set => precio.Text = "$" +value.ToString(); }
        public Image Imagen { get => img.Image; set=> img.Image=value; }
        public Producto(int id, string nombre, string talle, float precio, Image imagen, TiendaDeRopaService service)
        {
            InitializeComponent();
            _tiendaService = service;
            Id = id;
            Nombre = nombre;
            Talle = talle;
            Precio = precio;
            Imagen = imagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _tiendaService.AgregarProductoAlCarrito(Id, 1);
                MessageBox.Show("Producto agregado!");
            }catch
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
