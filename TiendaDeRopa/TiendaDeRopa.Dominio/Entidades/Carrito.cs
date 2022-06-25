namespace TiendaDeRopa.Dominio.Entidades
{
    public class Carrito : Entidad
    {
        public List<DetalleCarrito> Detalles { get; set; }

        public Carrito()
        {
            Detalles = new List<DetalleCarrito>();
        }

        public Carrito(List<DetalleCarrito> detalles)
        {
            Detalles = detalles;
        }

        public void VaciarCarrito()
        {
            Detalles = new List<DetalleCarrito>();
        }
    }
}
