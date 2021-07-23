using System;

namespace ListaDeConvidados
{
    class Program
    {
        private static string[] ListaDeConvidados = {
            "Daniel",//posição 0
            "Evandro",//posição 1
            "Matheus",//posição 2
            "Alan",//posição 3
            "Teresa",//posição 4
            "Gabriel",//posição 5
            "Cledson",//posição 6
            "Rafael"//posição 7
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado:");
            var nome = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("O nome informado não é válido para seguir com o programa");
                return;
            }

            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if(idadeInformada == false)
            {
                Console.WriteLine("A idade informada não é válida para seguir com o programa");
                return;
            }

            bool estaConvidado;
            switch(nome)
            {
                case "Daniel"://posição 0
                    estaConvidado = true;
                    break;
                case "Evandro"://posição 1
                    estaConvidado = true;
                    break;
                case "Matheus"://posição 2
                    estaConvidado = true;
                    break;
                case "Alan"://posição 3
                    estaConvidado = true;
                    break;
                case "Teresa"://posição 4
                    estaConvidado = true;
                    break;
                case "Gabriel"://posição 5
                    estaConvidado = true;
                    break;
                case "Cledson"://posição 6
                    estaConvidado = true;
                    break;
                case "Rafael"://posição 7
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            }
            
            if(estaConvidado == true && idade >= 18)
            {
                Console.WriteLine("Parabéns, seja bem vindo a festa");
            }
            else if(estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados, favor verifique com a pessoa que te convidou");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos pra entrar na festa");
            }
        }
    }
}
