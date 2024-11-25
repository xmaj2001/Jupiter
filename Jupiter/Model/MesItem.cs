using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Model
{
   public class MesItem
    {
        public string Nome { get; set; }
        public int Valor { get; set; }

        public MesItem(int valor)
        {
            Valor = valor;
            Nome = DateTimeFormatInfo.CurrentInfo.GetMonthName(valor).ToUpper();
        }
    }
}
