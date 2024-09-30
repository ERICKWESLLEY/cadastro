using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    public class Program
    {
        static void Main()
        {
            Paciente paciente = new Paciente();

            string opcao = "s";

            Console.WriteLine("MENU\t\t\t\t\t\n1.Cadastar Paciente\n2.Mostar Lista\n3.Adicionar Paciente Prioritario\n4.Atender Paciente\nDigite a letra 'q' para sair...");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    paciente.cadastrarPaciente();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    paciente.mostrarlista();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    paciente.Prioridade();
                    Console.Clear();
                    break;

                case "4":
                    Console.Clear();
                    paciente.pacientesAtendidos();
                    Console.Clear();
                    break;

                case "q":
                    return;
                default:
                    Console.WriteLine("Opção Invalida...\n");
                    Console.Clear();
                    Main();
                    break;
            }
        }
    }
}


