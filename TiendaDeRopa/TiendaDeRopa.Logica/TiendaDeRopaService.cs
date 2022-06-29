using TiendaDeRopa.Dominio.Entidades;

namespace TiendaDeRopa.Logica
{
    public class TiendaDeRopaService
    {
        private readonly IDataInicialService _dataService;
        private readonly ILoginService _loginService;
        private readonly ICompraService _compraService;
        private readonly IdGeneratorService _idGeneratorService;
        private readonly IFacturaService _facturaService;

        private Tienda _tienda;
        private Cliente? _cliente;

        public TiendaDeRopaService(
            IDataInicialService dataService,
            ILoginService loginService,
            ICompraService compraService,
            IFacturaService facturaService)
        {
            _dataService = dataService;
            _loginService = loginService;
            _compraService = compraService;
            _tienda = _dataService.AgregarProductosIniciales(_dataService.GetTiendaOnline());
            _idGeneratorService = new IdGeneratorService(_tienda);
            _facturaService = facturaService;
        }

        public List<Producto> GetProductos()
        {
            return _tienda.Productos;
        }

        public string Descripcion()
        {
            return _tienda.ToString();
        }

        public void Ingresar()
        {
            Cliente cliente = _dataService.GetClienteInvitado();
            try
            {
                _loginService.LogIn(cliente);
                _cliente = cliente;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Salir()
        {
            try
            {
                _loginService.LogOut(_dataService.GetClienteInvitado());
                _cliente = null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void IniciarCompra()
        {
            VerificarCliente();            
            Compra compraActual = _compraService.IniciarCompra(_idGeneratorService.IdCompra(), _idGeneratorService.IdCarrito(), _cliente!);
            _tienda.Compras.Add(compraActual);
        }

        public Carrito MostrarCarrito()
        {
            VerificarCliente();
            return _compraService.MostrarCarrito();
        }

        public void AgregarProductoAlCarrito(int id, int cantidad)
        {
            VerificarCliente();
            Producto producto = _tienda.Productos.Find(p => p.Id == id) ?? throw new Exception("Debe existir un producto");
            _compraService.AgregarDetalleCarrito(new DetalleCarrito(_idGeneratorService.IdDetalleCarrito(), cantidad, producto!));
        }

        public void ModificarCantidadDetalleCarrito(int id, int cantidad)
        {
            VerificarCliente();

            _compraService.ModificarCantidadProducto(id, cantidad);
        }

        public void EliminarDetalleCarrito(int id)
        {
            VerificarCliente();

            _compraService.EliminarDetalleCarrito(id);
        }

        public void VaciarCarrito()
        {
            VerificarCliente();
            _compraService.VaciarCarrito();            
        }

        private void VerificarCliente()
        {
            if (_cliente is null) throw new Exception("Debe existir un cliente para realizar esta acción");
        }

        public float TotalCompra()
        {
            return _compraService.TotalCompra();

        }
    }
}
