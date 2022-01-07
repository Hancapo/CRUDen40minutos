using PinguinPapu;


bool Menu = true;
MetodosPinguino mp = new();

List<Pinguino> listaPinguinos = new List<Pinguino>(); 


while (Menu)
{
    int decision = -1;

    Console.WriteLine("=== BIENVENIDO A PINGüINo lindos ==========");
    Console.WriteLine("1. Crear pingüino");
    Console.WriteLine("2. Modificar pingüino");
    Console.WriteLine("3. Eliminar pingüino");
    Console.WriteLine("4. Lista pingüino");
    Console.WriteLine("5. Salir");

    decision = Convert.ToInt32(Console.ReadLine()); 

    switch (decision)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Ingrese un nombre: ");
            string nombrep = Console.ReadLine();
            Console.WriteLine("Ingrese un color: ");

            string colorp = Console.ReadLine();
            Console.WriteLine("Ingrese una altura: ");

            float alturap = float.Parse(Console.ReadLine());
            Pinguino p = new() {Nombre = nombrep, Altura = alturap, Color = colorp};

            if (mp.AgregarPenguino(p, listaPinguinos))
            {
                Console.WriteLine("Se ha agregado el pingüino exitosamente, presione cualquier tecla para regresar");

                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("No se ha podido ingresar el pingüino, presione cualquier tecla para regresar");
                Console.ReadKey();
                Console.Clear();

                break;
            }

        case 2:
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del pinguno que desea editar basado en la siguiente lista:");
            mp.ImprimirPinguinos(listaPinguinos);

            Console.WriteLine("\nNombre: ");
            string nombreamodi = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Ingrese un nombre: ");
            string nombrep2 = Console.ReadLine();
            Console.WriteLine("Ingrese un color: ");

            string colorp2 = Console.ReadLine();
            Console.WriteLine("Ingrese una altura: ");

            float alturap2 = float.Parse(Console.ReadLine());
            Pinguino p3 = new() { Nombre = nombrep2, Altura = alturap2, Color = colorp2 };


            if (mp.EditarPinguino(nombreamodi, p3, listaPinguinos))
            {
                Console.WriteLine("Se ha editado el pingüino exitosamente, presione cualquier tecla para regresar");

                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("No se ha podido editar el pingüino, presione cualquier tecla para regresar");
                Console.ReadKey();
                Console.Clear();

                break;
            }

        case 3:
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del pinguno que desea eliminar basado en la siguiente lista:");
            mp.ImprimirPinguinos(listaPinguinos);

            Console.WriteLine("\nNombre: ");
            string nombreaelminar = Console.ReadLine();

            Pinguino pe2 = new() { Nombre = nombreaelminar };

            if (mp.EliminarPinguino(pe2, listaPinguinos))
            {
                Console.WriteLine("Se ha eliminado el pingüino exitosamente, presione cualquier tecla para regresar");

                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("No se ha eliminado editar el pingüino, presione cualquier tecla para regresar");
                Console.ReadKey();
                Console.Clear();

                break;
            }
        case 4:
            Console.Clear();
            mp.ImprimirPinguinos(listaPinguinos);
            Console.WriteLine("Presiona cualquier tecla para regresar");
            Console.ReadKey();
            Console.Clear();
            break;

        case 5:
            Environment.Exit(0);
            break;

        default:
            break;
    }
}