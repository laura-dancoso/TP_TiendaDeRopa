using TiendaDeRopa.Dominio.Entidades;

namespace TiendaDeRopa.Logica
{
    public interface IFacturaService
    {
        public string GenerarFactura(Compra compra);
    }
    public class FacturaService : IFacturaService
    {
        public string GenerarFactura(Compra compra)
        {
            //generar factura
            return "factura generada lista para imprimir";
        }
    }
}
