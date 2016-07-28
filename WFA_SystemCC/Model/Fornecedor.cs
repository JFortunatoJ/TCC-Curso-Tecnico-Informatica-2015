using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Fornecedor
    {
        public Fornecedor()
        {
        }

        private int codFornecedor;
        private string nome;
        private string telefone;
        private string endereco;
        private string email;

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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
