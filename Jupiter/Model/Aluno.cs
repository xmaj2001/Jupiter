using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Model
{
   c
        public Aluno()
        {
            this.Classe = 1;
            this.Numero = 1;
            this.Sala = 1;
            this.Ano = DateTime.Now.Year;
            this.Foto = PastaImagem;
            this.Turma = "A";
        }

        public Aluno(JPDataSet.AlunosRow aluno)
        {
            this.ID = aluno.ID;
            this.Nome = aluno.Nome;
            this.Numero = aluno.Numero;
            this.Classe = aluno.Classe;
            this.Sala = aluno.Sala;
            this.Turma = aluno.Turma;
            if (aluno.Foto == "sem")
            {
                this.Foto = PastaImagem;
            }
            else
            {
                this.Foto = aluno.Foto;
            }
            this.Ano = aluno.Ano;
            this.Criado = aluno.Criado;
        }

    }
}
