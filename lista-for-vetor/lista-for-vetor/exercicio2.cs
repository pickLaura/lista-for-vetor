using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio2
    {
        public exercicio2()
        {
            int[] idades = new Int32[6];
            
            
              
            for (int i = 0; i <= idades.Length; i++)
            {

                Console.WriteLine("digite sua idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<=idades.Length;i++){

                Console.WriteLine("idade " + idades[i]);
                
            }
           
        }
    }
}
