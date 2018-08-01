using System;

namespace Aula3107_console
{
    class Program
    {
        private static int resp;
        private static string op;


        public static int Id1 { get; set; }
        public static int Id2 { get; set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!!");
           

            Console.WriteLine("Digite o primeiro número:");
            Id1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            Id2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação:");
            op = Console.ReadLine();


            switch (op)
            {
                case "+" :
                    {
                        //do this
                        Somar(Id1, Id2);
                        break;
                    }

                case "-" :
                    {
                        //do this
                        Subtrair(Id1, Id2);
                        break;
                    }

                case "*" :
                    {
                        //do this
                        Multiplicar(Id1, Id2);
                        break;
                    }

                case "/" :
                    {
                        //do this
                        Dividir(Id1, Id2);
                        break;
                    }
                default:
                    break;
            }
            



            Console.ReadKey();
        }

        static void Somar(int num1, int num2)
        {
            resp = num1 + num2;

            Console.WriteLine("O resultado da soma é : "  + resp);
        }

        static void Subtrair(int num1, int num2)
        {
            resp = num1 - num2;

            Console.WriteLine("O resultado da subtração é : " + resp);
        }

        static void Multiplicar(int num1, int num2)
        {
            resp = num1 * num2;

            Console.WriteLine("O resultado da multiplicação é : " + resp);
        }

        static void Dividir(int num1, int num2)
        {
            resp = num1 / num2;

            Console.WriteLine("O resultado da divisão é : " + resp);
        }
    }
}
