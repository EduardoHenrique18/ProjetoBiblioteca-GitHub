﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;

namespace ClassesBasicas.Livro
{
    class LivroDados : Conexao, ILivroInterface
    {
        public void AlterarProduto(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public void CadastrarProduto(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public List<LivroBC> ListarProdutos(LivroBC l)
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto(LivroBC l)
        {
            throw new NotImplementedException();
        }
    }
}
