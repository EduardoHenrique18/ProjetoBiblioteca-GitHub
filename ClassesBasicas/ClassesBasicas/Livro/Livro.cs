using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Aluguel;

namespace ClassesBasicas.Livro
{
    class Livro
    {
        private int codLivro;
        private char tituloLivro;
        private char editoraLivro;
        private int qntLivro;
        private Boolean situaçao;
        private char autor;

        private Aluguel aluguel;

        public Livro()
        {
            this.aluguel = new Aluguel();
        }

        public int CodLivro
        {
            get
            {
                return CodLivro1;
            }

            set
            {
                CodLivro1 = value;
            }
        }

        public char TituloLivro
        {
            get
            {
                return TituloLivro1;
            }

            set
            {
                TituloLivro1 = value;
            }
        }

        public char EditoraLivro
        {
            get
            {
                return EditoraLivro1;
            }

            set
            {
                EditoraLivro1 = value;
            }
        }

        public int QntLivro
        {
            get
            {
                return QntLivro1;
            }

            set
            {
                QntLivro1 = value;
            }
        }

        public bool Situaçao
        {
            get
            {
                return Situaçao1;
            }

            set
            {
                Situaçao1 = value;
            }
        }

        public char Autor
        {
            get
            {
                return Autor1;
            }

            set
            {
                Autor1 = value;
            }
        }

        public Aluguel Aluguel
        {
            get
            {
                return Aluguel1;
            }

            set
            {
                Aluguel1 = value;
            }
        }

        public int CodLivro1
        {
            get
            {
                return codLivro;
            }

            set
            {
                codLivro = value;
            }
        }

        public char TituloLivro1
        {
            get
            {
                return tituloLivro;
            }

            set
            {
                tituloLivro = value;
            }
        }

        public char EditoraLivro1
        {
            get
            {
                return editoraLivro;
            }

            set
            {
                editoraLivro = value;
            }
        }

        public int QntLivro1
        {
            get
            {
                return qntLivro;
            }

            set
            {
                qntLivro = value;
            }
        }

        public bool Situaçao1
        {
            get
            {
                return situaçao;
            }

            set
            {
                situaçao = value;
            }
        }

        public char Autor1
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public Aluguel Aluguel1
        {
            get
            {
                return aluguel;
            }

            set
            {
                aluguel = value;
            }
        }

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
