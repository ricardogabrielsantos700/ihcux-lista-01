using System;

namespace CaosNaCantina
{
    internal class ihcuxlista01
    {
        static void Main(string[] args)
        {
            int passoAtual = 1;
            int codigoProduto = 0;
            int quantidade = 0;

            Console.WriteLine("=== Bem-vindo ao Sistema da Cantina ===");

           
            while (passoAtual <= 3)
            {
                
                if (passoAtual == 1)
                {
                    Console.WriteLine("\n[Passo 1 de 3] Seleção de Item");
                    Console.Write("Digite o Código do Produto (1 a 10), 'voltar' ou 'cancelar': ");
                    
                    string entrada = Console.ReadLine()?.Trim().ToLower();

                    
                    if (entrada == "cancelar")
                    {
                        Console.WriteLine("Pedido cancelado. Saindo do sistema...");
                        return; 
                    }
                    if (entrada == "voltar")
                    {
                        Console.WriteLine("Aviso: Você já está no primeiro passo.");
                        continue;
                    }

                    
                    if (int.TryParse(entrada, out int codigo))
                    {
                        if (codigo >= 1 && codigo <= 10)
                        {
                            codigoProduto = codigo;
                            passoAtual++; 
                        }
                        else
                        {
                            
                            Console.WriteLine($"Erro: Código {codigo} não encontrado. Nossos códigos vão de 1 a 10. Tente novamente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número, 'voltar' ou 'cancelar'.");
                    }
                }
                
                
                else if (passoAtual == 2)
                {
                    Console.WriteLine("\n[Passo 2 de 3] Quantidade");
                    Console.Write($"Produto selecionado: {codigoProduto}. Digite a Quantidade, 'voltar' ou 'cancelar': ");
                    
                    string entrada = Console.ReadLine()?.Trim().ToLower();

                    
                    if (entrada == "cancelar")
                    {
                        Console.WriteLine("Pedido cancelado. Saindo do sistema...");
                        return;
                    }
                    if (entrada == "voltar")
                    {
                        passoAtual--; 
                        continue;
                    }

                    
                    if (int.TryParse(entrada, out int qtd) && qtd > 0)
                    {
                        quantidade = qtd;
                        passoAtual++; 
                    }
                    else
                    {
                        Console.WriteLine("Erro: Quantidade inválida! Por favor, digite um número inteiro maior que zero.");
                    }
                }
                
                
                else if (passoAtual == 3)
                {
                    Console.WriteLine("\n[Passo 3 de 3] Confirmação do Pedido");
                    Console.WriteLine("Resumo do seu pedido:");
                    Console.WriteLine($"- Código do Produto: {codigoProduto}");
                    Console.WriteLine($"- Quantidade: {quantidade}");
                    Console.Write("\nDeseja confirmar o pedido? ('sim', 'voltar' ou 'cancelar'): ");
                    
                    string entrada = Console.ReadLine()?.Trim().ToLower();

                    
                    if (entrada == "cancelar")
                    {
                        Console.WriteLine("Pedido cancelado. Saindo do sistema...");
                        return;
                    }
                    if (entrada == "voltar")
                    {
                        passoAtual--; 
                        continue;
                    }

                    if (entrada == "sim")
                    {
                        Console.WriteLine("\nPedido realizado com sucesso! Aguarde ser chamado no balcão.");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Erro: Opção inválida! Digite 'sim' para confirmar, 'voltar' para alterar a quantidade ou 'cancelar' para abortar.");
                    }
                }
            }
        }
    }
}