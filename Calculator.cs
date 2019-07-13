using System;

namespace LibraryCalc08
{
    public class Calculator : ICalculator
    {
        public int Adicao (int x, int y)
        {
            return x + y;
        }
        
        public int Subtracao(int x, int y)
        {
            return x - y;
        }

      
        public float Divisao(int x, int y)
        {
            return (float)x / y;
        }

        public int Multiplicacao(int x, int y)
        {
            return (x * y);
        }
        public int Adicao(int x, int y, int z) /* Adicao de tres valores */

        {
            return (x + y + z) ;
        }
    }
    

}


