using System;

namespace pssagens
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            int rep;
            string[] nomes = new string[5], partida = new string[5], chegada = new string[5]; 
            double[] data = new double[5];

            rep = 0;
            Console.Write("------------------\nPassagens\n------------------\nDigite sua senha:");
            senha = Console.ReadLine();
            login(senha);

            do
            {
                Console.WriteLine($"Ecolha uma opção\n[1] Cadastrar passageiros\n[2] Mostrar lista de passagens\n[0] Sair");
                rep = int.Parse(Console.ReadLine());
                switch (rep)
                {
                    case 1:
                        int contador = 0;
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
                                Console.WriteLine($"Digite a data da viagem do {contador + 1}º passageio");
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
                        } while (resp == "S");
                    break;

                    case 2:
                        
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
                        Console.WriteLine($"Senha incorreta");
                        senha = Console.ReadLine();
                    }
                } while (senhaInvalida != true);
                return false;
            }
        }
    }
}
