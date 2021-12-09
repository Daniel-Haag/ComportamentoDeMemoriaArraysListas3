using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionatoEstudantes
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroDoQuarto { get; set; }

        public Estudante()
        {
        }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
