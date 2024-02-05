using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_pacientes_hospitalares
{
    internal class Celula
    {
        private Celula proximo;
        private Paciente item;

        public Celula(Paciente paciente)
        {
            this.proximo = null;
            this.item = paciente;
        }

        public Celula()
        {
            proximo = null;
            this.item = new Paciente();
        }

        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public Paciente Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
