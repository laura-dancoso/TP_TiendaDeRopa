using TiendaDeRopa.Dominio.Entidades;

namespace TiendaDeRopa.Logica
{
    public class IdGeneratorService
    {
        private readonly Tienda _tienda;

        public IdGeneratorService(Tienda tienda)
        {
            _tienda = tienda;
        }
        
        public int IdCompra()
        {
            int ultimoIdCompra = _tienda.Compras.Any() ? _tienda.Compras.Max(c => c.Id) : 0;
            return ultimoIdCompra + 1;
        }
        
        public int IdCarrito()
        {
            var carritos = _tienda.Compras.Select(c => c.Carrito);
            int ultimoIdCarrito = carritos.Any() ? carritos.Max(c =>c.Id) : 0;
            return ultimoIdCarrito + 1;
        }

        public int IdDetalleCarrito()
        {
            var detallesCarritos = _tienda.Compras.Select(c => c.Carrito).SelectMany(c => c.Detalles);
            var ultimoIdDetalleCarrito = detallesCarritos.Any() ? detallesCarritos.Max(dc=> dc.Id) : 0;
            return ultimoIdDetalleCarrito + 1;
        }
    }
}
