namespace TiendaDeRopa.Dominio.Entidades
{
    public class Compra : Entidad
    {
        public DateTime Fecha { get; set; }
        public Carrito Carrito { get; set; }
        public Cliente Cliente { get; set; }

        public Compra(int id,DateTime fecha, Carrito carrito, Cliente cliente):base(id)
        {
            Fecha = fecha;
            Carrito = carrito;
            Cliente = cliente;
        }
    }
}
