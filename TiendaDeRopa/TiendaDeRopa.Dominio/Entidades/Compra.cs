namespace TiendaDeRopa.Dominio.Entidades
{
    public class Compra : Entidad
    {
        public DateTime Fecha { get; set; }
        public Carrito Carrito { get; set; }
        public Cliente Cliente { get; set; }

        public Compra(DateTime fecha, Carrito carrito, Cliente cliente)
        {
            Fecha = fecha;
            Carrito = carrito;
            Cliente = cliente;
        }
    }
}
