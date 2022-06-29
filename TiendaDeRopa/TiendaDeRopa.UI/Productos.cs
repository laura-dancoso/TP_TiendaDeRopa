using TiendaDeRopa.Logica;
using TiendaDeRopa.UI.Properties;

namespace TiendaDeRopa.UI
{
    public partial class Productos : Form
    {
        private TiendaDeRopaService _tiendaService;
        public Productos(TiendaDeRopaService tiendaService)
        {
            _tiendaService = tiendaService;
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            _tiendaService.GetProductos().ForEach(p =>
            {
                flowLayout.Controls.Add(new Producto(p.Id,p.Nombre, p.Talle, p.Precio,Resources.GetImg(p.Id.ToString()), _tiendaService));
            });
        }

        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
