using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Item
    {
        public Item()
        {
        }

        private int codItem;
        private int codFornecedor;
        private int qtdEstoque;
        private float precoUnit;
        private int codCategoria;
        private string descricao;
        private int taxaLucro;
        private string obs;

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

        public int CodFornecedor
        {
            get
            {
                return codFornecedor;
            }

            set
            {
                codFornecedor = value;
            }
        }

        public int QtdEstoque
        {
            get
            {
                return qtdEstoque;
            }

            set
            {
                qtdEstoque = value;
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

        public int CodCategoria
        {
            get
            {
                return codCategoria;
            }

            set
            {
                codCategoria = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public int TaxaLucro
        {
            get
            {
                return taxaLucro;
            }

            set
            {
                taxaLucro = value;
            }
        }

        public string Obs
        {
            get
            {
                return obs;
            }

            set
            {
                obs = value;
            }
        }
    }
}
