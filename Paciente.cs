using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_pacientes_hospitalares
{
    internal class Paciente
    {
        private int id;
        private string nome, email;
        private int idade;
        private string descSintomas;

        public Paciente(int id, string nome, string email, int idade, string descSintomas) 
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.idade = idade;
            this.descSintomas = descSintomas;
        }

        public Paciente(int id, string nome, string email, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.idade = idade;
        }

        public Paciente(int id, string nome,string sintomas)
        {
            this.id = id;
            this.nome = nome;
            this.descSintomas = sintomas;
        }

        public Paciente() // Paciente Sentinela, para inicializar a lista.
        {
            this.id = 0;
            this.nome = null;
            this.email = null;
            this.idade = 0;
            this.descSintomas = null;
        }
        
        public int Id
        {
            get {  return this.id; }
            set { this.id = value; }
        }
        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string DescSintomas
        {
            get { return this.descSintomas; }
            set { this.descSintomas = value; }
        }

        public void RegistrarPaciente()
        {
            Console.WriteLine("Deseja adicionar o paciente na fila? \n 1.Sim \n 2.Não");
            int opc = int.Parse(Console.ReadLine());

            if(opc == 1)
            {
                // Chamar método lista

                Console.WriteLine("Paciente registrado e adicionado à lista de espera");
            }
            else
            {
                Console.WriteLine("Paciente registrado com sucesso e não adicionado à lista de espera");
            }
        }

          


    }
}
