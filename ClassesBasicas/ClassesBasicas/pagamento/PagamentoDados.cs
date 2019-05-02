using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;

namespace ClassesBasicas.Pagamento
{
    class PagamentoDados : Conexao, IPagamentoInterface
    {
        public void AlterarProduto(PagamentoBC p)
        {
            throw new NotImplementedException();
        }

        public void CadastrarProduto(PagamentoBC p)
        {
            throw new NotImplementedException();
        }

        public List<PagamentoBC> ListarProdutos(PagamentoBC p)
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto(PagamentoBC p)
        {
            throw new NotImplementedException();
        }
    }
}
