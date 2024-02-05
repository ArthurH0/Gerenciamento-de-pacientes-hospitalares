using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gerenciamento_de_pacientes_hospitalares
{
    internal class Program
    {
        static int Exibirmenu()
        {
            Console.WriteLine("1. Sair \n" +
                       "2. Registrar Paciente \n" +
                       "3. Adicionar Paciente na fila de espera \n" +   // Menu de opções.
                       "4. Chamar próximo paciente \n" +
                       "5. Exibir Fila de espera");

            return int.Parse(Console.ReadLine()); // Retornando o input do usuário
        }

        static void Main(string[] args)
        {
            try
            {
                int opc = 0; // Variável de controle do menu.
                Paciente paciente = new Paciente();
                Lista ListadeEspera = new Lista(); // Criando a lista de espera de pacientes.

                do
                {
                    opc = 0;
                    while (opc != 1 && opc != 2 && opc != 3 && opc != 4 && opc != 5)
                    {

                        opc = Exibirmenu();

                                   // Input do usuário.

                        if (opc != 1 && opc != 2 && opc != 3 && opc != 4 && opc != 5)
                        {
                            Console.WriteLine("\n Valor inválido \n");
                        }
                    }


                    if (opc == 2)
                    {
                        Console.WriteLine("\nIdentificador do paciente");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nNome do paciente");
                        string nome = Console.ReadLine();

                        Console.WriteLine("\nEmail do paciente");
                        string email = Console.ReadLine();

                        Console.WriteLine("\nIdade do paciente");
                        int idade = int.Parse(Console.ReadLine());



                        Paciente pacienteNovo = new Paciente(id, nome, email, idade);      // Criando um objeto paciente.


                        StreamWriter ListadePacientes = new StreamWriter("C:\\Users \\Arthur\\source\\repos\\ListadePacientes.txt", true, Encoding.UTF8);
                        ListadePacientes.WriteLine(pacienteNovo.Id + "," + pacienteNovo.Nome + "," + pacienteNovo.Email + "," + pacienteNovo.Idade);  // Registrando o paciente na Lista de Pacientes(Escrevendo no arquivo)
                        ListadePacientes.Close();

                        int adc = 0;

                        while (adc != 1 && adc != 2)
                        {
                            Console.WriteLine("Deseja adicionar o paciente na fila? \n 1.Sim \n 2.Não");
                            adc = int.Parse(Console.ReadLine());

                            if (adc == 1)
                            {
                                Console.WriteLine("Informe os sintomas do paciente");
                                string sint = Console.ReadLine();

                                pacienteNovo.DescSintomas = sint;

                                ListadeEspera.AdicionarnaLista(pacienteNovo); //Adicionando paciente na lista.
                                Console.WriteLine("\n Paciente adicionado à fila\n");
                            }
                            else if (adc == 2)
                            {
                                //Não adicionar
                                Console.WriteLine("\n Paciente não adicionado à fila\n");
                            }
                            else
                            {
                                Console.WriteLine("\n Valor inválido digite outro valor\n");
                            }
                        }



                    }
                    else if (opc == 3)
                    {
                        bool ver = true; // Controle do while
                        string[] detpacienetes; //Vetor para armazenar os itens lidos no arquivo

                        Console.WriteLine("Informe o id do paciente");
                        int idpaciente = int.Parse(Console.ReadLine());

                       

                        StreamReader PesquisarPacientes = new StreamReader("C:\\Users\\Arthur\\source\\repos\\ListadePacientes.txt", Encoding.UTF8); // Ler o arquivo e conferir o id informado,
                                                                                                                                        // se o id for encontrado, adicionar na lista, se não, informar que id não existe.
                        string linha = PesquisarPacientes.ReadLine(); // Ler a primeira linha do arquivo

                        while (ver) 
                        {

                            detpacienetes = linha.Split(',');
                            string idArq = detpacienetes[0];

                            int id = Int32.Parse(idArq); // Passando o id(string) do arquivo para int


                            if (id == idpaciente)
                            {
                                ver = false;
                                Console.WriteLine("Deseja adicionar o paciente " + detpacienetes[1] + " à lista de espera? \n 1.Sim \n 2.Não"); //Confirmar se o nome do paciente está correto
                                int conf = int.Parse(Console.ReadLine());

                                if (conf == 1) // Se estiver
                                {
                                    Console.WriteLine("Informe os sintmas do paciente");
                                    string sint = Console.ReadLine();

                                    Paciente pacienteNovo = new Paciente(idpaciente, detpacienetes[1],sint); // Criando um objeto paciente novo para adicinar na lista
                                    ListadeEspera.AdicionarnaLista(pacienteNovo); //Adicionando paciente na lista.

                                    Console.WriteLine("\n Paciente adicionado à lista com sucesso \n");

                                }
                                else
                                {
                                    Console.WriteLine("Voltando para o inicio");
                                    break; 
                                }       
                            }
                            else
                            {
                                linha = PesquisarPacientes.ReadLine(); // Se o id não for igual, ler a proxima linha
                            }


                        }
                        if (ver)
                        {
                            Console.WriteLine("Id não encontrado"); // Saiu do while 
                        }

                    }
                    else if (opc == 4)
                    {
                        ListadeEspera.ExibirProximo();
                        ListadeEspera.RemoverPaciente();
                    }
                    else if (opc == 5)
                    {
                        ListadeEspera.ExibirLista();
                    }


                } while (opc != 1);


            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }
    }
}
