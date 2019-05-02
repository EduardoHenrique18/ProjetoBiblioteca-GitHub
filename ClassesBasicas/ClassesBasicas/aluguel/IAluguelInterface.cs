using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Aluguel
{
    interface IAluguelInterface
    {
        void CadastrarProduto(AluguelBC a);
        void AlterarProduto(AluguelBC a);
        void RemoverProduto(AluguelBC a);
        List<AluguelBC> ListarProdutos(AluguelBC a);
    }
}
