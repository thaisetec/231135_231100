using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231135_231100
{


   
    
        internal class Program
        {
            public static double saldo = 0;

        static void operacao()
        {
            Console.WriteLine("Selecione a ação que você deseja efetuar: 1(Depósito) 2(Saque) 3(Pagamento) 4(Saldo)");
            int Operacao = int.Parse(Console.ReadLine());

            switch (Operacao)
            {
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
                case 1:
                    deposito();

                    break;
                case 2:
                    saque();
                    break;
                case 3:
                    pagamento();
                    break;
                case 4:
                    consultar();
                    break;

            }

        }
        static void pagamento()
        {
            Console.WriteLine("digite o valor do Pagamento a ser realizado: ");
            double pag = double.Parse(Console.ReadLine());

            if (saldo >= pag)
            {
                saldo -= pag;
                Console.WriteLine("Foi realizado um pagamento de R$" + pag +
          " , seu saldo atual é de R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }
        }
        static void deposito()

            {
                Console.WriteLine("digite o Valor que deseja Depositar em sua conta: ");
                double deposito = double.Parse(Console.ReadLine());

                saldo += deposito;

                Console.WriteLine("Foi realizado um depósito de R$" + deposito +
                    " , seu saldo atual é de R$ " + saldo);
            }
            static void saque()
            {
                Console.WriteLine("digite o valor do saque a ser realizado: ");
                double saque = double.Parse(Console.ReadLine());

                if (saldo >= saque)
                {
                    saldo -= saque;
                    Console.WriteLine("Foi realizado um saque de R$" + saque +
              " , seu saldo atual é de R$ " + saldo);
                }
                else
                {
                    Console.WriteLine("Saldo Insuficiente.");
                }

            }
            static void consultar()
            {
                Console.WriteLine("Seu saldo Atual é de R$ " + saldo);
            }
            static void Main(string[] args)
            {
            string resp;

                
                {
                operacao();
                Console.WriteLine("Deseja continuar? (S/N)");
                resp = Console.ReadLine().ToUpper();
                while (resp == "S")
                    Console.Clear();
                }

                Console.WriteLine("Até logo!");

                Console.ReadKey();
            }
        }
    
}
