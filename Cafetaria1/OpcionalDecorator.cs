﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetaria1
{
    public abstract class OpcionalDecorator : ICafe
    {
        protected ICafe _cafe;
        protected string _opcional = "indefinido";
        protected decimal _preco = 0.00M;
        public OpcionalDecorator(ICafe cafe)
        {
            _cafe = cafe;
        }
        public string Descricao()
        {
            return _cafe.Descricao() + _opcional;
        }

        public decimal Preco()
        {
            return _cafe.Preco() + _preco;
        }
    }
}
