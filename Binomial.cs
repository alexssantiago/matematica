using System;

namespace BinomioDeNewton
{
    class Program
    {
        static int Fatorial(int num)
        {
            int fatorial = 1;
            if (num == 0)
            {
                fatorial *= 1;
            }
            for (int n = 1; n <= num; n++)
            {
                fatorial *= n;
            }
            return fatorial;
        }

        static int CoeficienteBinomial(int n, int p)
        {
            int coeficiente;
            p = 0;
            coeficiente = (Fatorial(n) / (Fatorial(p) * Fatorial(n - p)));
            return coeficiente;
        }

        static double CalculaBinomio(double a, double b, int n)
        {
            double calculo, parcela;
            int coeficiente, N, p = 0;
            N = n;
            coeficiente = CoeficienteBinomial(n, p);
            parcela = (Math.Pow(a, n) * Math.Pow(b, p));
            calculo = (coeficiente * parcela);
            for (int i = 0; p <= n; i++)
            {
                p++;
                coeficiente = (Fatorial(n) / (Fatorial(p) * Fatorial(n - p)));
                N--;
                parcela = (Math.Pow(a, N) * Math.Pow(b, p));
                calculo += (coeficiente * parcela);
            }
            return calculo;
        }

        static void Main(string[] args)
        {
            int n;
            double a, b;
            double binomio;
            string resposta = "";
            Console.WriteLine("****CALCULADORA DE BINÔMIO DE NEWTON****\n");
            do
            {
                Console.Write("Informe o valor de 'a': ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de 'b': ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor do expoente 'n': ");
                n = int.Parse(Console.ReadLine());
                binomio = CalculaBinomio(a, b, n);
                Console.WriteLine("\nBinômio de Newton = {0}.", binomio);
                Console.WriteLine("\nDigite - sim - para realizar nova conversão ou pressione qualquer tecla para sair do programa.");
                resposta = Console.ReadLine();
                if (resposta == "sim")
                {
                    Console.Clear();
                    binomio = 0;
                }
                else
                {
                    Environment.Exit(0);
                }
            } while (resposta == "sim");
            Console.ReadKey();
        }
    }
}
//alexssantiago