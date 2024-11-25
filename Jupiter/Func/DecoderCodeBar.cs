using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Func
{
   public class DecoderCodeBar
    {
        public static BarcodeAluno Decoder(string code)
        {
            var num = true;
            var id = "";
            var ano = "";
            foreach (var item in code)
            {
                if(item == '-')
                {
                    num = false;
                }

                if (num)
                {
                    id += item;
                }
                else if (item != '-')
                {
                    ano += item;
                }
            }

            if(Validar.IsNumero(id) && Validar.IsNumero(ano))
            {
                return new BarcodeAluno(int.Parse(id), int.Parse(ano));
            }
            else
            {
                return null;
            }
        }
    }
}
