using System;
using System.Collections.Generic;
using Dominio;

namespace Servico
{
    public class Separacao
    {
        List<int> ladoPar = new List<int>(){6,8,8,10,12};
        List<int> ladoImpar = new List<int>(){7,9,11,13};
        List<int> Meio = new List<int>(){1,2,3,4,5,};
        

        public List<string> SeparaProdutos(List<Registro> produtos){

            return new List<string>(){"1"};

            throw new NotImplementedException("ainda não implementado");
        }
    }
}
