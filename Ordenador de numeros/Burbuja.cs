using System;
using System.Collections.Generic;
using System.IO; // para poder usar streamwirter y generar ese arcivho de texto de salida
using System.Text;

namespace Ordenador_de_numeros
{
    class Burbuja
    {
        private int[] Numero; // atributo de la clase para poder usarlo de manera global en todos los metodos de la clase

        public Burbuja() // metodo constructor para ejecutar
        {
            Console.Clear();
            Console.WriteLine("METODO DE ORDENAMIENTO BURBUJA \n\n"); // para que el usuario sepa en que metodo está
        }

        public void CargarNumeros()
        {
            Console.WriteLine("ingrese la cantidad de numeros para ordenar");

            try // en caso de no ingresar un numero valido
            {
                int numeroElementos = int.Parse(Console.ReadLine());
                if (numeroElementos > 0)// para que el numero de elementos sea mayor que cero siempre
                {
                    this.Numero = new int[numeroElementos];//para instanciar el numero de elementos que van a quedar dentro de ese "numero"
                    int valor = 0;

                    for (int i=0; i < this.Numero.Length; i++) // ciclo que se recorrera en cada una de la cantidad de elementos ingresada por el usuario
                    {
                        Console.Write("Ingrese el valor " + (i + 1) + ": ");
                        valor = int.Parse(Console.ReadLine());
                        this.Numero[i] = valor;
                        valor = 0;
                    }
                    Console.WriteLine("Para ver los números ingresados presione 1, de lo contrario presione 2");
                    string opcion = Console.ReadLine();

                    if (opcion.Equals ("1"))
                    {
                        this.mostrarNumeros();
                    }
                }
                else
                {
                    Console.WriteLine("se ingreso una cantidad no valida, no se puede continuar el programa");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Se ingreso una cantidad invalida, no se puede continuar el programa");
                Console.ReadKey();
            }
        }
        public void mostrarNumeros()
        {
            for (int i = 0; i < this.Numero.Length; i++) // para que se haga por cada una de las posiciones
            {
                Console.WriteLine("Numero en la posición " + (i + 1) + ": " + this.Numero[i].ToString());// mostrar las posiciones del "numero" y lo paso a string para que quede en console writeline
            }
            Console.WriteLine("Enter para continuar");
            Console.ReadKey();
        }
        public void ordenarNumeros() // el metodo de ordenamiento indicado, en este caso Burbuja, para encontrar los metodos de ordenamiento utilice un foro en internet "jfprogramacionnet.blogspot.com"
        {
            int t;
            for (int a = 1; a < this.Numero.Length; a++)
            {
                for (int b = this.Numero.Length - 1; b>= a; b--)
                {
                    if (this.Numero[b - 1] > this.Numero[b])
                    {
                        t = this.Numero[b - 1];
                        this.Numero[b - 1] = this.Numero[b];
                        this.Numero[b] = t;
                    }
                }
            } 
            Console.WriteLine("Los números fueron ordenados correctamente, Enter para continuar");
            Console.ReadLine();
        }public void guardarNumerosArchivo()
        {
            string nombreArchivo = "Burbuja.txt";
            StreamWriter writer = File.AppendText(nombreArchivo);// esto me permite escribir en el archivo que se cree, es parte de System.IO por eso lo referencio arriba

            for (int i = 0; i < this.Numero.Length; i++)
            {
                writer.WriteLine(this.Numero[i] + " ");
            }
            writer.Close();
            Console.WriteLine("Los números ordenados por el metodo Burbuja fueron guardados correctamente en el archivo");
            Console.ReadKey();

        }
    } 
}
