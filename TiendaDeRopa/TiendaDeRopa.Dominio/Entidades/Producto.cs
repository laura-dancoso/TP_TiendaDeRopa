namespace TiendaDeRopa.Dominio.Entidades
{
    public class Producto:Entidad
    {
        public string Descripcion { get; set; }
        public string Talle { get; set; }
        public float Precio { get; set; }
        public int Stock { get; private set; }

        public Producto(string descripcion, string talle, float precio, int stock)
        {
            Descripcion = descripcion;
            Talle = talle;
            Precio = precio;
            Stock = stock;
        }

        public bool HayStock()
        {
            return Stock > 0;
        }

        public void ModificarStock(int nuevoStock)
        {
            Stock = nuevoStock;
        }
    }
}
