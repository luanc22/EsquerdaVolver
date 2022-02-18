using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordemDeComandos = 1;
            string inputComandos;
            string direcoesVolvidas = "";

            int direcaoInicialNumero;
            int direcaoFinalNumero;
            char direcaoFinalLetra;

            string sequenciaComandos;
            string sequenciaComandosMaiuscula;

            bool opcaoValida = false;
            bool fecharApp = false;
            while (fecharApp == false)
            {
                while (ordemDeComandos != 0)
                {
                    Console.WriteLine("===== Esquerda, Volver! =====");
                    Console.WriteLine("");
                    Console.WriteLine("Utilize esse programa para descobrir o lado do soldado apos os comandos dados.");
                    Console.WriteLine("");
                    Console.WriteLine("===================================");
                    Console.WriteLine("");

                    Console.Write("Digite a quantidade de comandos: ");
                    inputComandos = Console.ReadLine();
                    ordemDeComandos = int.Parse(inputComandos);

                    if (ordemDeComandos == 0)
                    {
                        continue;
                    }

                    Console.Write("Digite os comandos para fazer: ");
                    direcaoInicialNumero = 1;
                    direcaoFinalLetra = ' ';
                    sequenciaComandos = Console.ReadLine();
                    sequenciaComandosMaiuscula = sequenciaComandos.ToUpper();
                    char[] comandoDeSequencia = sequenciaComandosMaiuscula.ToCharArray();


                    for (int i = 0; i < comandoDeSequencia.Length; i++)
                    {

                        if (comandoDeSequencia[i] == 'E')
                        {
                            direcaoInicialNumero = direcaoInicialNumero - 1;
                            if (direcaoInicialNumero == 0)
                            {
                                direcaoInicialNumero = 4;
                            }
                        }
                        else if (comandoDeSequencia[i] == 'D')
                        {
                            direcaoInicialNumero = direcaoInicialNumero + 1;
                            if (direcaoInicialNumero == 5)
                            {
                                direcaoInicialNumero = 1;
                            }
                        }

                    }

                    direcaoFinalNumero = direcaoInicialNumero;

                    switch (direcaoFinalNumero)
                    {
                        case 1:
                            direcaoFinalLetra = 'N';
                            break;
                        case 2:
                            direcaoFinalLetra = 'L';
                            break;
                        case 3:
                            direcaoFinalLetra = 'S';
                            break;
                        case 4:
                            direcaoFinalLetra = 'O';
                            break;
                    }



                    direcoesVolvidas = direcoesVolvidas + " " + direcaoFinalLetra;
                    Console.WriteLine("Direcao Final: " + direcaoFinalLetra);
                    Console.WriteLine("");
                    Console.WriteLine("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();

                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Direcoes:" + direcoesVolvidas);
                Console.ResetColor();

                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();

                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar rodar o programa novamente e inserir novos comandos, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    string fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        ordemDeComandos = 1;
                        direcoesVolvidas = "";
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}
