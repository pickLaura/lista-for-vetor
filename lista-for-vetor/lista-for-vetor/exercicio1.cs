﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio1
    {
        public exercicio1()
        {
            string[] nomes = new string[25];
            for (int i = 0; i <= nomes.Length - 1; i++)
            {
                Console.Write("dijite seu nome ");
                nomes[i] = Console.ReadLine();
            }

        }
    }
}
