using AlmacenProductos.DAO;
using AlmacenProductos.Models;

Console.WriteLine();
Console.WriteLine("            BIENVENIDO A SU ALMACEN DE CONFIANZA           ");
Console.WriteLine();

CrudProductos CrudProductos = new CrudProductos();
Producto Producto = new Producto();

bool comprobar = true;
while (comprobar == true)
{
    Console.WriteLine("\n\n    Coloque un numero para realizar una accion   ");
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("                        MENU                         ");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("               1. Ingresar Productos                ");
    Console.WriteLine("               2. Productos registrados             ");
    Console.WriteLine("               3. Salir                             ");
    Console.WriteLine("----------------------------------------------------");

    Console.Write("- ¿Que desea hacer? ");
    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("\n\n  Ingresar productos:");
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("- Nombre del producto: ");
                Producto.Nombre = Console.ReadLine();
                Console.WriteLine("- Descripcion del producto:");
                Producto.Descripcion = Console.ReadLine();
                Console.WriteLine("- Precio del producto: ");
                Producto.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("- Cantidad de productos en stock: ");
                Producto.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------\n");
                CrudProductos.AgregarProductos(Producto);

                Console.WriteLine(" - Producto ingresado correctamente \n");

                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("   1. Continuar ingresando          ");
                Console.WriteLine("   2. Salir                         ");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("- ¿Que desea realizar? ");
                bucle = Convert.ToInt32(Console.ReadLine());

            }
            break;

        case 2:
            Console.WriteLine("        Ha sido un exito el registro del producto       ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("        Id Cantidad. Productos Descripcion Precio       ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Tenemos problemas con el servidor, intentelo mas tarde: ");

            comprobar = false;

            break;

        case 3:
            Console.WriteLine();
            Console.WriteLine("                GRACIAS POR PREFERIRNOS.                ");
            Console.WriteLine();

            comprobar = false;

            break;

    }
}

