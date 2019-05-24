using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Livro
{
    interface ILivroInterface
    {
        void CadastrarProduto(LivroBC l);
        void AlterarProduto(LivroBC l);
        void RemoverProduto(LivroBC l);
        List<LivroBC> ListarProdutos(LivroBC l);

    }
}
