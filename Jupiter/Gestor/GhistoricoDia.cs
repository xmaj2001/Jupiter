using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Gestor
{
    public class GhistoricoDia
    {
        private List<HistoricoDia> Dias = new List<HistoricoDia>();
        private Gpagamentos gir = new Gpagamentos();
        private List<TotalDia> totalDias = new List<TotalDia>();
        private JPDataSetTableAdapters.DiapagamentoTableAdapter db = new JPDataSetTableAdapters.DiapagamentoTableAdapter();
        public List<HistoricoDia> GetDias()
        {
            Dias.Clear();
            foreach (var item in db.GetData())
            {
                var Total = gir.GetPagamentosTotal(item.Dia);
                var h = new HistoricoDia() { Dia = item.Dia, Total = Total };
                Dias.Add(h);
            }
            return Dias;
        }
        public void Load()
        {
            Dias.Clear();
            foreach (var item in db.GetData())
            {
                var Total = gir.GetPagamentosTotal(item.Dia);
                var h = new HistoricoDia() { Dia = item.Dia, Total = Total };
                Dias.Add(h);
            }
        }

        public List<HistoricoDia> Find(string date)
        {
            var pesquisados = new List<HistoricoDia>();
            foreach (var item in db.FindDia(date))
            {
                var Total = gir.GetPagamentosTotal(item.Dia);
                var h = new HistoricoDia() { Dia = item.Dia, Total = Total };
                pesquisados.Add(h);
            }
            return pesquisados;
        }
        public decimal TotalDia(DateTime date)
        {
            var dia = Dias.Find(d => d.Dia.Date == date.Date);
            if (dia != null) return dia.Total;
            return 0;
        }

        public void addDia(DateTime date)
        {
            var vv = db.VerificarDia(date);
            if (vv.Count == 0)
            {
                db.NovoDia(date);
            }  
        }
    }
}
