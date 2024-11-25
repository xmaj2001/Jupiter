using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Model
{
  public  class FiltroAluno
    {
        public string Turma = "";
        public int Classe = 0;
        public int Sala = 0;
        public int ano = 0;

        public bool SemFiltro()
        {
            var soma = Classe + Sala + ano;
            var sem = false;
            if (soma > 0) sem = true;
            if (Turma != "") sem = false;
            return sem;
        }
    }
}
