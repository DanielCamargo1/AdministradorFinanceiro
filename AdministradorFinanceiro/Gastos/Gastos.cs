using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorFinanceiro.Gastos;

internal class Gastos
{
    public int Salario { get; }
    public int Dizimo { get; }
    public int Advogado { get; }
    public int Dentista { get; }

    public static void CalculoFinanceiro(int Salario)
    {
        int CalculoDizimo = Salario/10;
        int ValorAdvogado = 400;
        int Dentista = 100;
        int final = Salario - CalculoDizimo - Dentista - ValorAdvogado;
        Console.WriteLine("Carregando gastos fixos... ");
        Thread.Sleep(3000);
        Console.WriteLine($"Os gastos fixos são:\nDentista:R${Dentista}\nAdvogado:R${ValorAdvogado}\nDizimo:R${CalculoDizimo}");
        Console.WriteLine($"\nO valor final será: R${final}");
        Thread.Sleep(3000);
        Console.WriteLine("\nQuanto pretende guardar? :");
        int ValorGuardado = int.Parse(Console.ReadLine());
        Thread.Sleep(3000);
        Console.WriteLine($"\nSobrou: {final - ValorGuardado}");

        Console.WriteLine("Possui mais gastos [S/N]?");
        string resposta = Console.ReadLine();
        if (resposta == "S" || resposta == "s")
        {
            Console.Clear();
            Console.WriteLine("Qual o valor?:");
            int ValorAMais = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nSobrou: {final - ValorGuardado - ValorAMais}");
            Console.WriteLine("Possui mais gastos [S/N]?");
            string respostaD = Console.ReadLine();
            while(resposta != "n"|| resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("Qual o valor?:");
                int ValorAMaisD = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nSobrou: {final - ValorGuardado - ValorAMaisD}");
                Console.WriteLine("Possui mais gastos [S/N]?");
                string respostaT = Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Até mais!");
        }

    }
}
