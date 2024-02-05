using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_pacientes_hospitalares
{
    class Lista
    {
        private Celula primeiro;
        private Celula ultimo;
        private int tamanho;

        public Lista()
        {
            Celula sentinela = new Celula();

            primeiro = sentinela;
            ultimo = sentinela;
            tamanho = 0;

        }

        public bool FilaVazia()
        {
            if (primeiro == ultimo)
            {
                return true;
            }
            else
                return false;
        }

        public void AdicionarnaLista(Paciente novo)
        {
            Celula Pacientenovo = new Celula(novo);

            ultimo.Proximo = Pacientenovo;
            ultimo = Pacientenovo;
        }
        public void AdicionarnaFrente(Paciente novo)
        {

        }

        public string RemoverPaciente()
        {
            Celula removido = primeiro.Proximo;

            primeiro.Proximo = removido.Proximo;

            removido.Proximo = null;

            return removido.Item.Nome; 


        }
        public void ExibirLista()
        {
            if (!FilaVazia())
            {
                Celula aux;
                int pos = 0;
                aux = primeiro.Proximo;
                Console.WriteLine("\n Fila de Espera \n");
                while (aux != null)
                {
                    Console.WriteLine(pos + " " + aux.Item.Nome + "\n");
                    aux = aux.Proximo;
                    pos++;if()
                }
            }
            else
                Console.WriteLine("Fila Vazia");
           
        }
        public void ExibirProximo()
        {
            Celula proximo = primeiro.Proximo;
            if(!FilaVazia())
            {
                Console.WriteLine("Próximo paciente: "proximo.Id +" "+ proximo.Nome)
            }
        }
        
    }
}
