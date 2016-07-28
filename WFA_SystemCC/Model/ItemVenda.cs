using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class ItemVenda
    {
        public ItemVenda() { }

        private int codvenda;
        private int codItem;
        private int quantidade;
        private float precoUnit;

        public int Codvenda
        {
            get
            {
                return codvenda;
            }

            set
            {
                codvenda = value;
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

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public float PrecoUnit
        {
            get
            {
                return precoUnit;
            }

            set
            {
                precoUnit = value;
            }
        }
    }
}
