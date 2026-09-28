using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_semana7
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres=new string[max];
        static double[] notas = new double[max];
        static int contador = 0;
        static public void Título() 
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Sistemas de notas");
            Console.WriteLine("*******************************");
        }
        static public void registrar_estudiante() 
        {
            Console.WriteLine("Registro de estudiante nuevo: ");
            if (contador >= max) 
            {
                Console.WriteLine("Llegamos a la capacidad máxima");
                return;
            }
            Console.WriteLine("Ingresar nombres:");
            string nombre=Console.ReadLine();
            double nota;
            while (true) 
            {
                Console.WriteLine("Ingresar nota: ");
                nota=double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 20) 
                {
                    break;
                }
                Console.WriteLine("Error: La nota debe ser [0-20]: ");
            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
        }
        static public void mostrar()
        {
            Console.WriteLine("******Listado de Estudiantes******");
            if (contador == 0) 
            {
                Console.WriteLine("No hay datos por mostrar");
                return;
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine((i + 1) + ".-" + nombres[i] + "-Nota:"+notas[i]);


            }
        }
        static void Main(string[] args)
        {
            Título();
            int opc = 0;
            while (opc != 6) 
            {
                Console.WriteLine("******MENÚ PRINCIPAL******");
                Console.WriteLine("[1]Registar estudiante");
                Console.WriteLine("[2]Buscar estudiantes");
                Console.WriteLine("[3]Modificar nota");
                Console.WriteLine("[4]Mostrar Lista sin ordenar");
                Console.WriteLine("[5]Mostrar reprote ordenado por burbuja");
                Console.WriteLine("[6]Salir");
                Console.WriteLine("Ingresar opcion: ");
                if(opc<1 || opc > 6) 
                {
                    Console.WriteLine("Error, opcion fuera de rango[1-6]:");
                    continue;
                }
                switch (opc) 
                {
                    case 1:
                        registrar_estudiante();break;
                    case 2:
                        //buscar_estudiante(); break;
                    case 3:
                        //modificar_nota(); break;
                    case 4:
                        mostrar();
                        break;
                    case 5:
                        //burbuja();
                        break;
                    case 6:
                        Console.WriteLine("Gracias por usar el sistema");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta...!!!");
                        break ;
                }

            }
        }
    }
}
