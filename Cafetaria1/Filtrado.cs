using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetaria1
{
    public class Filtrado : ICafe
    {
        public string Descricao()
        {
            return "Café Filtrado";
        }

        public decimal Preco()
        {
            return 4.00M;
        }
    }
}
