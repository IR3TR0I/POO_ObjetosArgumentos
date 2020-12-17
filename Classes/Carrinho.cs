using System.Collections.Generic;
using System;
namespace Objeto_Argumento.Classes
{
    public class Carrinho
    {
        // Atributo para armazenar o valor total do produto ao carrinho
        public float ValorTotal {get; set;}

        // Criamos a lista de produtos, e a chamamos de carrinho
        List<Produtos> carrinho = new List<Produtos>();
        private int _codigo_procurado;

        // Método para adicionar o "_produto" ao carrinho 
        public void AdicionarProduto(Produtos _produto) {
            carrinho.Add(_produto);
        }

        public void MostrarProdutos() {
            if(carrinho != null ){
                foreach (var item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }

        public void RemoverProduto(Produtos _produto) {
            carrinho.Remove(_produto);
        }

        public void MostrarTotal(){
            if(carrinho != null) {
                foreach (var item in carrinho)
                {
                    ValorTotal = ValorTotal + item.Preco;
                }
                Console.WriteLine($"Total do carrino é : R$ {ValorTotal}");
            } else{
                Console.WriteLine("Seu carrinho esta vazio!");
            }
        }


        public void AlterarItem(int _codigo, Produtos _novoproduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo_procurado).Preco = _novoproduto.Preco;
        }
        
    }
}