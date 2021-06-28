using System;
using System.Collections.Generic;

namespace Arbol12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: Miguel Tomillo");//var que indica la raiz

            var raiz = new Nodo
            {
                Valor = "*",// valores agregados medios
                Valor2 = "/",
                Valor3="+",
                Hijos =
                {
                    new Nodo
                     {
                         Valor="+",//simbologia
                         Valor2="+",
                         Valor3="/",
                         Hijos =
                {
                    new Nodo
                     {
                         Valor="8",//numeros primarios
                         Valor2="7",
                         Valor3="5"

                },
                 new Nodo
                     {
                         Valor="5",
                         Valor2="4",
                         Valor3="4"

                }
                }

                },
                 new Nodo
                     {
                         Valor="-",
                         Valor2="-",
                         Valor3="/",
                         Hijos =
                {
                    new Nodo
                     {
                         Valor="7",
                         Valor2="9",
                         Valor3="8"

                },
                 new Nodo
                     {
                         Valor="4",
                         Valor2="2",
                         Valor3="2"
                           }
                       },
                   }
                }
            };
            //Resultado esperado
            //(8+5)*(7-4)=39 notacion infija
            // * (+ 8 5) (- 7 4)=39 notacion prefija
            //(8 5 +) (7 4 -) *=39 notacion prefija
            //8+(5*7)-4=39

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            //consolas de cada arbol binario funcional
            //Console.WriteLine(manejadorArbol.ImrprimirArbolInfijo(raiz));
            //Console.WriteLine(manejadorArbol.ImrprimirArbolPrefijo(raiz));
            //Console.WriteLine(manejadorArbol.ImrprimirArbolPostfijo(raiz));
            // Console.WriteLine(manejadorArbol.ImpresionDivision(raiz));
            //Console.WriteLine(manejadorArbol.ImpresionSumaBin(raiz));

            //consola principal para imprimir todos los arboles
            Console.WriteLine("Arbol binario trabajo numero 2");
            Console.WriteLine("Operacion Infijo");
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Infijo));//1
            Console.WriteLine("Operacion Prefijo");
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Prefijo));//2
            Console.WriteLine("Operacion Postfijo");
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Postfijo));//3
            Console.WriteLine("Divison de numeros");
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Num));//4
             Console.WriteLine("Suma de numeros dividos");
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Bin));//5

            //Imrpime las hojas totales que tiene
            Console.WriteLine("Numero de hojas totales que tiene: " + manejadorArbol.HojasNumero(raiz));//1
            //Imprime los nodos que tiene
            Console.WriteLine("Numero de nodos que tiene: "+ manejadorArbol.NumeroNodo(raiz));//2
            //Imrpime el numero de niveles que tiene
            Console.WriteLine("Numero de niveles que tiene: "+ manejadorArbol.NivelesNumero(raiz,0));//3
            //ortogonalidad
            //Sumar (8,4)
            //Restar (8,4)
            //Multiplicar(8,4)
            //Calcular(8,4, Tipo.Suma)
        }
    }
}
