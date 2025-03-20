﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public Conta(long numero)
        {
            _numero = numero;
            _saldo = 0;
        }

        public decimal Saldo 
        {
            get
            {
                return _saldo;
            }
            private set
            {
                _saldo = value;
            } 
        }
        public long Numero
        {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }
        }

        public void Depositar(decimal valor)
        {
            _saldo -= valor;
        }
    }
}
