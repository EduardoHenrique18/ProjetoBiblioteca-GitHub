using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Usuario;

namespace ClassesBasicas.Pagamento
{
    class Pagamento
    {
        private int idPagamento;
        private float valorPagamento;

        private Usuario usuario;

        public Pagamento()
        {
            this.usuario = new Usuario();
        }

        public int IdPagamento
        {
            get
            {
                return idPagamento;
            }

            set
            {
                idPagamento = value;
            }
        }

        public float ValorPagamento
        {
            get
            {
                return valorPagamento;
            }

            set
            {
                valorPagamento = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public void cadastrarPagamento()
        {

        }

        public void listarPagamento()
        {

        }

        public void deletarPagamento()
        {

        }
    }
}
