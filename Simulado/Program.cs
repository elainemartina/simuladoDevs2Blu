using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    internal class Program
    {
        static void Main(string[] args) // Falta terminar
        {
            List<int> numeros = new List<int>(3);
            List<int> numerosOrdenados = new List<int>(3);

            Console.WriteLine("Digite uma lista de 3 números");
            for (int i = 0; i < 3; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }
            /*
            for (int i = 0; i < numeros.Count; i++)
            {
                numerosOrdenados.Add(numeros[i]);
                if (numeros[i] < numerosOrdenados[0])
                {
                    numerosOrdenados[0] = numeros[i];
                    numerosOrdenados[i] = numeros[0];
                }
                else
                {
                    numerosOrdenados[i] = numeros[i];
                }
            }*/

            for (int z = 0; z < numeros.Count; z++)
            {
                if (z == 0)
                {
                    numerosOrdenados[0] = numeros[0];
                }
                foreach (var i in numeros)
                {
                    if (numeros[i] < numerosOrdenados[z])
                    {
                        numerosOrdenados[z] = numeros[i];
                    }
                }
            }

            Console.WriteLine("Lista ordenada:");
            for (int i = 0; i < numerosOrdenados.Count; i++)
            {
                Console.Write(numerosOrdenados[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
