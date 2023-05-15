using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string[] palavras = { "uva", "manga", "laranja", "morango", "maça", "abacaxi", "banana", "acerola", "manga", "goiaba" };

            Random random = new Random();
            string palavra = palavras[random.Next(palavras.Length)];
            char[] letrasAdivinhadas = new char[palavra.Length];

            for (int i = 0; i < letrasAdivinhadas.Length; i++)
            {
                letrasAdivinhadas[i] = '_';
            }

            bool acabou = false;
            int tentativasRestantes = 10;

            Console.WriteLine("Dica: É uma fruta!");
            while (!acabou)
            {
                Console.WriteLine(letrasAdivinhadas);
                Console.WriteLine("Tentativas restantes: " + tentativasRestantes);

                Console.Write("\nDigite uma letra: ");
                char letra = char.Parse(Console.ReadLine());

                bool achouLetra = false;
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        letrasAdivinhadas[i] = letra;
                        achouLetra = true;
                    }
                }

                if (!achouLetra)
                {
                    tentativasRestantes--;
                    Console.WriteLine("A letra " + letra + " não está na palavra.");

                    if (tentativasRestantes == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Você não tem mais tentativas.");
                        Console.WriteLine("A palavra era: " + palavra);

                        acabou = true;
                    }
                }

                if (new string(letrasAdivinhadas) == palavra)
                {
                    Console.Clear();
                    Console.WriteLine("Parabéns! Você acertou a palavra: " + palavra);

                    acabou = true;
                }
            }

            Console.ReadKey();
        }
    }
}
