using CoffeeShop;
using Spectre.Console; // Libreria para generar una Menu interactivo.

bool isAppRunning = true;

while (isAppRunning)
{
    // Menu
    var option = AnsiConsole.Prompt(
    new SelectionPrompt<OpcionesMenu>()
    .Title("¿Que quiere hacer?")
    .AddChoices(
        OpcionesMenu.AgregarProducto,
        OpcionesMenu.BorrarProducto,
        OpcionesMenu.ActualizarProducto,
        OpcionesMenu.VerProducto,
        OpcionesMenu.VerTodosLosProductos,
        OpcionesMenu.Salir));

    switch (option)
    {
        case OpcionesMenu.AgregarProducto:
            ProductController.AgregarProducto();
            break;
        case OpcionesMenu.BorrarProducto:
            ProductController.BorrarProducto();
            break;
        case OpcionesMenu.ActualizarProducto:
            ProductController.ActualizarProducto();
            break;
        case OpcionesMenu.VerProducto:
            ProductController.VerProducto();
            break;
        case OpcionesMenu.VerTodosLosProductos:
            ProductController.VerTodosLosProducto();
            break;
        default:
            break;
    }
}


enum OpcionesMenu
{
    AgregarProducto,
    BorrarProducto,
    ActualizarProducto,
    VerProducto,
    VerTodosLosProductos,
    Salir
}