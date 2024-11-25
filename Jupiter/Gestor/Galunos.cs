using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Gestor
{
    public class Galunos
    {
        private List<Aluno> _Alunos = new List<Aluno>();
        private Gpagamentos gir = new Gpagamentos();
        private JPDataSetTableAdapters.AlunosTableAdapter db_aluno = new JPDataSetTableAdapters.AlunosTableAdapter();
        public void LoadLista(int ano)
        {
            _Alunos.Clear();
            foreach (var item in db_aluno.Alunos(ano))
            {
                _Alunos.Add(new Aluno(item));
            }
        }
        public List<Aluno> LoadLista(int Classe,int ano)
        {
            _Alunos.Clear();
            foreach (var item in db_aluno.LoadAlunosByClasse(Classe,ano))
            {
                _Alunos.Add(new Aluno(item));
            }
            return _Alunos;
        }
        public List<Aluno> All()
        {
            return _Alunos;
        }
        ///Pesquisar Via Numero do ALuno
        public List<Aluno> FindByNum(int Aluno,int ano)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.FindByNun(Aluno,ano))
            {
                alunos.Add(new Aluno(item));
            }
            return alunos;
        }

        public List<Aluno> FindByNum(int Aluno,int Classe, int ano)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.FindByNunClasse(Aluno, Classe, ano))
            {
                alunos.Add(new Aluno(item));
            }
            return alunos;
        }
        //
        public List<Aluno> Find(string Aluno,  int ano = 0)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.FindByNome(Aluno, ano))
            {
                alunos.Add(new Aluno(item));
            }
            return alunos;
        }
        public List<Aluno> Find(string Aluno, int classe = 0, int ano = 0)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.FindByNomeClasse(Aluno, classe, ano))
            {
                alunos.Add(new Aluno(item));
            }
            return alunos;
        }
        public int TotalAlunos(int anoLetivo)
        {
            var total = db_aluno.Total(anoLetivo);
            if (total != null) return total.Value;
            return 0;
        }

        public int TotalAlunos()
        {
            var total = db_aluno.TotalFull();
            if (total != null) return total.Value;
            return 0;
        }
        public int TotalAlunos(int Classe,int anoLetivo)
        {
            var total = db_aluno.Total2(Classe,anoLetivo);
            if (total != null) return total.Value;
            return 0;
        }
        public void Atualizar(Aluno aluno)
        {
            db_aluno.Atualizar(aluno.Nome, aluno.Classe, aluno.Numero, aluno.Sala, aluno.Turma, aluno.Foto, aluno.Ano, aluno.ID);
        }
        public void Add(Aluno aluno)
        {
            db_aluno.Add(aluno.Nome, aluno.Classe, aluno.Numero, aluno.Sala, aluno.Turma, aluno.Foto, aluno.Ano);
        }
        public void Apagar(Aluno aluno)
        {
            db_aluno.Apagar(aluno.ID);
            gir.Apagar(aluno);
        }
        public Aluno GetAlunoByNumero(int nun,int ano)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.GetByNum(nun, ano))
            {
                alunos.Add(new Aluno(item));
            }
            if (alunos.Count > 0)
                return alunos[0];
            else
                return null;
        }

        public Aluno GetAlunoByNCA(int nun, int sala, string turma, int classe, int ano)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.GetAlunoNCA(nun,sala,turma,classe,ano))
            {
                alunos.Add(new Aluno(item));
            }
            if (alunos.Count > 0)
                return alunos[0];
            else
                return null;
        }
        public Aluno GetAluno(int id)
        {
            var alunos = new List<Aluno>();
            foreach (var item in db_aluno.GetAlunoID(id))
            {
                alunos.Add(new Aluno(item));
            }
            if (alunos.Count > 0)
                return alunos[0];
            else
                return null;
        }
    }
}
