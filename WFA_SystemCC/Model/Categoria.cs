using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Categoria
    {
        public Categoria()
        {
        }

        private int codcategoria;
        private string nome;

        public int Codcategoria
        {
            get
            {
                return codcategoria;
            }

            set
            {
                codcategoria = value;
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
    }
}
