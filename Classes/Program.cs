using Classes;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Produto produto = new Produto("TV", 40.00, 10);

            

            produto.Nome = "Banana";

            Console.WriteLine(produto.Nome);
        }
    }
}