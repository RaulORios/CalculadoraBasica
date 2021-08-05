using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int n1;
            int n2;
            string escolha;

            Console.WriteLine("************************************************");
            Console.WriteLine("************       CALCULADORA      ************");
            Console.WriteLine("************************************************");

            Console.WriteLine("");

            Console.Write("Digite um numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Escolha a operação que deseja realizar");
            Console.WriteLine("[A] - SOMA");
            Console.WriteLine("[B] - SUBTRAÇÃO");
            Console.WriteLine("[C] - MULTIPLICAÇÃO");
            Console.WriteLine("[D] - DIVISÃO");

            Console.WriteLine("");

            escolha = Console.ReadLine();

            Console.WriteLine("");

            #region Código IF ELSE            

            //if (escolha.Length == 1)
            //{
            //    if (escolha.ToUpper() == "A")
            //    {
            //        Console.WriteLine($"A soma dos dois numeros é : {n1 + n2}");
            //    }
            //    else if (escolha.ToUpper() == "B")
            //    {
            //        Console.WriteLine($"A subtração dos dois numeros é : { n1 - n2}");
            //    }
            //    else if (escolha.ToUpper() == "C")
            //    {
            //        Console.WriteLine($"A multiplicação dos dois numeros é : {n1 * n2}");
            //    }
            //    else if (escolha.ToUpper() == "D")
            //    {
            //        Console.WriteLine($"A divisão dos dois numeros é : {n1 / n2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("FATAL ERROR: Opção inválida");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("FATAL ERROR: Animal era para digitar 1 letra!! ");
            //}

            #endregion

            if (escolha.Length == 1)
            {
                switch (escolha.ToUpper())
                {

                    case "A":
                        Console.WriteLine($"A soma dos dois numeros é : {n1 + n2}");
                        break;

                    case "B":
                        Console.WriteLine($"A subtração dos dois numeros é : { n1 - n2}");
                        break;

                    case "C":
                        Console.WriteLine($"A multiplicação dos dois numeros é : {n1 * n2}");
                        break;

                    case "D":
                        Console.WriteLine($"A divisão dos dois numeros é : {n1 / n2}");
                        break;

                    default:
                        Console.WriteLine("FATAL ERROR: Opção inválida!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("FATAL ERROR: Digitar 1 letra!! ");
            }

            Console.WriteLine("");

            Console.WriteLine("Digite uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
