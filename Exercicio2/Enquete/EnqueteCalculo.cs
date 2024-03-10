using System;

namespace Enquete
{
    public class EnqueteCalculo
    {
        public static readonly string[] sistemas = { "Windows Server", "Unix", "Linux", "Netware", "Mac OS", "Outro" };
        public static readonly int[] votos = new int[sistemas.Length];
        public static readonly double[] porcentagens = new double[sistemas.Length];


        public static void CalculoDasPorcentagens()
        {
            int totalVotos = votos.Sum();
            for (int i = 0; i < votos.Length; i++)
            {
                double porcentagem = (double)votos[i] / totalVotos * 100;
                porcentagens[i] = Math.Round(porcentagem, 1);
            }
        }

        public static void ApresentacaoDosResultados()
        {
            Console.WriteLine("Sistema Operacional Votos   %");
            Console.WriteLine("------------------- ----- -----");
            for (int i = 0; i < sistemas.Length; i++)
            {
                Console.WriteLine("{0,-18} {1,5} {2,6:F1}%", sistemas[i], votos[i], porcentagens[i]);
            }
            Console.WriteLine("------------------- ----- -----");

            int vencedor = Array.IndexOf(votos, votos.Max());
            Console.WriteLine("O Sistema Operacional mais votado foi o {0}, com {1} votos, correspondendo a {2}% dos votos.",
            sistemas[vencedor], votos[vencedor], porcentagens[vencedor]);
        }

    }
}
