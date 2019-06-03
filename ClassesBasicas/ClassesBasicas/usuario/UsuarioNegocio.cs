﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasicas.Usuario
{
    public class UsuarioNegocio : IUsuarioInterface
    {

        #region Método Alterar
        public void AlterarUsuario(UsuarioBC u)
        {

            if (u == null)
            {
                throw new Exception("Informar os dados do Usuário");
            }
            //CPF
            if (!string.IsNullOrEmpty(u.CpfUsuario))
            {
                throw new Exception("Informar o CPF do Usuário");
            }
            if (u.CpfUsuario.Length > 15)
            {
                throw new Exception("O CPF do Usuário Não pode Conter mais de 15 Caracteres");
            }
            //Nome
            if (string.IsNullOrEmpty(u.NomeUsuario))
            {
                throw new Exception("Informar o nome do Usuário");
            }
            if (string.IsNullOrWhiteSpace(u.NomeUsuario))
            {
                throw new Exception("Informar o nome do Usuário");
            }
            if (u.NomeUsuario.Length > 100)
            {
                throw new Exception("Nome do Usuário não pode conter mais de 100 caracteres");
            }
            //Status
            if (u.Status != 0 && u.Status != 1)
            {
                throw new Exception("Informar o Status do Usuário");
            }           
            //Telefone
            if (string.IsNullOrEmpty(u.NmTelefone))
            {
                throw new Exception("Informar o número de telefone do Usuário");
            }
            if (string.IsNullOrWhiteSpace(u.NmTelefone))
            {
                throw new Exception("Informar o número de telefone do Usuário");
            }
            if (u.NmTelefone.Length > 11)
            {
                throw new Exception("O Número do Telefone do Usuário Não pode Conter mais de 11 Caracteres");
            }
            //DatadeNascimento
            if (u.DtNascimento == null)
            {
                throw new Exception("Informar a data de nascimento do Usuário");
            }
            //Endereco
            if (string.IsNullOrEmpty(u.Endereco))
            {
                throw new Exception("Informar o endereco do Usuário");
            }
            if (string.IsNullOrWhiteSpace(u.Endereco))
            {
                throw new Exception("Informar o endereco do Usuário");
            }
            if (u.NomeUsuario.Length > 200)
            {
                throw new Exception("Endereco do Usuário não pode conter mais de 100 caracteres");
            }
            //Sexo
            if (string.IsNullOrEmpty(u.NomeUsuario))
            {
                throw new Exception("Informar o sexo do Usuário");
            }
            if (!u.Sexo.Equals("Masculino") && !u.Sexo.Equals("Feminino"))
            {
                throw new Exception("Sexo invalido");
            }
            UsuarioDados dados = new UsuarioDados();

            UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = u.CpfUsuario;

            if (dados.ListarUsuario(usuario).Count <= 0)
            {
                throw new Exception("O Usuário referido não se encontra cadastrado");
            }
            dados.AlterarUsuario(u);
        }

        #endregion
        #region Método Cadastrar

        public void CadastrarUsuario(UsuarioBC u)
        {
            if (u == null)
            {
                throw new Exception("Informar os dados do Usuário");
            }
            //CPF
            if (string.IsNullOrEmpty(u.CpfUsuario))
            {
                throw new Exception("Informar o CPF do Usuário");
            }
            if (u.CpfUsuario.Length > 15)
            {
                throw new Exception("O CPF do Usuário Não pode Conter mais de 15 Caracteres");
            }
            //Nome
            if (string.IsNullOrEmpty(u.NomeUsuario) == true)
            {
                throw new Exception("Informar o nome do Usuário");
            }
            if (string.IsNullOrWhiteSpace(u.NomeUsuario) == true)
            {
                throw new Exception("Informar o nome do Usuário");
            }
            if (u.NomeUsuario.Length > 100)
            {
                throw new Exception("Nome do Usuário não pode conter mais de 100 caracteres");
            }            
            //Telefone
            if (string.IsNullOrEmpty(u.NmTelefone) == true)
            {
                throw new Exception("Informar o número de telefone do Usuário");
            }
            if (string.IsNullOrWhiteSpace(u.NmTelefone) == true)
            {
                throw new Exception("Informar o número de telefone do Usuário");
            }
            if (u.NmTelefone.Length > 11)
            {
                throw new Exception("O Número do Telefone do Usuário Não pode Conter mais de 11 Caracteres");
            }
            //DatadeNascimento
            if (u.DtNascimento == null)
            {
                throw new Exception("Informar a data de nascimento do Usuário");
            }
            //Endereco
            if (string.IsNullOrEmpty(u.Endereco))
            {
                throw new Exception("Informar o endereco do Usuário");
            }
            if (string.IsNullOrWhiteSpace(u.Endereco))
            {
                throw new Exception("Informar o endereco do Usuário");
            }
            if (u.NomeUsuario.Length > 200)
            {
                throw new Exception("Endereco do Usuário não pode conter mais de 100 caracteres");
            }
            //Sexo
            if (string.IsNullOrEmpty(u.NomeUsuario))
            {
                throw new Exception("Informar o sexo do Usuário");
            }
            if (!u.Sexo.Equals("Masculino") && !u.Sexo.Equals("Feminino"))
            {
                throw new Exception("Sexo invalido");
            }

            UsuarioDados dados = new UsuarioDados();

            UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = u.CpfUsuario;

            if (dados.ListarUsuario(usuario).Count > 0)
            {
                throw new Exception("O Usuário referido ja se encontra cadastrado");
            }
            dados.CadastrarUsuario(u);
        }
        #endregion
        #region Método Listar

        public List<UsuarioBC> ListarUsuario(UsuarioBC u)
        {
            return new UsuarioDados().ListarUsuario(u);
        }
        #endregion
        #region Método Remover

        public void RemoverUsuario(UsuarioBC u)
        {
            if (u == null)
            {
                throw new Exception("Informar os dados do Usuário");
            }

            if (!string.IsNullOrEmpty(u.CpfUsuario))
            {
                throw new Exception("Informar o CPF do Usuário");
            }

            UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = u.CpfUsuario;
            UsuarioDados dados = new UsuarioDados();

            if (dados.ListarUsuario(usuario).Count <= 0)
            {
                throw new Exception("O Usuário referido não se encontra cadastrado");
            }

            dados.RemoverUsuario(u);
        }
        #endregion
    }
}
