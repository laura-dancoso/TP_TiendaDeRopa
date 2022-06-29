using TiendaDeRopa.Dominio.Entidades;

namespace TiendaDeRopa.Logica
{
    public interface ICompraService
    {
        Compra IniciarCompra(int idCompra, int idCarrito, Cliente cliente);
        Carrito MostrarCarrito();
        void AgregarDetalleCarrito(DetalleCarrito detalleCarrito);
        void ModificarCantidadProducto(int id, int cantidad);
        void EliminarDetalleCarrito(int id);
        void VaciarCarrito();
        float TotalCompra();
    }
    public class CompraService : ICompraService
    {
        private Compra? _compra;
        public Compra IniciarCompra(int idCompra, int idCarrito, Cliente cliente)
        {
            _compra = new Compra(idCompra, DateTime.Now, new Carrito(idCarrito), cliente);
            return _compra;
        }

        public Carrito MostrarCarrito()
        {
            VerificarCompra();
            return _compra!.Carrito;
        }

        public void AgregarDetalleCarrito(DetalleCarrito detalleCarrito)
        {
            VerificarCompra();
            _compra?.Carrito.Detalles.Add(detalleCarrito);
        }

        public void ModificarCantidadProducto(int id, int cantidad)
        {
            VerificarCompra();

            _compra!.Carrito.Detalles.Find(dc => dc.Id == id)?.ModificarCantidad(cantidad);
        }

        public void EliminarDetalleCarrito(int id)
        {
            VerificarCompra();

            _compra!.Carrito.Detalles.RemoveAll(dc => dc.Id == id);
        }

        public void VaciarCarrito()
        {
            _compra?.Carrito.VaciarCarrito();
        }

        private void VerificarCompra()
        {
            if (_compra is null) throw new Exception("Debe existir una compra para realizar la acción");
        }

        public float TotalCompra()
        {
            VerificarCompra();
            return _compra!.Carrito.Detalles.Sum(d => d.Producto.Precio * d.Cantidad);
        }

    }
}