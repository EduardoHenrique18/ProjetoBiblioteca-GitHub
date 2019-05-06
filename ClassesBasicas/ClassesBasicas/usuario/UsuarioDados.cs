using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;

namespace ClassesBasicas.Usuario
{
    public class UsuarioDados : Conexao, IUsuarioInterface
    {
        public void AlterarUsuario(UsuarioBC u)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "UPDATE Usuario SET nome_Usuario = @nome_Usuario, dt_Nasc_Usuario = @dt_Nasc_Usuario,  ";
                sql += "nm_Telefone = @nm_Telefone, status_Usuario = @status_Usuario WHERE cpf_usuario = @cpf_usuario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
    
                cmd.Parameters.Add("@nome_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@nome_Usuario"].Value = u.NomeUsuario;

                cmd.Parameters.Add("@dt_Nasc_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@dt_Nasc_Usuario"].Value = u.DtNascimento;

                cmd.Parameters.Add("@nm_telefone", SqlDbType.VarChar);
                cmd.Parameters["@nm_telefone"].Value = u.NmTelefone;

                cmd.Parameters.Add("@status_usuario", SqlDbType.VarChar);
                cmd.Parameters["@status_usuario"].Value = u.Status;

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = u.CpfUsuario;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e alterar " + ex.Message);
            }
        }

        public void CadastrarUsuario(UsuarioBC u)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "insert into Usuario (cpf_Usuario, nome_Usuario, dt_Nasc_Usuario, nm_Telefone, status_Usuario) ";
                sql += "values(@cpf_Usuario, @nome_Usuario, @dt_Nasc_Usuario, @nm_Telefone, @status_Usuario)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = u.CpfUsuario;

                cmd.Parameters.Add("@nome_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@nome_Usuario"].Value = u.NomeUsuario;

                cmd.Parameters.Add("@dt_Nasc_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@dt_Nasc_Usuario"].Value = u.DtNascimento;

                cmd.Parameters.Add("@nm_telefone", SqlDbType.VarChar);
                cmd.Parameters["@nm_telefone"].Value = u.NmTelefone;

                cmd.Parameters.Add("@status_usuario", SqlDbType.VarChar);
                cmd.Parameters["@status_usuario"].Value = u.Status;


                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public List<UsuarioBC> ListarUsuario(UsuarioBC filtro)
        {
            List<UsuarioBC> retorno = new List<UsuarioBC>();       
            
            //abrir a conexão
            this.AbrirConexao();
            //instrução sql correspondente a inserção do aluno
            String sql = "select u.cpf_usuario, u.nome_usuario, u.dt_nasc_usuario, u.nm_telefone, u.status_usuario, u.endereco_Usuario, u.sexo";
            sql += " from usuario as u ";
            sql += "Where u.cpf_usuario IS NOT NULL ";

            if (filtro.CpfUsuario != null && filtro.CpfUsuario.Trim().Equals("") == false)
            {
                sql += " and u.cpf_usuario like @cpf_usuario ";
            }
            if (filtro.NomeUsuario != null && filtro.NomeUsuario.Trim().Equals("") == false)
            {
                sql += " and u.nome_usuario like @nome_usuario ";
            }
            if (filtro.DtNascimento != null && filtro.DtNascimento.Trim().Equals("") == false)
            {
                sql += " and u.dt_nasc_usuario like @dt_nasc_usuario ";
            }
            if (filtro.NmTelefone != null && filtro.NmTelefone.Trim().Equals("") == false)
            {
                sql += " and u.nm_Telefone like @nm_Telefone ";
            }
            if (filtro.Status.ToString() != null && filtro.Status.ToString().Trim().Equals("") == false)
            {
                sql += " and u.status_Usuario like @status_Usuario ";
            }
            if (filtro.Endereco != null && filtro.Endereco.Trim().Equals("") == false)
            {
                sql += " and u.endereco_Usuario like @endereco_Usuario ";
            }
            if (filtro.Sexo != null && filtro.Sexo.Trim().Equals("") == false)
            {
                sql += " and u.sexo like @sexo ";
            }

            
            //instrucao a ser executada
            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            if (filtro.CpfUsuario != null && filtro.CpfUsuario.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = "%" + filtro.CpfUsuario + "%";                
            }                       
            if (filtro.NomeUsuario != null && filtro.NomeUsuario.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@nome_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@nome_Usuario"].Value = "%" + filtro.NomeUsuario + "%";
            }
            if (filtro.DtNascimento != null && filtro.DtNascimento.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@dt_Nasc_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@dt_Nasc_Usuario"].Value = "%" + filtro.DtNascimento + "%";
            }
            if (filtro.NmTelefone != null && filtro.NmTelefone.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@nm_Telefone", SqlDbType.VarChar);
                cmd.Parameters["@nm_Telefone"].Value = "%" + filtro.NmTelefone + "%";
            }
            if (filtro.Status.ToString() != null && filtro.Status.ToString().Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@status_usuario", SqlDbType.VarChar);
                cmd.Parameters["@status_usuario"].Value = "%" + filtro.Status.ToString() + "%";
            }
            if (filtro.Endereco != null && filtro.Endereco.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@endereco_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@endereco_Usuario"].Value = "%" + filtro.Endereco + "%";
            }
            if (filtro.Sexo != null && filtro.Sexo.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@sexo", SqlDbType.VarChar);
                cmd.Parameters["@sexo"].Value = "%" + filtro.Sexo + "%";
            }
            //cmd.ExecuteNonQuery();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                UsuarioBC usuario = new UsuarioBC();
                usuario.CpfUsuario = rd["cpf_usuario"].ToString(); //(rd.GetString(0));
                usuario.NomeUsuario = rd["nome_Usuario"].ToString(); //(rd.GetString(1));
                usuario.DtNascimento = rd["dt_Nasc_Usuario"].ToString(); //(rd.GetString(2));
                usuario.NmTelefone = rd["nm_Telefone"].ToString(); //(rd.GetString(3));
                usuario.Status = Convert.ToInt32(rd["status_usuario"]); //(rd.GetInt32(4));
                usuario.Endereco = rd["endereco_Usuario"].ToString(); //(rd.GetString(5));
                usuario.Sexo = rd["sexo"].ToString(); //(rd.GetString(6));
                retorno.Add(usuario);
            }

            return retorno;
            




        }

        public void RemoverUsuario(UsuarioBC u)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "DELETE FROM Usuario WHERE cpf_usuario = @cpf_usuario";                
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = u.CpfUsuario;
               
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }
    }
    
}
