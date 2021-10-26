using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Program
    {
       
        static void Main()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------BIENVENIDO-------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------\n");

            int[] lista = new int[1];
            MenuA();

            void MenuA()
            {
                Console.WriteLine("Por favor ingresa una opcion para poder continuar: ");
                Console.Write("A. Iniciar programa ----- B. Salir :C\n");
                Console.WriteLine("Opcion: ");
                string opcionA;
                opcionA = Console.ReadLine();
                if (opcionA == "A")
                {
                    GenerarNumeros();
                }
                else if (opcionA == "B")
                {
                    Console.Write("Me voy a salir, Adios!!");
                }
                else if (opcionA != "A" && opcionA != "B")
                {
                    Console.Write("Lo siento, pero tienes que ingresar un valor valido, de lo contrario no entras >:v \n");
                    MenuA();
                }
            }

            void MenuB()
            {
                string opcionB;
                Console.WriteLine("-----Deseas Leer o Ordenar el archivo?-----\n");
                Console.Write("-----------------");
                Console.Write(" A. Leer, B. Ordenar C. Regresar");
                Console.Write("-----------------\n");
                Console.Write(" Opcion-->  ");
                opcionB = Console.ReadLine();
                if (opcionB == "A")
                {
                    LeerArchivo();
                }
                else if (opcionB == "B")
                {
                    Console.Write("----------Es hora de ordenar los datos UWU----------\n");
                    OrdenarLista(); //Cuadar el vector
                }
                else if (opcionB == "C")
                {
                    MenuA();
                }
                else if (opcionB != "B" && opcionB != "C")
                {
                    Console.Write("Porfavor Ingresa Una de las opciones >:v \n");
                    MenuB();
                }
            }
            MenuB();


            //Ordenar Lista--------------------------------------------
            void OrdenarLista()
            {
                int[] listaNumeros =  lista;
                //int ordenamiento = Convert.ToInt32(rutaCompleta);
                //ordenamiento = int.Parse(rutaCompleta);
                int n = 1;
                int i, j;
                int val, flag;

                //int[] numero = new int[lista]; //Vector, que alamcena los numeros Uwu
                //double listaSort = new double[lista] { };
                //double listaActual = convertirruta[i];
                Console.Write("\nEs hora de ordenar la lista con: --- Insertion Sort --- \n");
                Console.Write("Lista inicial: " + listaNumeros); //Esta parte no los esta cogiendo

                for (i = 1; i < n; i++)
                {
                    val = listaNumeros[i];
                    flag = 0;
                    for (j = i - 1; j >= 0 && flag != 1;)
                    {
                        if (val < listaNumeros[j])
                        {
                            listaNumeros[j + 1] = listaNumeros[j];
                            j--;
                            listaNumeros[j + 1] = val;
                        }
                        else flag = 1;
                    }
                }
                Console.Write("\nLista Ordenada: \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write(listaNumeros[i] + " \n" );
                    //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\USUARIO\Documents\SENA2021_Trimetre4\Hugo_Hernan\Tareas\proyecto1_Insertion_Sort\Ordenamiento\file\ListaOrdenada.txt"))
                    //{
                    //  foreach (string line in numero)
                    //{
                    //  if (!line.Contains("Segunda"))
                    //{
                    //  File.AppendAllText(@"C:\Users\USUARIO\Documents\SENA2021_Trimetre4\Hugo_Hernan\Tareas\proyecto1_Insertion_Sort\Ordenamiento\file\file.txt", numero + " Estos numeros fueron los que se eligieron" + Environment.NewLine);

                    //file.WriteLine(numero);
                    //}
                    //}
                    //}
                }

                MenuC();
            }

            //-------------------------------------------------------------------
            //Menu final Uwu
            void MenuC()
            {
                Console.Write("Desea Regresar? o ¿De desea salirse del programa?\n");
                Console.Write("R. Regresar o E. Salir\n");

                string opcion;
                opcion = Console.ReadLine();

                if (opcion == "R")
                {
                    MenuA();

                }
                else if (opcion == "E")
                {
                    Console.Write("Gracias por utilizarme Uwu!! Me voy ");
                }
                else if (opcion != "R" && opcion != "E")
                {
                    Console.Write("Porfavor, ingresa un valor valido >:)\n");
                    MenuC();
                }
            }
            //-----------------------------------------------------------------------------------------------
            //Leer Archivo UwU
            void LeerArchivo()
            {
                string rutaCompleta = @"C:\\Users\USUARIO\Documents\SENA2021_Trimetre4\Hugo_Hernan\Tareas\proyecto1_Insertion_Sort\Ordenamiento\file\file.txt";
                string line = "";
                using (StreamReader file = new StreamReader(rutaCompleta))
                {
                    while ((line = file.ReadLine()) != null) //Leer linea por linea
                    {
                        Console.Write(line + "\n");
                        Console.ReadLine();
                        MenuB();
                    }
                }
            }
            //--------------------------------------------------------------------------
            //Genera los Numeros AL Azar
            void GenerarNumeros()
            {
                int numeros;
                string cantidadN;
                int f;

                try
                {
                    Console.Write("cantidad de numeros:");// Solicitar HHHH numeros a generar po teclado.
                    cantidadN = Console.ReadLine();
                    numeros = int.Parse(cantidadN);

                    var random = new Random(numeros);

                    for (f = 1; f <= numeros; f++) // Generar esa cantidad de numeros entre:
                    {
                        var valores = random.Next(-1000, 999); // -1000 y 999, elegidos al azar.
                        Console.WriteLine("valor: " + valores + " Dato insertado con Exito!!\n");
#pragma warning disable CS1718 // Comparación hecha a la misma variable
                        if (valores == valores)
                        {
                            int listaNumeros = valores;
                            File.AppendAllText(@"C:\Users\USUARIO\Documents\SENA2021_Trimetre4\Hugo_Hernan\Tareas\proyecto1_Insertion_Sort\Ordenamiento\file\file.txt", listaNumeros + " Dato Elegido" + Environment.NewLine);

                            Stopwatch sw = new Stopwatch(); // Creación del Stopwatch
                            sw.Start(); // Iniciar la medición
                            lista.Append(listaNumeros);
                            
                            sw.Stop(); // Detener la medición.
                            Console.WriteLine("Tiempo pasado: {0}", sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));

                            // Se agregan al vector :)
                            //lista = new int[valores]; //Esta es la que manejo en las demas funciones Uw
                        }
                        else
                        {
                            Console.Write("Lo siento, pero no se pudieron insertar los datos :C");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No es un numero, ingresa un numero >:v/: ");
                    GenerarNumeros();
                }
            }
            Console.Read();
        }
    }
}