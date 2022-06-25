namespace TiendaDeRopa.Dominio.Entidades
{
    public class DetalleCarrito : Entidad
    {
        public int Cantidad { get; private set; }
        public Producto Producto { get; private set; }

        public DetalleCarrito(int id,int cantidad, Producto producto):base(id)
        {
            Cantidad = cantidad;
            Producto = producto;
        }

        public void ModificarCantidad(int nuevaCantidad)
        {
            Cantidad = nuevaCantidad;
        }
    }
}