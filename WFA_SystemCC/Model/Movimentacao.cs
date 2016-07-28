using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Movimentacao
    {
        public Movimentacao() { }

        private int codMov;
        private int codTipo;
        private int codEstoque;
        private int codItem;
        private int qtd;

        public int CodMov
        {
            get
            {
                return codMov;
            }

            set
            {
                codMov = value;
            }
        }

        public int CodTipo
        {
            get
            {
                return codTipo;
            }

            set
            {
                codTipo = value;
            }
        }

        public int CodEstoque
        {
            get
            {
                return codEstoque;
            }

            set
            {
                codEstoque = value;
            }
        }

        public int CodItem
        {
            get
            {
                return codItem;
            }

            set
            {
                codItem = value;
            }
        }

        public int Qtd
        {
            get
            {
                return qtd;
            }

            set
            {
                qtd = value;
            }
        }
    }
}
