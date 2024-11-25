using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Gestor
{
    public class Gpagamentos
    {
        private List<Pagamento> _lista = new List<Pagamento>();
        private JPDataSetTableAdapters.PagementosTableAdapter db = new JPDataSetTableAdapters.PagementosTableAdapter();
        public void Load(Aluno aluno)
        {
            Load(aluno.ID);
        }
        public void Load(int id)
        {
            var paga = db.GetPagamento(id);
            _lista.Clear();
            foreach (var item in paga)
            {
                _lista.Add(new Pagamento(item));
            }
        }
        public Pagamento GetByDate(DateTime data, int idaluno)
        {
            var paga = db.GetPagamentoByDate(data.Year.ToString(), data.Month.ToString(), idaluno);
            _lista.Clear();
            foreach (var item in paga)
            {
                _lista.Add(new Pagamento(item));
            }
            if (_lista.Count > 0) return _lista[0];
            return null;
        }
        public List<Pagamento> GetPagamentos()
        {
            return _lista;
        }
        public List<Pagamento> GetPagamentos(DateTime data)
        {
            var lista = new List<Pagamento>();
            var paga = db.GetDate(data);
            foreach (var item in paga)
            {
                lista.Add(new Pagamento(item));
            }
            return lista;
        }

        public List<TotalDia> GetMespago(DateTime data)
        {
            var lista = new List<TotalDia>();
            var paga = db.GetMesPagos(data.Year.ToString(), data.Month.ToString());
            foreach (JPDataSet.PagementosRow item in paga)
            {
                var dia = new TotalDia();
                dia.IDaluno = item.IDAluno;
                dia.NomeAluno = item["Nome"].ToString();
                dia.Classe = item["Classe"].ToString() + "ªClasse";
                dia.Data = item.Data;
                dia.Propina = item.Propina;
                dia.Multa = item.Multa;
                dia.Criado = item.Criado;
                lista.Add(dia);
            }
            return lista;
        }
       
        public int GetDevidores(DateTime data)
        {
            var total = 0;
            var paga = db.GetNop(data.Year.ToString(), data.Month.ToString());
            foreach (JPDataSet.PagementosRow item in paga)
            {
                if (data.Year == int.Parse(item["Ano"].ToString()))
                {
                    total++;
                }
            }
            return total;
        }


        public List<Aluno> GetAlunoPagaram(DateTime data, int Classe = 0, int Sala = 0, string Turma = "")
        {
            var lista = new List<Aluno>();
            var paga = db.GetMesPagos(data.Year.ToString(), data.Month.ToString());
            foreach (JPDataSet.PagementosRow item in paga)
            {
                var dia = new Aluno();
                dia.ID = item.IDAluno;
                dia.Nome = item["Nome"].ToString();
                dia.Numero = int.Parse(item["Numero"].ToString());
                dia.Classe = int.Parse(item["Classe"].ToString());
                dia.Sala = int.Parse(item["Sala"].ToString());
                dia.Turma = item["Turma"].ToString();
                dia.Ano = int.Parse(item["Ano"].ToString());
                if (Classe != 0 && dia.Classe != Classe)
                {
                    continue;
                }

                if (Sala != 0 && dia.Sala != Sala)
                {
                    continue;
                }
                Turma = Turma.Trim().ToUpper();
                if (!string.IsNullOrWhiteSpace(Turma) && dia.Turma != Turma)
                {
                    continue;
                }
                lista.Add(dia);
            }
            return lista;
        }
        public List<Aluno> GetAlunoNaoPagaram(DateTime data, int Classe = 0, int Sala = 0, string Turma = "")
        {
            var lista = new List<Aluno>();
            var paga = db.GetNop(data.Year.ToString(), data.Month.ToString());

            foreach (JPDataSet.PagementosRow item in paga)
            {
                if (data.Year == int.Parse(item["Ano"].ToString()))
                {

                    var dia = new Aluno();
                    if (item != null)
                    {
                        dia.ID = int.Parse(item["AlunoID"].ToString());
                    }
                    dia.Nome = item["Nome"].ToString();
                    dia.Numero = int.Parse(item["Numero"].ToString());
                    dia.Classe = int.Parse(item["Classe"].ToString());
                    dia.Sala = int.Parse(item["Sala"].ToString());
                    dia.Turma = item["Turma"].ToString();
                    dia.Ano = int.Parse(item["Ano"].ToString());
                    //dia.Criado = int.Parse(item["Criado"].ToString());
                    if (Classe != 0 && dia.Classe != Classe)
                    {
                        continue;
                    }

                    if (Sala != 0 && dia.Sala != Sala)
                    {
                        continue;
                    }
                    Turma = Turma.Trim().ToUpper();
                    if (!string.IsNullOrWhiteSpace(Turma) && dia.Turma != Turma)
                    {
                        continue;
                    }
                    lista.Add(dia);
                }
            }
            return lista;
        }
        public List<TotalDia> GetPagamentosDia(DateTime data)
        {
            var lista = new List<TotalDia>();
            var paga = db.GetFromDay(data.Date);
            foreach (JPDataSet.PagementosRow item in paga.Rows)
            {
                var dia = new TotalDia();
                dia.IDaluno = item.IDAluno;
                dia.NomeAluno = item["Nome"].ToString();
                dia.Classe = item["Classe"].ToString() + "ªClasse";
                dia.Data = item.Data;
                dia.Propina = item.Propina;
                dia.Multa = item.Multa;
                dia.Criado = item.Criado;
                dia.Total = (dia.Propina + dia.Multa);
                lista.Add(dia);
            }
            return lista;
        }
        public decimal GetPagamentosTotal(DateTime data)
        {
            var paga = db.GetDate(data.Date);
            decimal total = 0;
            foreach (var item in paga)
            {
                total += (item.Propina + item.Multa);
            }
            return total;
        }
        public List<int> Meses()
        {
            var lista = new List<int>();
            foreach (var item in _lista)
            {
                lista.Add(item.Data.Month);
            }
            return lista;
        }

        public List<int> Meses(int mes)
        {
            var lista = new List<int>();
            foreach (var item in _lista)
            {
                if (item.Data.Month != mes)
                {
                    lista.Add(item.Data.Month);
                }
            }
            return lista;
        }
        public void Add(Pagamento paga)
        {
            db.Novo(paga.IDAluno, paga.Multa, paga.Propina, paga.Data, DateTime.Now.Date, paga.DVM, paga.TPA);
        }

        public void Apagar(Pagamento paga)
        {
            db.DeletePagamento(paga.ID);
        }
        public void Apagar(Aluno aluno)
        {
            db.DeletarPaluno(aluno.ID);
        }
        public void Atualizar(Pagamento paga)
        {
            db.Atualizar(paga.IDAluno, paga.Multa, paga.Propina, paga.Data, paga.DVM, paga.TPA, paga.ID);
        }

    }
}
