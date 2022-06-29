using System.Runtime.InteropServices;
using TiendaDeRopa.Logica;

namespace TiendaDeRopa.UI
{
    public partial class Bienvenida : Form
    {
        private TiendaDeRopaService _tiendaService;
        public Bienvenida(TiendaDeRopaService tiendaService)
        {
            _tiendaService = tiendaService;
            _tiendaService.IniciarCompra();
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximize.Visible = false;
            BtnRestore.Visible = true;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestore.Visible = false;
            BtnMaximize.Visible = true;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirForm(object formHijo)
        {
            if (this.PanelContainer.Controls.Count > 0)            
                this.PanelContainer.Controls.RemoveAt(0);
            Form? fh = (Form) formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fh);
            this.PanelContainer.Tag = fh;
            fh.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Productos(_tiendaService));
            //BtnProductos.BackColor = SystemColors.Control;
        }

        private void BtnCarrito1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Carrito(_tiendaService));
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            _tiendaService.Salir();
            var form = new Ingreso(_tiendaService);
            form.Show();
            this.Hide();
        }
    }
}