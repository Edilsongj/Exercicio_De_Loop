using System;

class Program{

    static void Main() {

        int vidaDoAgente = 100;
        string opções;
        bool continuar = true;

        do {
            Console.WriteLine("1 Iniciar a Missão");
            Console.WriteLine("2 Status");
            Console.WriteLine("3 Sair");

            opções = Console.ReadLine()!;

            switch (opções)
            {
                case "1":
                    Console.WriteLine("Missão iniciada");
                    vidaDoAgente -= 30;
                    Console.WriteLine($"vida do agente {vidaDoAgente}");
                    break;

                    case "2":                 
                    if (vidaDoAgente >= 50)
                    {
                        Console.WriteLine(" Agente pronto para batalha!");
                    }
                    else {

                        Console.WriteLine("Agente ferido! precisa descansar.");                        
                    }
                    break;

                case "3":
                    continuar = false;
                    Console.WriteLine("Saindo do sistema! Encerrar o programa.");
                    break;
                
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;  

            }

            } while (continuar);
       
        } 

    }
    
    

