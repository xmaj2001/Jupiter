using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jupiter.Func
{
    public class Validar
    {
        public static bool IsNumero(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }
            else if (!Regex.IsMatch(valor.Trim(), "^[0-9]+$"))
            {
                return false;
            }
            
            return true;
        }

        public static bool IsNome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }
            else if (valor.Length < 2)
            {
                return false;
            }
            else if (!Regex.IsMatch(valor, @"^[\p{L}a-zA-Z.]+(?: [\p{L}a-zA-Z.]+)*$"))
            {
                return false;
            }
            return true;
        }

        public static bool IsTurma(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }
            else if (!Regex.IsMatch(valor, @"^[a-zA-Z0-9ªº]+$"))
            {
                return false;
            }
            return true;
        }

        public static bool IsImagem(string valor)
        {
            var tipos = new List<string>() { ".png", ".jpg", ".bmp", ".jpeg" };
            if (tipos.Contains(valor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
