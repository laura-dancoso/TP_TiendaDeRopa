namespace TiendaDeRopa.Dominio.Entidades
{
    public class Tienda : Entidad
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
        public List<Compra> Compras { get; set; }

        public Tienda(string tipo, string nombre, List<Producto> productos, List<Compra> compras)
        {
            Tipo = tipo;
            Nombre = nombre;
            Productos = productos;
            Compras = compras;
        }
        public Tienda(string tipo, string nombre)
        {
            Tipo = tipo;
            Nombre = nombre;
            Productos = new List<Producto>();
            Compras = new List<Compra>();
        }
        public Tienda(string tipo, string nombre, List<Producto> productos)
        {
            Tipo = tipo;
            Nombre = nombre;
            Productos = productos;
            Compras = new List<Compra>();
        }
    }
}
