using TiendaDeRopa.Logica;

TiendaDeRopaService tiendaService = new TiendaDeRopaService( new DataInicialService(), new LoginService(), new CompraService(), new FacturaService());

Console.WriteLine($"Bienvenido a la {tiendaService.Descripcion()}");

try
{
    Ingresar();
    IniciarCompra();
    MostrarProductos();
    Console.WriteLine("SELECCCIONE NRO DE PRODUCTO Para agregar al carrito");
    int idProducto = int.Parse(Console.ReadLine()!);
    Console.WriteLine("SELECCIONE CANTIDAD DEL PRODUCTO:");
    int cantidad = int.Parse(Console.ReadLine()!);
    tiendaService.AgregarProductoAlCarrito(idProducto, cantidad);
    Console.WriteLine($"{tiendaService.MostrarCarrito().Detalles.First().Producto.Nombre} agregado");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

void Ingresar()
{
    Console.WriteLine("Ingresando como cliente.................");
    try
    {
        tiendaService.Ingresar();
        Console.WriteLine("Login exitoso!");
    }
    catch (Exception e)
    {
        throw new Exception($"No es posible ingresar. {e.Message}");
    }
}

void IniciarCompra()
{
    Console.WriteLine("Iniciando compra........................");
    tiendaService.IniciarCompra();
}

void MostrarProductos()
{
    Console.WriteLine("Mostrando productos disponibles para compar.........");
    foreach (var producto in tiendaService.GetProductos())
    {
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine($"NRO_PRODUCTO: {producto.Id}");
        Console.WriteLine($"Nombre: {producto.Nombre}");
        Console.WriteLine($"Descripcion: {producto.Descripcion}");
        Console.WriteLine($"Talle: {producto.Talle}");
        Console.WriteLine($"Precio: {producto.Precio}");
        Console.WriteLine($"Cantidad disponible: {producto.Stock}");
        Console.WriteLine("---------------------------------------------------------------------");
    }
}