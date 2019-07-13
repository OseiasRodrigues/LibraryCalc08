using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc08
{
    interface ICalculator
    {
        // <Soma de valores Inteiros>
        int Adicao(int x, int y);

        // <Subtrai valores  inteiros>
        int Subtracao(int x, int y);

        // <Multiplica os Valores Inteiros>
        int Multiplicacao(int x, int y);

        // <Divide os valores reais>
        float Divisao(int x, int y);

        // <Soma de Tres fatores Inteiros>
        int Adicao(int x, int y, int z);
    }
}
