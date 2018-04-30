using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio6
    {
        public exercicio6()
        {
            Console.WriteLine("dijite um numero");
            int num = Convert.ToInt32(Console.ReadLine());
            string numero = string.Empty;
            Random rndNumero = new Random();
            numero = rndNumero.Next().ToString();
            int[] vetor = new Int32[10];
            int aux = 0;
            int soma = 0;
            int media = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < vetor.Length; i++)
                soma = soma + vetor[i];
            for (int i = 0; i < vetor.Length; i++)
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine("numero par ");
                }
                else
                {
                    Console.WriteLine("numero inpar ");
                }
            for (int i = 0; i < vetor.Length; i++)
                if (vetor[i] > 0)
                {
                    Console.WriteLine("numero pocitivo");
                }
            for (int i = 0; i < vetor.Length; i++)
                if (vetor[i] < 0)
                {
                    Console.WriteLine("numeo negativo ");
                }
            for (int i = 0; i < vetor.Length; i++)
                if (vetor[i] == 0)
                {
                    Console.WriteLine("numero neutro");
                }

            media = soma / vetor.Length;
            Console.WriteLine("media " + media);
        }
    }
}


