using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CursoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // esto es un comentario

            Console.WriteLine("Hola mundo");


            /*para concatenar una variable y una cadena o dos
            cadenas se usa el operar +*/

            /*byte variable = 50;
            string cadena;

            Console.WriteLine("el valor de variabnle es " + variable);
            Console.WriteLine("escriba una frase");
            cadena= Console.ReadLine();
            Console.WriteLine("el valor de cadena es " + cadena);*/

            /*operadores de asignacion

             += -= *= /=

            escapar cadenas
             \  \n  \t  @  +  $ {}  */

            /*Console.WriteLine("esto es una practica de cadenas\"¿lo ves?\"");

            Console.WriteLine("otra prueba de \"escape de cadena\"");

            Console.WriteLine("ahora vamos con \nsalto de linea \npara seguir la practica");

            Console.WriteLine("ahora vamos con \ttabulacion \tpara seguir la practica");

            Console.WriteLine(@"esta es una cadena verbatim 
que me deja escrbir
y saltar comoquiera y meter simolos *(*&^%##) de lo que sea");

            string cadena1 = "esta cadena";

            string cadena2 = "es una mierda";
            int variable = 30;

            Console.WriteLine("ahora vamos a concatenar cadena 1 y 2");

            Console.WriteLine(cadena1+" "+cadena2);

            Console.WriteLine(cadena1 + cadena2);

            Console.WriteLine(cadena1+variable+cadena2);

            Console.WriteLine($"{cadena2} todo esto vale");

            Console.WriteLine($"tu culo {cadena2}");

            
            Console.ReadLine();*/


            /* CLASE 6 
             los operadores aritmeticos son + - * / 
            /y para operaciones matematicas diversas se usa el objeto Math*/

            /*double num1, num2;

            Console.WriteLine("Ingrese el primer numero");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la pótencia a elevar");

            num2 = Convert.ToDouble(Console.ReadLine());

            double pot = Math.Pow(num1, num2);

            Console.WriteLine("el resuktado es " + pot);

            Console.ReadKey();



            Console.WriteLine("Ingrese el numero a sacar la raiz cuadrada");

            num1 = Convert.ToDouble(Console.ReadLine());

            double raiz = Math.Sqrt(num1);

            Console.WriteLine("la raiz cuadrada de " + num1 + " es " + raiz);

            Console.WriteLine($"la raiz cuadrada de {num1} es {raiz}");

            Console.ReadKey();*/


            /*CLASE 7
             Operadores logicos y de igualdad 
              Los de igualdad son < menor que, > mayor que, == igual que 
              >= mayo o igual que, <= menor o igual que y != difente a 
              los logico son && AND y || OR  

            double peso;
            byte edad;

            Console.WriteLine("Ingresa tu peso");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa tu edad");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();

            if (peso >= 80 && edad <= 20)
            {
                Console.WriteLine("Estas gordo joe"); 
            } */

            /* CLASE 8 
             Estructuta de control de flujo de datos
            if, else if, else, switch, case, break, default */

           /* int peso;
            int edad;
            string status;

            Console.WriteLine("Ingresa tu peso");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿tu status es pobre o rico?");
            status = Convert.ToString(Console.ReadLine());
            Console.Clear();

            //estructura if
            if (edad <= 18 && peso >= 85)
            {
                if (status == "pobre")
                {
                    Console.WriteLine("Estas jodido");
                }
                else
                {
                    Console.WriteLine("Hay esperanza");
                }


                Console.WriteLine("Tienes sobrepeso");
            }
            else if (edad >= 18 && peso <= 70)
            {
                Console.WriteLine("Estas en linea");
            }
            else
            {
                Console.WriteLine("estas de cementerio");
            }

            //Estructuta switch

            switch (peso)
            {
                case 50:
                    Console.WriteLine("estas delgado");
                    break;
                case 70:
                    Console.WriteLine("Tu peso es correcto");
                    break;
                case 90:
                    Console.WriteLine("Tienes sobrepeso");
                    break;
                default:
                    Console.WriteLine("Estas muy jodido");
                    break;
            }*/


            int a = Console.In.Peek();

            
            if (a == 'x')
            {
                Console.WriteLine("has adivinado la letra " + (char)a);
            }
            else
            {
                Console.WriteLine("Dale de nuevo");
            }


            Console.WriteLine((char)a);

            Console.WriteLine(Convert.ToChar(a));

            /* CLASE 9 */

            string nombre = "Orion Ra ";

            for (int i = 0; i <= 3; i++)
            {
                foreach (char letra in nombre)
                {

                    Thread.Sleep(500);
                    Console.Write(" " + letra + " ");
                }
                Console.Clear();
            }


            for (char i = 'a'; i <= 'z'; i++)
            {
                Thread.Sleep(500);
                Console.Write(" " + i + " ");
            }

            Console.WriteLine();


            string[] emp = new string[5];

            emp[0] = "pedro";
            emp[1] = "juan";
            emp[2] = "maria";
            emp[3] = "daniela";
            emp[4] = "Orion";

            foreach (string reg in emp)
            {
                Thread.Sleep(500);
                Console.WriteLine(reg);

            }

            int[,] num = new int[3, 3];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {

                    Console.WriteLine("dame un numero ");
                    num[fila,col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();


            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {

                    Thread.Sleep(500);
                    Console.Write(" " + num[fila, col]);
                }
                Console.WriteLine();

            }



            Console.ReadKey();











        }
    }
}
