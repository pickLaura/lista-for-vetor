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
            
            int camisasArmazenadas = 0, PP = 0, P = 0, M = 0, G = 0, GG = 0, XG = 0, XGG = 0;
            string[] tamalhos = new string[40];
            for (int i = 0; i <= tamalhos.Length; i++)
            {
                Console.WriteLine("PP , P , M , G  , GG , XG , XGG  " );
                Console.WriteLine("digite a quatidade de camisas ");
                tamalhos[i] = Console.ReadLine().ToLower();
            }

            for (int i = 0; i <= tamalhos.Length; i++)
            {
                Console.WriteLine("tamanho " + tamalhos[i]);
                
            }

             for (int i = 0; i <= tamalhos.Length; i++){
                if(tamalhos[i] == "pp"){
                Console.WriteLine("escolido PP ");
            
                Console.WriteLine(tamalhos);     
            }
                if (tamalhos[i] == "P") { 

                Console.WriteLine("escolido PP ");

            Console.WriteLine(tamalhos);  
        }
    }
    }
}