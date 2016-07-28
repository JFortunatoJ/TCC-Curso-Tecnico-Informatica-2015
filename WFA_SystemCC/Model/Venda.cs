using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Venda
    {
        public Venda() { }

        private int codVenda;
        private DateTime dataVenda;
        private int codUsuario;
        private double totalVenda;

        public int CodVenda
        {
            get
            {
                return codVenda;
            }

            set
            {
                codVenda = value;
            }
        }

        public DateTime DataVenda
        {
            get
            {
                return dataVenda;
            }

            set
            {
                dataVenda = value;
            }
        }

        public int CodUsuario
        {
            get
            {
                return codUsuario;
            }

            set
            {
                codUsuario = value;
            }
        }

        public double TotalVenda
        {
            get
            {
                return totalVenda;
            }

            set
            {
                totalVenda = value;
            }
        }
    }
}
