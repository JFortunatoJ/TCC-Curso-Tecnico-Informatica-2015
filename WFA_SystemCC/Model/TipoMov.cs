using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class TipoMov
    {
        public TipoMov() { }

        private int codTipo;
        private string nome;
        private float totalMov;

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

        public float TotalMov
        {
            get
            {
                return totalMov;
            }

            set
            {
                totalMov = value;
            }
        }
    }
}
