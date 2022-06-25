namespace TiendaDeRopa.Dominio.Entidades
{
    public class Tienda : Entidad
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
        public List<Compra> Compras { get; set; }

        public Tienda(int id,string tipo, string nombre, List<Producto> productos, List<Compra> compras):base(id)
        {
            Tipo = tipo;
            Nombre = nombre;
            Productos = productos;
            Compras = compras;
        }
        public Tienda(int id,string tipo, string nombre): base(id)
        {
            Tipo = tipo;
            Nombre = nombre;
            Productos = new List<Producto>();
            Compras = new List<Compra>();
        }
        public Tienda(int id,string tipo, string nombre, List<Producto> productos):base(id)
        {
            Tipo = tipo;
            Nombre = nombre;
            Productos = productos;
            Compras = new List<Compra>();
        }
    }
}
