using AluguelDeQuartos;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

           
            bool IsSair = false;
            while (!IsSair) {
                Console.WriteLine("Quantos quartos serão alugados?");
                int n = int.Parse(Console.ReadLine());

                Quarto[] VQuartos = new Quarto[n];

                Console.WriteLine("Selecione:\n1.Preencher Quartos\n2.Gerar Relatório");
                int valor = int.Parse(Console.ReadLine());
                if (valor == 1) {
                    for (int i = 0; i < VQuartos.Length; i++) {
                        Console.WriteLine($"Quartos Ocupados: \n" +
                        $"Aluguel #{i + 1}:\n" +
                        $"Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Email:");
                        string email = Console.ReadLine();

                        Console.WriteLine("Quarto: ");
                        int room = int.Parse(Console.ReadLine());

                        VQuartos[i] = new Quarto((i + 1), name, email, room);

                    }
                }
                else {                    
                        for (int i = 0; i < VQuartos.Length; i++) {
                            VQuartos[i].GetQuarto();
                        }
                   
                }                
               
                Console.WriteLine("Deseja sair? \nS\nou\nN");
                if (Console.ReadLine() == "S") 
                        IsSair  = true;
            }


        }
    }

}