using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio7
    {
        public exercicio7()
        {

            char[] letras = new char[20];
            for (int i = 0; i <= letras.Length; i++)
            {
                Console.Write("digite um caracter: ");
                letras[i] = Convert.ToChar(Console.ReadLine());
            }



        }
    }
}
