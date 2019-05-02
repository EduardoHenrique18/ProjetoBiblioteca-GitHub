using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Pagamento;

namespace ClassesBasicas.Pagamento
{
    interface IPagamentoInterface
    {
        void CadastrarProduto(PagamentoBC p);
        void AlterarProduto(PagamentoBC p);
        void RemoverProduto(PagamentoBC p);
        List<PagamentoBC> ListarProdutos(PagamentoBC p);
    }
}
