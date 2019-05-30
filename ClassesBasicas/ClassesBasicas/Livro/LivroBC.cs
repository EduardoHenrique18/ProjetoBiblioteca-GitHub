using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Aluguel;

namespace ClassesBasicas.Livro
{
    [DataContract]
    public class LivroBC
    {
        private int codLivro;
        private String tituloLivro;
        private String editoraLivro;
        private int situaçao;
        private String autor;

        //private AluguelBC aluguel;
       
        public LivroBC()
        {
            this.situaçao = 1;
            //this.aluguel = new AluguelBC();
        }
        [DataMember(IsRequired = true)]
        public int CodLivro { get => codLivro; set => codLivro = value; }
        [DataMember(IsRequired = true)]
        public String TituloLivro { get => tituloLivro; set => tituloLivro = value; }
        [DataMember(IsRequired = true)]
        public String EditoraLivro { get => editoraLivro; set => editoraLivro = value; }
        [DataMember(IsRequired = true)]
        public int Situaçao { get => situaçao; set => situaçao = value; }
        [DataMember(IsRequired = true)]
        public String Autor { get => autor; set => autor = value; }
        //[DataMember(IsRequired = true)]
        //internal AluguelBC Aluguel { get => aluguel; set => aluguel = value; }

        
    }
}
