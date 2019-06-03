using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ClassesBasicas.Aluguel;


namespace ClassesBasicas.Usuario
{
    [DataContract]
    public class UsuarioBC
    {
        private String cpfUsuario;
        private String nomeUsuario;
        private DateTime dtNascimento;
        private String nmTelefone;
        private int status;
        private String endereco;
        private String sexo;

       
        private ICollection<AluguelBC> aluguel;

        
        public UsuarioBC()
        {
            this.Status = 1;          
        }
        [DataMember(IsRequired = true)]
        public string CpfUsuario { get => cpfUsuario; set => cpfUsuario = value; }
        [DataMember(IsRequired = true)]
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        [DataMember(IsRequired = true)]
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        [DataMember(IsRequired = true)]
        public string NmTelefone { get => nmTelefone; set => nmTelefone = value; }
        [DataMember(IsRequired = true)]
        public int Status { get => status; set => status = value; }
        [DataMember(IsRequired = true)]
        public string Endereco { get => endereco; set => endereco = value; }
        [DataMember(IsRequired = true)]
        public string Sexo { get => sexo; set => sexo = value; }
        [DataMember(IsRequired = true)]
        public ICollection<AluguelBC> Aluguel { get => aluguel; set => aluguel = value; }
        
    }
}
