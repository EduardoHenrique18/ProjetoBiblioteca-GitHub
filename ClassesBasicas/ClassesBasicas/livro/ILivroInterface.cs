using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Livro
{
    interface ILivroInterface
    {
        void CadastrarLivro(LivroBC l);
        void AlterarLivro(LivroBC l);
        void RemoverLivro(LivroBC l);
        List<LivroBC> ListarLivros(LivroBC l);

    }
}
