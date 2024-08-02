using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafetaria1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidas = new List<ICafe>
            {
                //cafe filtrado com chocolate
                new ChocolateDecorator(new Filtrado()),
                //cafe filtrado com leite
                new LeiteDecorator(new Filtrado()),
                //cafe espresso com leite e chocolate
                new ChocolateDecorator(new LeiteDecorator(new Espresso()))
            };

            var filtradoChocolate = bebidas.First();
            Console.WriteLine(filtradoChocolate.Descricao());
            Console.WriteLine($"{filtradoChocolate.Preco()}\n");

            var filtradoLeite = bebidas.Skip(1).First();
            Console.WriteLine(filtradoLeite.Descricao());
            Console.WriteLine($"{filtradoLeite.Preco()}\n");

            var espressoLeiteChocolate = bebidas.Skip(2).First();
            Console.WriteLine(espressoLeiteChocolate.Descricao());
            Console.WriteLine($"{espressoLeiteChocolate.Preco()}\n");


            Console.ReadKey();
        }
    }
}
