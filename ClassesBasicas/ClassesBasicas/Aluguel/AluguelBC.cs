using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;



namespace ClassesBasicas.Aluguel
{
    [DataContract]
    public class AluguelBC
    {
        private DateTime dtEmprestimo;
        private DateTime dtEntrega;
        private int valor;
        private int status;
        private LivroBC livro;
        private UsuarioBC usuario;
        private int id_Aluguel;

     
        public AluguelBC()
        {
            this.status = 1;
            this.Valor = 0;
            this.dtEmprestimo = DateTime.Today;
            this.dtEntrega = DtEmprestimo.AddDays(7);
            this.Livro = new LivroBC();
            this.usuario = new UsuarioBC();
            usuario.Status = 0;
            livro.Situaçao = 0;
            
        }
        [DataMember(IsRequired = true)]
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        [DataMember(IsRequired = true)]
        public DateTime DtEntrega { get => dtEntrega; set => dtEntrega = value; }
        [DataMember(IsRequired = true)]
        public LivroBC Livro { get => livro; set => livro = value; }
        [DataMember(IsRequired = true)]
        public UsuarioBC Usuario { get => usuario; set => usuario = value; }
        [DataMember(IsRequired = true)]
        public int Valor { get => valor; set => valor = value; }
        [DataMember(IsRequired = true)]
        public int Status { get => status; set => status = value; }
        [DataMember(IsRequired = true)]
        public int Id_Aluguel { get => id_Aluguel; set => id_Aluguel = value; }
    }
}
