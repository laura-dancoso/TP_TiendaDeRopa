using TiendaDeRopa.Logica;

namespace TiendaDeRopa.UI
{
    public partial class Ingreso : Form
    {
        private TiendaDeRopaService _tiendaService;

        public Ingreso(TiendaDeRopaService tiendaService)
        {
            _tiendaService = tiendaService;
            InitializeComponent();
        }

        private void BtnIngresarUser_Click(object sender, EventArgs e)
        {
            try
            {
                _tiendaService.Ingresar();
                var form = new Bienvenida(_tiendaService);
                form.Show();
                this.Hide();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No es posible ingresar. {ex.Message}");
            }
        }
    }
}
