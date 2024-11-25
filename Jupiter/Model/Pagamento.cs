using Jupiter.Gestor;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Jupiter.Model
{
    public class Pagamento
    {
        public int ID { get; set; }
        public int IDAluno { get; set; }
        public decimal Propina { get; set; }
        public decimal Multa { get; set; }
        public string MultaInfo { get; set; }
        public string TipoInfo { get; set; }
        public DateTime Data { get; set; }
        public DateTime Criado { get; set; }
        public DateTime Create { get; set; }
        public bool DVM { get; set; }
        public bool TPA { get; set; }

        public decimal Total { get; set; }

        public Pagamento() {
            this.DVM = false;
        }
        public Pagamento(JPDataSet.PagementosRow paga) {
            this.ID = paga.ID;
            this.IDAluno = paga.IDAluno;
            this.Propina = paga.Propina;
            this.Multa = paga.Multa;
            this.Data = paga.Data;
            this.Criado = paga.Criado;
            this.Create = paga.create;
            this.DVM = paga.DVM;
            this.TPA = paga.TPA;
            MultaInfo = Multa.ToString("C", new CultureInfo("pt-AO"));
            if (this.DVM)
            {
                MultaInfo = "ADEVER";
            }
            if (this.TPA)
            {
                TipoInfo = "TRANSFERÊNCIA";
            }
            else
            {
                TipoInfo = "DINHEIRO";
            }
            this.Total = paga.Propina + paga.Multa;
        }
    }
}
