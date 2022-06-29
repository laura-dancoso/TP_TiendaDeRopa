using TiendaDeRopa.Logica;

namespace TiendaDeRopa.UI
{
    internal static class LogicUI
    {
        public static void CargarProductos(FlowLayoutPanel flowLy,TiendaDeRopaService tiendaService)
        {
            flowLy.Controls.Clear();
            tiendaService.MostrarCarrito().Detalles.Select(d => d.Producto).ToList().ForEach(p =>
            {
                flowLy.Controls.Add(new ProductoCarrito(p.Id, p.Nombre, p.Talle, p.Precio, tiendaService, flowLy));
            });
        }
    }
}
