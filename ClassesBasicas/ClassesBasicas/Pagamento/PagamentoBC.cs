using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Usuario;

namespace ClassesBasicas.Pagamento
{
    public class PagamentoBC
    {
        private int idPagamento;
        private float valorPagamento;

        private UsuarioBC usuario;
        

        public PagamentoBC()
        {
            
        }

        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public float ValorPagamento { get => valorPagamento; set => valorPagamento = value; }
        internal UsuarioBC Usuario { get => usuario; set => usuario = value; }

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
