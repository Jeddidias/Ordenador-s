using System;

namespace Ordenador_de_numeros
{/// <summary>
/// Diseñar un ejercicio en donde se le soliciten al usuario una cantidad de 10 números diferentes
/// y la aplicación ordene los números ingresados según los métodos de ordenamiento.
/// El ejercicio se debe desarrollar teniendo en cuenta las excepciones y aplicar los métodos de ordenamiento (Burbuja, Shell, Selección, Inserción).
/// Adicionalmente cada ejercicio tendrá la posibilidad de generar la salida a través del manejo de archivos.
/// JORGE ESTEBAN DAWSON CASTILLO
/// GRUPO 112
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        // siguendo el procedimiento del ejercicio anterior y según los requerimientos de este nuevo lo primero que haré será un menu, ya que me pareció lo más adecuado para que el usuario escogiera un metodo
        menu:
            Console.Clear();
            Console.WriteLine("APLICATIVO ORDENADOR DE NUMEROS \n\n");
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("1. Metodo de Burbuja");
            Console.WriteLine("2. Metodo Shell");
            Console.WriteLine("3. Metodo de Selección");
            Console.WriteLine("4. Metodo de Inserción");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Ingrese el número que desea seleccionar");
            string opcion = Console.ReadLine();

            try
            {
                int opcionNumero = int.Parse(opcion); //Transformo la entrada del usuario de string a un Int

                if (opcionNumero >= 1 && opcionNumero <= 5)
                {
                    switch (opcion)//Entonces creo un switch que pase entre los distintos casos
                    {
                        case "1":
                            Burbuja burbuja = new Burbuja(); // aqui entonces empiezo a implementar las clases, que es algo que no hice en el ejercicio pasado, hare una por cada metodo de ordenamiento
                            burbuja.CargarNumeros();
                            burbuja.ordenarNumeros();
                            Console.WriteLine("Los numeros ordenados por el metodo burbuja quedan así: \n");
                            burbuja.mostrarNumeros();
                            burbuja.guardarNumerosArchivo();
                            goto menu;
                        case "2":
                            Shell shell = new Shell();
                            shell.CargarNumeros();
                            shell.ordenarNumeros();
                            Console.WriteLine("Los numeros ordenados por el metodo Shell quedan así: \n");
                            shell.mostrarNumeros();
                            shell.guardarNumerosArchivo();
                            goto menu;
                        case "3":
                            Seleccion seleccion = new Seleccion();
                            seleccion.CargarNumeros();
                            seleccion.ordenarNumeros();
                            Console.WriteLine("Los numeros ordenados por el metodo de Selección quedan así: \n");
                            seleccion.mostrarNumeros();
                            seleccion.guardarNumerosArchivo();
                            goto menu;
                        case "4":
                            Insercion insercion = new Insercion();
                            insercion.CargarNumeros();
                            insercion.ordenarNumeros();
                            Console.WriteLine("Los numeros ordenados por el metodo de Inserción quedan así: \n");
                            insercion.mostrarNumeros();
                            insercion.guardarNumerosArchivo();
                            goto menu;
                        case "5":
                            Console.WriteLine("Hasta la proxima");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("se ingreso una opcion invalida, intente de nuevo");
                            Console.ReadKey();
                            Console.Clear();
                            goto menu;
                    }

                }
                else
                {
                    Console.WriteLine("la opcion tiene que ser un valor numerico entre 1 y 5 o no se podra ejecutar el programa");
                    Console.ReadKey();
                    Console.Clear();
                    goto menu;
                }
            } catch (Exception) // en caso de que no se pueda pasar el valor que ingresa el usuario a int, aparte el mismo visual sugirio que usara catch
            {
                Console.WriteLine("la opcion tiene que ser un valor numerico entre 1 y 5 o no se podra ejecutar el programa");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
           

        }
    }
}
