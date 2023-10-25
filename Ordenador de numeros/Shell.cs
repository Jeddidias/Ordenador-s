using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ordenador_de_numeros
{
    class Shell
    {
        private int[] Numero; // atributo de la clase para poder usarlo de manera global en todos los metodos de la clase

        public Shell() // metodo constructor para ejecutar
        {
            Console.Clear();
            Console.WriteLine("METODO DE ORDENAMIENTO SHELL \n\n"); // para que el usuario sepa en que metodo está
        }
        public void CargarNumeros()
        {
            Console.WriteLine("ingrese la cantidad de numeros para ordenar");

            try
            {
                int numeroElementos = int.Parse(Console.ReadLine());
                if (numeroElementos > 0)
                {
                    this.Numero = new int[numeroElementos];
                    int valor = 0;

                    for (int i = 0; i < this.Numero.Length; i++)
                    {
                        Console.Write("Ingrese el valor " + (i + 1) + ": ");
                        valor = int.Parse(Console.ReadLine());
                        this.Numero[i] = valor;
                        valor = 0;
                    }
                    Console.WriteLine("Para ver los números ingresados presione 1, de lo contrario presione 2");
                    string opcion = Console.ReadLine();

                    if (opcion.Equals("1"))
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
        public void ordenarNumeros() // el metodo de ordenamiento indicado, en este caso Shell, para encontrar los metodos de ordenamiento utilice un foro en internet "jfprogramacionnet.blogspot.com"
        {
            int salto = 0;
            int a = 0;
            int auxi = 0;
            int e = 0;
            salto = this.Numero.Length / 2;
            while (salto > 0)

            {
                a = 1;
                while (a != 0)
                {
                    a = 0;
                    e = 1;
                    while (e <= (this.Numero.Length - salto))
                    {
                        if (this.Numero[e - 1] > this.Numero[(e - 1) + salto])
                        {
                            auxi = this.Numero[(e - 1) + salto];
                            this.Numero[(e - 1) + salto] = this.Numero[e - 1];
                            this.Numero[(e - 1)] = auxi;
                            a = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
            Console.WriteLine("Los números fueron ordenados correctamente, Enter para continuar");
            Console.ReadLine();
        }
        public void guardarNumerosArchivo()
        {
            string nombreArchivo = "Burbuja.txt";
            StreamWriter writer = File.AppendText(nombreArchivo);// esto me permite escribir en el archivo que se cree, es parte de System.IO por eso lo referencio arriba

            for (int i = 0; i < this.Numero.Length; i++)
            {
                writer.WriteLine(this.Numero[i] + " ");
            }
            writer.Close();
            Console.WriteLine("Los números ordenados por el metodo Shell fueron guardados correctamente en el archivo");
            Console.ReadKey();

        }
    }
}

