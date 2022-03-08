using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Contato> contatos = new List<Contato>();
            int opcao = 0;
            while (opcao != 6)
            {
                Console.WriteLine("---- MENU ----");
                Console.WriteLine("1-Inserir um Contato");
                Console.WriteLine("2-Localizar um Contato");
                Console.WriteLine("3-Excluir um Contato");
                Console.WriteLine("4-Editar um Contato");
                Console.WriteLine("5-Imprimir os contatos");
                Console.WriteLine("6-Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("email: ");
                    string email = Console.ReadLine();

                    Console.Write("Quantos telefones você deseja inserir?: ");
                    int qtdTelefone = int.Parse(Console.ReadLine());

                    if (qtdTelefone <= 0)
                    {
                        Console.WriteLine("Você deve inserir pelo menos 1 Contato");
                        continue;
                    }

                    List<Telefone> telefones = new List<Telefone>();

                    for (int i = 0; i < qtdTelefone; i++)
                    {
                        Console.Write("Tipo:");
                        string tipo = Console.ReadLine();

                        Console.Write("DDD: ");
                        string ddd = Console.ReadLine();

                        Console.Write("numero: ");
                        string numero = Console.ReadLine();

                        Telefone telefone = new Telefone(tipo, ddd, numero);
                        telefones.Add(telefone);
                    }

                    Contato contato = new Contato(nome, email, telefones);
                    contatos.Add(contato);
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();
                    bool encontrou = false;
                    for (int i = 0; i < contatos.Count; i++)
                    {
                        if (nome == contatos[i].Nome)
                        {
                            Console.WriteLine(contatos[i]);
                            encontrou = true;

                            for (int x = 0; x < contatos[i].Telefones.Count; x++)
                            {
                                Console.WriteLine(contatos[i].Telefones[x]);
                            }
                        }
                        if (!encontrou)
                        {
                            Console.WriteLine("Contato não encontrado!");
                        }
                    }
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Digite o nome do Contato que deseja excluir: ");
                    string nome = Console.ReadLine();
                    bool encontrou = false;
                    for ( int i = 0; i < contatos.Count; i++)
                    {
                        if (nome == contatos[i].Nome)
                        {
                           contatos.RemoveAt(i);
                            encontrou = true;
                        }
                    }
                    if (!encontrou)
                    {
                        Console.WriteLine("Contato não encontrado!");
                    }
                }
                else if(opcao == 4)
                {
                    Console.WriteLine("Digite o nome do Contato que deseja editar: ");
                    string nome = Console.ReadLine();
                    bool encontrou = false;
                    for(int i = 0; i < contatos.Count; i++)
                    {
                        if(nome == contatos[i].Nome)
                        {
                            encontrou = true;

                            Console.Write("nome: ");
                            string nomeNovo = Console.ReadLine();

                            Console.Write("email: ");
                            string email = Console.ReadLine();

                            contatos[i].Nome = nomeNovo;
                            contatos[i].Email = email;

                            for (int t = 0; t < contatos[i].Telefones.Count; t++)
                            {
                                Console.Write("Tipo:");
                                string tipo = Console.ReadLine();

                                Console.Write("DDD: ");
                                string ddd = Console.ReadLine();

                                Console.Write("numero: ");
                                string numero = Console.ReadLine();

                                contatos[i].Telefones[t].Tipo = tipo;
                                contatos[i].Telefones[t].DDD = ddd;
                                contatos[i].Telefones[t].Numero = numero;
                            }
                        }
                    }
                    if (!encontrou)
                    {
                        Console.WriteLine("Contato não encontrado!");
                    }
                }
                else if(opcao == 5)
                {
                    for(int i = 0; i < contatos.Count; i++)
                    {
                        Console.WriteLine(contatos[i]);

                        for (int t = 0; t < contatos[i].Telefones.Count; t++)
                        {
                            Console.WriteLine(contatos[i].Telefones[t]);
                        }
                    }
                }
                else if(opcao == 6)
                {
                    Console.WriteLine("Saindo..");
                    break;
                }
                else
                {
                    Console.WriteLine("Digite uma das opções do Menu");
                }
            }
        }
    }
}