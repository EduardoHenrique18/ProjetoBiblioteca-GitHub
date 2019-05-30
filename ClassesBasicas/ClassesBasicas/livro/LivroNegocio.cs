using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Livro
{
    public class LivroNegocio : ILivroInterface
    {       
        public void AlterarLivro(LivroBC l)
        {
            if(l == null)
            {
                throw new Exception("Informar os dados do Livro");
            }
            if (l.CodLivro <= 0)
            {
                throw new Exception("Informar o código do Livro");
            }
            //Titulo
            if (string.IsNullOrEmpty(l.TituloLivro) == true)
            {
                throw new Exception("Informar o nome do Livro");
            }
            if (string.IsNullOrWhiteSpace(l.TituloLivro) == true)
            {
                throw new Exception("Informar o nome do Livro");
            }
            if(l.TituloLivro.Length > 30)
            {
                throw new Exception("Titulo do Livro Não pode Conter mais de 30 Caracteres");
            }
            //Editora
            if (string.IsNullOrEmpty(l.EditoraLivro) == true)
            {
                throw new Exception("Informar a Editora do Livro");
            }
            if (string.IsNullOrWhiteSpace(l.EditoraLivro) == true)
            {
                throw new Exception("Informar a Editora do Livro");
            }
            if(l.EditoraLivro.Length > 30)
            {
                throw new Exception("Nome da Editora do Livro Não pode Conter mais de 30 Caracteres");
            }
            //Situação
            if((l.Situaçao != 0) && (l.Situaçao != 1))
            {
                throw new Exception("Informe uma Situação Válida, 0 (Indisponivel) ou 1 (Disponivel)");
            }
            //Autor
            if (string.IsNullOrEmpty(l.Autor) == true)
            {
                throw new Exception("Informar o nome do Autor do Livro");
            }
            if (string.IsNullOrWhiteSpace(l.TituloLivro) == true)
            {
                throw new Exception("Informar o nome do Autor do Livro");
            }
            if(l.TituloLivro.Length > 30)
            {
                throw new Exception("Nome do Autor do Livro Não pode Conter mais de 30 Caracteres");
            }
            LivroDados dados = new LivroDados();

            LivroBC livro = new LivroBC();
            livro.CodLivro = l.CodLivro;

            if (dados.ListarLivros(livro).Count <= 0)
            {
                throw new Exception("O código referido não se encontra cadastrado");
            }
            dados.AlterarLivro(l);           
        }

    
        
        public void CadastrarLivro(LivroBC l)
        {
            if(l == null)
            {
                throw new Exception("Informar os dados do Livro");
            }            
            //Titulo
            if (string.IsNullOrEmpty(l.TituloLivro) == true)
            {
                throw new Exception("Informar o nome do Livro");
            }
            if (string.IsNullOrWhiteSpace(l.TituloLivro) == true)
            {
                throw new Exception("Informar o nome do Livro");
            }
            if(l.TituloLivro.Length > 30)
            {
                throw new Exception("Titulo do Livro Não pode Conter mais de 30 Caracteres");
            }
            //Editora
            if (string.IsNullOrEmpty(l.EditoraLivro) == true)
            {
                throw new Exception("Informar a Editora do Livro");
            }
            if (string.IsNullOrWhiteSpace(l.EditoraLivro) == true)
            {
                throw new Exception("Informar a Editora do Livro");
            }
            if(l.EditoraLivro.Length > 30)
            {
                throw new Exception("Nome da Editora do Livro Não pode Conter mais de 30 Caracteres");
            }                       
            //Autor
            if (string.IsNullOrEmpty(l.Autor) == true)
            {
                throw new Exception("Informar o nome do Autor do Livro");
            }
            if (string.IsNullOrWhiteSpace(l.TituloLivro) == true)
            {
                throw new Exception("Informar o nome do Autor do Livro");
            }
            if(l.TituloLivro.Length > 30)
            {
                throw new Exception("Nome do Autor do Livro Não pode Conter mais de 30 Caracteres");
            }
            LivroDados dados = new LivroDados();

            LivroBC livro = new LivroBC();
            livro.CodLivro = l.CodLivro;

            if (dados.ListarLivros(livro).Count > 0)
            {
                throw new Exception("O código referido já se encontra cadastrado");
            }
            dados.CadastrarLivro(l);            
        }
        
        public List<LivroBC> ListarLivros(LivroBC l)
        {           
            return new LivroDados().ListarLivros(l);
        }
        
        public void RemoverLivro(LivroBC l)
        {
            if(l == null)
            {
                throw new Exception("Informar os dados do Livro");
            }

            if (l.CodLivro <= 0)
            {
                throw new Exception("Informar o código do Livro");
            }
            LivroBC livro = new LivroBC();
            livro.CodLivro = l.CodLivro;
            LivroDados dados = new LivroDados();
            if (dados.ListarLivros(livro).Count <= 0)
            {
                throw new Exception("O código referido não se encontra cadastrado");
            }

            dados.RemoverLivro(l);
        }
        
    }
}
