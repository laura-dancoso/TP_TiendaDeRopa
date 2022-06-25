namespace TiendaDeRopa.Dominio.Entidades
{
    public class Carrito : Entidad
    {
        public List<DetalleCarrito> Detalles { get; set; }

        public Carrito(int id):base(id)
        {
            Detalles = new List<DetalleCarrito>();
        }

        public Carrito(int id,List<DetalleCarrito> detalles): base(id)
        {
            Detalles = detalles;
        }

        public void VaciarCarrito()
        {
            Detalles = new List<DetalleCarrito>();
        }
    }
}
