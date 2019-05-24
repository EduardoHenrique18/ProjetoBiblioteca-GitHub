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
        private String tituloLivro;
        private String editoraLivro;
        private int situaçao;
        private String autor;

        private AluguelBC aluguel;
       
        public LivroBC()
        {
            this.aluguel = new AluguelBC();
        }

        public int CodLivro { get => codLivro; set => codLivro = value; }
        public String TituloLivro { get => tituloLivro; set => tituloLivro = value; }
        public String EditoraLivro { get => editoraLivro; set => editoraLivro = value; }
        public int Situaçao { get => situaçao; set => situaçao = value; }
        public String Autor { get => autor; set => autor = value; }
        internal AluguelBC Aluguel { get => aluguel; set => aluguel = value; }

        
    }
}
