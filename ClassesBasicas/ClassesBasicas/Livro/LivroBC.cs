using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Aluguel;

namespace ClassesBasicas.Livro
{
    public class LivroBC
    {
        private int codLivro;
        private char tituloLivro;
        private char editoraLivro;
        private int qntLivro;
        private Boolean situaçao;
        private char autor;

        private AluguelBC aluguel;
       
        public LivroBC()
        {
            
        }

        public int CodLivro { get => codLivro; set => codLivro = value; }
        public char TituloLivro { get => tituloLivro; set => tituloLivro = value; }
        public char EditoraLivro { get => editoraLivro; set => editoraLivro = value; }
        public int QntLivro { get => qntLivro; set => qntLivro = value; }
        public bool Situaçao { get => situaçao; set => situaçao = value; }
        public char Autor { get => autor; set => autor = value; }
        internal AluguelBC Aluguel { get => aluguel; set => aluguel = value; }

        public void cadastrarLivro()
        {

        }

        public void listarLivro()
        {

        }

        public void deletarLivro()
        {

        }
    }
}
