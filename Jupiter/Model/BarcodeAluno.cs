using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Model
{
    public class BarcodeAluno
    {
        public int ID { get; set; }
        public int Ano { get; set; }
        public BarcodeAluno() { }
        public BarcodeAluno(int id, int ano)
        {
            this.ID = id;
            this.Ano = ano;
        }
    }
}
