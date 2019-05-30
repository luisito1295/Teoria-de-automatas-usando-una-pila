using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace TDAP
{
    class Program
    {
        static void Main(string[] args)
        {
            string letras = string.Empty;
            //int i;
            bool salir = false;
            string palabra;
            Stack<String> miPila = new Stack<String>();
            String Aceptacion = "q1", A = "a";
            String C_Aceptada = "q2";
            String Palabra = "";
            String V_pila = "Z";
            miPila.Push("Z");

            Console.Write("Ingresar una cadena : " + " ");
            letras = Console.ReadLine();

            string[] arreglo = letras.ToUpper().Trim().Split(' ');
            int comparando = 1;

            String E_Aceptada = "p2";
            foreach (String aux in arreglo)
            for (byte i = 0; i <= aux.Length; i++)
            { 
                Console.WriteLine(aux.Substring(i, 1) + "");
                //char letra = letras.charAt(i,1);
                String Comparacion = aux.Substring(i, 1);
                    
                if (miPila==null)//compaarar que la pila esta vacio o no
                {
                    Aceptacion = "q1";
                    Console.WriteLine("Pila vacia, no se puede seguir");

                }
                else
                {

                    switch (Aceptacion)
                    {
                        case "q1"://q1
                            if (comparando.Equals(A))
                            {
                                switch (miPila.Peek())
                                {
                                    case "A":
                                        miPila.Push("A");
                                        Console.WriteLine("Se añade " + "" + miPila.Peek() + " " + " a la pila");
                                        Aceptacion = "q1";
                                        break;
                                    case "B":
                                        Console.WriteLine("Se quita " + "" + miPila.Peek() + " " + " de la pila");
                                        miPila.Pop();
                                        Aceptacion = "q1";
                                        break;
                                    case "Z":
                                        miPila.Push("A");
                                        Console.WriteLine("Se añade " + "" + miPila.Peek() + " " + " a la pila");
                                        Aceptacion = "q1";
                                        break;
                                    default:
                                        Aceptacion = "q1";
                                        break;
                                }
                            }
                            else
                            {
                                //para saber si ya termino la pila
                                switch (miPila.Peek())
                                {
                                    case "A":
                                        Console.WriteLine("Se quita " + "" + miPila.Peek() + " " + " de la pila");
                                        miPila.Pop();
                                        Aceptacion = "q1";
                                        break;
                                    case "B":
                                        miPila.Push("B");
                                        Console.WriteLine("Se añade " + "" + miPila.Peek() + " " + " a la pila");
                                        Aceptacion = "q1";
                                        break;
                                    case "Z":
                                        miPila.Push("B");
                                        Console.WriteLine("Se añade " + "" + miPila.Peek() + " " + " a la pila");
                                        Aceptacion = "q1";
                                        break;
                                    default:
                                        Aceptacion = "q1";
                                        break;

                                }
                            }
                            break;
                            switch (miPila.Peek())
                            {
                                case "Z":
                                    Console.WriteLine("la pila se queda con  " + "" + miPila.Peek());
                                    Aceptacion = "q2";
                                    break;
                                default:
                                    Aceptacion = "q1";
                                    break;
                            }
                            if (Aceptacion.Equals(A))
                            {
                                Console.WriteLine("Estado final:" + "" + Aceptacion);
                                Console.WriteLine("Cadena aceptada");
                            }
                            else
                            {
                                Console.WriteLine("Estado final:" + "" + Aceptacion);
                                Console.WriteLine("Cadena no aceptada");
                            }

                    }
                }
            }
        }
    }
}
