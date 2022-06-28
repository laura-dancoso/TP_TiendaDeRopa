using TiendaDeRopa.Dominio.Entidades;

namespace TiendaDeRopa.Logica
{
    public interface IDataInicialService
    {
        public Tienda AgregarProductosIniciales(Tienda tienda);
        public Tienda GetTiendaOnline();
        public Cliente GetClienteInvitado();
    }
    public class DataInicialService : IDataInicialService
    {
        public Tienda AgregarProductosIniciales(Tienda tienda)
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto(1, "CAMPERA ARI FUR", "Campera negra realizada en microfibra 100% náilon con acabado brillante y recubrimiento repelente al agua. Forrada en igual tela y matelasseada con relleno de vellón siliconado.", "XL", 29990, 5),
                new Producto(2, "ZAPATILLAS CLYDE", "Zapatillas urbanas con cordones. Capellada de material sintético y base liviana.", "40", 9699, 2),
                new Producto(3, "CAMISA SATURDAY", "Camisa manga larga realizada en poplín, un tejido de algodón de excelente calidad.", "S", 10390, 3),
                new Producto(4, "REMERA DYNAMIC", "Remera manga larga de algodón, con estampa al frente y escote redondo.", "M", 4690, 1),
                new Producto(5, "CHALECO REGIMENT", "Chaleco camuflado con cierre y bolsillos laterales. Relleno de vellón.", "S", 10990, 4),
                new Producto(6, "MEDIAS CORTAS", "Pack x3 de medias cortas tipo invisibles", "unico", 2400, 5)
            };
            tienda.Productos = productos;
            return tienda;
        }

        public Tienda GetTiendaOnline()
        {
            return new Tienda(1, "Online", "Tienda de Ropa");
        }

        public Cliente GetClienteInvitado()
        {
            return new Cliente(1, "Invitado", "invitado@gmail.com");
        }

    }
}