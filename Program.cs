using System;
using Objeto_Argumento.Classes;
namespace Objeto_Argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando produtos 
            Produtos p1 = new Produtos(1,"Red Dead Redemption", 499f);
            Produtos p2 = new Produtos(76, "Devil May Cry", 78.99f);
            Produtos p3 = new Produtos(5, "Bully", 14.99f);
            Produtos p4 = new Produtos(10, "GTA San Andreas", 25.99f);
            Produtos p5 = new Produtos(15, "Dishonored", 32.99f);
            Carrinho celta = new Carrinho();

            celta.AdicionarProduto(p1);
            celta.AdicionarProduto(p2);
            celta.AdicionarProduto(p3);
            celta.AdicionarProduto(p4);
            celta.AdicionarProduto(p5);

            celta.MostrarProdutos();

            Produtos produtos = new Produtos(5, "Gta San Andreas", 120f);
            
            celta.AlterarItem(1, p5);

            celta.MostrarProdutos();
            celta.MostrarProdutos();
            celta.MostrarProdutos();
          
        }
    }
}
