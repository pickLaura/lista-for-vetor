using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio4
    {
        public exercicio4()
        {

            Console.WriteLine("digite a quatidade de camisas ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            int camisasArmazenadas = 0, PP = 0, P = 0, M = 0, G = 0, GG = 0, XG = 0, XGG = 0;
            string[] tamalhos = new string[quantidade];
            for (int i = 0; i < tamalhos.Length; i++)
            {
                Console.WriteLine("PP , P , M , G  , GG , XG , XGG  ");
                tamalhos[i] = Console.ReadLine().ToLower();
            }
            for (int i = 0; i < tamalhos.Length; i++)
            {
                Console.WriteLine("tamanho " + tamalhos[i]);

            }

            for (int i = 0; i < tamalhos.Length; i++)
            {
                if (tamalhos[i] == "pp")
                {
                    Console.WriteLine("escolido PP ");

                    Console.WriteLine(tamalhos);
                    PP = PP + 1;

                }
                if (tamalhos[i] == "P")
                {

                    Console.WriteLine("escolido P ");

                    Console.WriteLine(tamalhos);
                    P = P + 1;
                }
                if (tamalhos[i] == "m")
                {
                    Console.WriteLine("escolido m ");

                    Console.WriteLine(tamalhos);
                    M = M+1;
                }
                if (tamalhos[i] == "g")
                {
                    Console.WriteLine("escolido g ");

                    Console.WriteLine(tamalhos);
                    G = G+1;
                }
                if (tamalhos[i] == "gg")
                {
                    Console.WriteLine("escolido gg ");

                    Console.WriteLine(tamalhos);
                    GG = G+1;
                }
                if (tamalhos[i] == "xg")
                {
                    Console.WriteLine("escolido xg");

                    Console.WriteLine(tamalhos);
                    XGG = G+1;
                }
                if (tamalhos[i] == "xgg")
                {
                    Console.WriteLine("escolido xgg ");

                    Console.WriteLine(tamalhos);
                    XGG = XGG+1;
                }
            }
            Console.WriteLine("tamanho=" + camisasArmazenadas);
            Console.WriteLine("quantidade PP " + PP);
            Console.WriteLine("quantidade P " + P);
            Console.WriteLine("quantidade M " + M);
            Console.WriteLine("quantidade G " + G);
            Console.WriteLine("quantidade GG " + GG);
            Console.WriteLine("quantidade XG" + XG);
            Console.WriteLine("quantidade XGG " + XGG);

        }
    }
}
