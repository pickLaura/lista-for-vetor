using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio5
    {
        public exercicio5()
        {
            Console.WriteLine("digite  a quantidade de jogos no estoque ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            string[] estoque = new string[quantidade]; 
            string[] game = new string[quantidade];
            for (int i = 0; i < game.Length; i++)
            {
                Console.WriteLine("dijite nome do game ");
                game[i] = Console.ReadLine().ToLower();

                Console.WriteLine("dijite quantidade de games ");
                estoque[i] = Console.ReadLine().ToLower();
               
                    
            }

        }
    }
}
