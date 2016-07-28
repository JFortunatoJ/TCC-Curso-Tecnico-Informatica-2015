using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Estoque
    {
        public Estoque() { }

        private int codEstoque;
        private string nomeEstoque;
        private float valorEstoque;
        private int qtdTiposProduto;
        private int qtdProdutos;

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

        public string NomeEstoque
        {
            get
            {
                return nomeEstoque;
            }

            set
            {
                nomeEstoque = value;
            }
        }

        public float ValorEstoque
        {
            get
            {
                return valorEstoque;
            }

            set
            {
                valorEstoque = value;
            }
        }

        public int QtdTiposProduto
        {
            get
            {
                return qtdTiposProduto;
            }

            set
            {
                qtdTiposProduto = value;
            }
        }

        public int QtdProdutos
        {
            get
            {
                return qtdProdutos;
            }

            set
            {
                qtdProdutos = value;
            }
        }
    }
}
