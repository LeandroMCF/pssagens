using System;

namespace pssagens
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha, corrigindo;
            int rep;
            string[] nomes = new string[5], partida = new string[5], chegada = new string[5]; 
            double[] data = new double[5];
            int contador = 0;

            rep = 0;
            Console.Write("------------------\nPassagens\n------------------\nDigite sua senha: ");
            senha = Console.ReadLine();
            login(senha);

            do
            {
                Console.WriteLine($"Ecolha uma opção\n[1] Cadastrar passageiros\n[2] Mostrar lista de passagens\n[3] Corrigir informação na lista\n[0] Sair");
                rep = int.Parse(Console.ReadLine());
                switch (rep)
                {
                    case 1:
                        string resp;
                        do
                        {
                            if (contador < 5)
                            {
                                Console.WriteLine($"Digite o nome do {contador + 1}º passageio");
                                nomes[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite o ponto de partida do {contador + 1}º passageio");
                                partida[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite o ponto de chegada do {contador + 1}º passageio");
                                chegada[contador] = Console.ReadLine();
                                Console.WriteLine($"Digite a data da viagem do {contador + 1}º passageio (DD.MM.AAA)");
                                data[contador] = double.Parse(Console.ReadLine());
                                contador++;
                            }
                            else
                            {
                                Console.WriteLine($"Limeite de passageiros excedido");
                            }
                            Console.WriteLine($"Deseja adicionar mais algum passageiro?\n[S] Para sim\n[N] Para não");
                            resp = Console.ReadLine();
                            resp = resp.ToUpper();
                            while (resp != "S" && resp != "N")
                            {
                                Console.WriteLine($"Opição inválida.\n[S] Para sim\n[N] Para não");
                                resp = Console.ReadLine();
                                resp = resp.ToUpper();
                            }
                        } while (resp == "S");
                    break;

                    case 2:
                        while (contador == 0)
                        {
                            Console.WriteLine($"Você ainda não adicionou nada nenhum passageiro.");
                            Console.WriteLine("----------------------");
                            break;
                        }
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine("----------------------");
                            Console.WriteLine(nomes[i]);
                            Console.WriteLine($"Vai partir de {partida[i]}");
                            Console.WriteLine($"Vai chegar em {chegada[i]}");
                            Console.WriteLine($"No dia {data[i]}");
                            Console.WriteLine("----------------------");
                        }
                    break;
                    
                    case 3:
                        corre(corrigindo);
                    break;

                    default:
                        Console.WriteLine("Ok, obrigado. Tchau!");
                    break;
                }
                
            } while (rep != 0);


            //Funções
            bool login(string senha)
            {
                bool senhaInvalida = false;
                do
                {   
                    if (senha == "123456")
                    {
                        return true;
                    }
                    else
                    {
                        Console.Write($"Senha incorreta.\nDigite a senha novamente: ");
                        senha = Console.ReadLine();
                    }
                } while (senhaInvalida != true);
                return false;
            }

            string corre(string corrigindo)
            {
                Console.WriteLine($"Você deseja mudar o:\n[N] Nome\n[P] Partida\n[C] Chegada\n[D] Data");
                corrigindo = Console.ReadLine();
                corrigindo = corrigindo.ToUpper();
                while (corrigindo != "N" && corrigindo != "P" && corrigindo != "C" && corrigindo != "D")
                {
                    Console.WriteLine($"Resposta inválida.\n[N] Nome\n[P] Partida\n[C] Chegada\n[D] Data");
                    corrigindo = Console.ReadLine();
                    corrigindo = corrigindo.ToUpper();
                }
                int escolha = 0, escolha2 = 0, escolha3 = 0, posiNome;
                switch (corrigindo)
                {
                    case "N":
                        do
                        {
                            do
                            {
                                Console.Write($"Qual posição da lista está o nome que deseja corrigir está?");
                                posiNome = Int16.Parse(Console.ReadLine());
                                posiNome = posiNome - 1;
                                while (posiNome > 5)
                                {
                                    Console.WriteLine($"A Lista só possui {contador} opções");
                                    posiNome = Int16.Parse(Console.ReadLine());
                                    posiNome = posiNome - 1;
                                }
                                Console.WriteLine($"Você deseja corrigir o nome `{nomes[posiNome]}`?\n[1] SIm\n[2] Não");
                                escolha = int.Parse(Console.ReadLine());
                                while (escolha != 1 && escolha != 2)
                                {
                                    Console.WriteLine($"Opção inválida\nVocê deseja corrigir o nome `{nomes[posiNome]}`?\n[1] SIm\n[2] Não");
                                    escolha = int.Parse(Console.ReadLine());
                                }
                            } while (escolha == 2);
                            Console.WriteLine($"Digite o novo nome");
                            nomes[posiNome] = Console.ReadLine();
                            Console.WriteLine("Deseja corrigir mais algum nome?\n[1] Sim\n[2] Não");
                            escolha3 = int.Parse(Console.ReadLine());
                            while (escolha3 != 1 && escolha3 != 2)
                            {
                                Console.WriteLine($"Opção inválida\nDeseja corrigir mais algum nome?\n[1] Sim\n[2] Não");
                                escolha = int.Parse(Console.ReadLine());
                            }
                        } while (escolha2 == 1);
                    break;
                }
            }
        }
    }
}