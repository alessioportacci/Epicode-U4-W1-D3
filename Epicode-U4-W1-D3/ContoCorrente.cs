using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D3
{
    internal class ContoCorrente
    {
        private int Saldo { get; set; }
        public ContoCorrente(int saldo)
        {
            Saldo = saldo + 1000;
        }

        public void versamento(int saldo)
        {
            Saldo += saldo;
        }
        public void prelevamento(int saldo)
        {
            Saldo -= saldo;
        }
        public int getSaldo()
        {
            return Saldo;
        }
    }
}
