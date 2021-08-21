using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de produtos
            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "tomate", "frango", "doce"
            };
            //Validar argumentos
            try
            {
                //Lista de produtos Disponiveis
                var produtosSelecionados = produtosDisponiveis.Where(produto => args.Contains(produto)).ToList();
                foreach (var item in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nós temos: {item}");
                }
                var produtoNaoDisponivel = args.Where(produtos => !produtosDisponiveis.Contains(produtos)).ToList();
                foreach(var naoDisponivel in produtoNaoDisponivel)
                {
                    Console.WriteLine($"Este produto nós não temos: {naoDisponivel}");
                }
                //Ordenar em ordem alfabética
               /* var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(e => e).ToList();
                foreach(var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponivel: {produtoOrdenado}");
                }*/
            }
            catch (System.Exception)
            {
                Console.WriteLine("Argumentos inválidos!");    
                throw;
            }
            
        }
    }
}
