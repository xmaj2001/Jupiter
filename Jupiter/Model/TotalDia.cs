using Jupiter.Gestor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Model
{
    public class TotalDia
    {
        public int IDaluno { get; set; }
        public string NomeAluno { get; set; }
        public string Classe { get; set; }
        public decimal Propina { get; set; }
        public decimal Multa { get; set; }
        public bool Apagado { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public DateTime Criado { get; set; }

        public TotalDia() { }
    }
}
