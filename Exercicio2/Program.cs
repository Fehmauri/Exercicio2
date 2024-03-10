using System;
using Enquete;

namespace Exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int voto;
            do
            {
                Console.Clear();
                string mensagem = String.Format(
@"Qual o melhor Sistema Operacional para uso em servidores?

As possíveis respostas são:

1- Windows Server
2- Unix
3- Linux
4- Netware
5- Mac OS
6- Outro

Digite o número do sistema operacional (1-6) ou 0 para sair: ");

                Console.WriteLine(mensagem);
                voto = int.Parse(Console.ReadLine());

                if (voto < 0 || voto > 6)
                {
                    Console.WriteLine("Voto inválido! Digite um número entre 1 e 6 ou 0 para sair.");
                    voto = int.Parse(Console.ReadLine());
                }
                if (voto > 0)
                {
                    EnqueteCalculo.votos[voto - 1]++;
                }


            } while (voto != 0);
            Console.Clear();
            EnqueteCalculo.CalculoDasPorcentagens();
            EnqueteCalculo.ApresentacaoDosResultados();
        }
    }
}