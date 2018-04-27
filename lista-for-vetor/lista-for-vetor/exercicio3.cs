using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_for_vetor
{
    class exercicio3
    {
        public exercicio3()
        {
            Console.WriteLine("digite uma quantidade de produdos ");
            int quantidade=Convert.ToInt32(Console.ReadLine());
            double[] precos=new double[quantidade];
            
            for (int i = 0; i <= precos.Length; i++) { 
                Console.WriteLine("dijite os preços ");
                precos[i]=Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine(precos +" "+ quantidade);
            
    }
    }
}
