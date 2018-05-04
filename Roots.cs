using System;

namespace Roots
{
    class Program
    {
        static void CalculateRoots(double a, double b, double c)
        {
            double delta, x, x2;
            delta = (Math.Pow(b, 2) - 4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("\nNão existe raiz real!");
            }
            if (delta == 0)
            {
                x = (-b / 2 * a);
                Console.WriteLine("\nExiste apenas uma raiz real: " + x);
            }
            if (delta > 0)
            {
                x = ((-b + Math.Sqrt(delta)) / 2 * a);
                x2 = ((-b - Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine("\nExistem duas raizes reais {0} e {1}.", x, x2);
            }
        }

        static void Main(string[] args)
        {
            double a, b, c;
            string resposta = "";
            Console.WriteLine("***CÁLCULO DE RAÍZES***\n");
            do
            {
                do
                {
                    Console.WriteLine("Informe o coeficiente a.");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o coeficiente b.");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o coeficiente c.");
                    c = double.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("O coeficiente 'a' deve ser diferente de zero!\n");
                        Console.WriteLine("Digite - sim - para voltar ao cálculo de raizes ou pressione qualquer tecla para sair do programa.");
                        resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.Clear();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                } while (a == 0);
                CalculateRoots(a, b, c);
                if (a > 0)
                {
                    Console.WriteLine("A parábola tem concavidade para cima!\n");
                }
                else
                {
                    Console.WriteLine("A parábola tem concavidade para baixo!\n");
                }
                Console.WriteLine("Digite - sim - para realizar novo cálculo de raizes ou pressione qualquer tecla para sair do programa.");
                resposta = Console.ReadLine();
                if (resposta == "sim")
                {
                    Console.Clear();
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