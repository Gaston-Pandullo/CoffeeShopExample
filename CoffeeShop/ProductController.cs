
using Spectre.Console;

namespace CoffeeShop
{
    internal class ProductController
    {
        internal static void ActualizarProducto()
        {
            return;
        }

        internal static void AgregarProducto()
        {
            var name = AnsiConsole.Ask<string>("Nombre del producto: ");

            using var dbContext = new ProductContext();
            dbContext.Add(new Product { Name = name });
            dbContext.SaveChanges();
        }

        internal static void BorrarProducto()
        {
            return;
        }

        internal static void VerProducto()
        {
            return;
        }

        internal static void VerTodosLosProducto()
        {
            return;
        }
    }
}
