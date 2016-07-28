using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SystemCC.Model
{
    class Tarefa
    {
        public Tarefa() { }

        private int codTarefa;
        private int codUsuario;
        private string titulo;
        private string descricao;
        private int rotina;
        private DateTime dataCriacao;

        public int CodTarefa
        {
            get
            {
                return codTarefa;
            }

            set
            {
                codTarefa = value;
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

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
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

        public int Rotina
        {
            get
            {
                return rotina;
            }

            set
            {
                rotina = value;
            }
        }

        public DateTime DataCriacao
        {
            get
            {
                return dataCriacao;
            }

            set
            {
                dataCriacao = value;
            }
        }
    }
}
