using System;
using System.Collections; 

namespace pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack estrutura_pilha = new Stack();
            int opcoes = 0;
             Console.WriteLine("Seja bem vindo!\nEscolha uma opção abaixo:");
            while (opcoes != 1){
                Console.WriteLine("1 - Encerrar o programa");
                Console.WriteLine("2 - Verificar se a pilha está vazia (isEmpty)");
                Console.WriteLine("3 - Empilhar (Push)");
                Console.WriteLine("4 - Desempilhar (Pop) ");
                Console.WriteLine("5 - Tamanho da pilha ");
                Console.WriteLine("6 - Pilha que está no topo (Peek) ");
                Console.WriteLine("7 - Limpar pilha ");

                opcoes = Convert.ToInt32(Console.ReadLine());

                switch (opcoes)
                {
                    case 2:
                        if(estrutura_pilha.Count == 0)
                        {
                            Console.WriteLine("A pilha está vazia!");
                        }
                        else
                        {
                            Console.WriteLine("A pilha não está vazia!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Informe o dado que deseja empilhar:");
                        String dado = Console.ReadLine();
                        estrutura_pilha.Push(dado);
                        break;
                    case 4:
                        if(estrutura_pilha.Count > 0){

                            String retirar = estrutura_pilha.Pop().ToString();
                            Console.WriteLine(retirar);
                        }
                        else
                        {
                            Console.WriteLine("A pilha se encontra vazia!");
                        }
                        break;
                    case 5:
                        int tamanho = estrutura_pilha.Count;
                        Console.WriteLine(tamanho);
                        break;
                    case 6:
                        if(estrutura_pilha.Count != 0) {
                            Console.WriteLine(estrutura_pilha.Peek());
                        } 
                        else{
                            Console.WriteLine("A Pilha está vazia!");
                        }
                        break;
                    case 7:
                        estrutura_pilha.Clear();
                        Console.WriteLine("A pilha está limpa");
                        break;




                    
                   
                }
            }
        }
    }
}
