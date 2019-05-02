using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;

namespace ClassesBasicas.Usuario
{
    class UsuarioDados : Conexao, IUsuarioInterface
    {
        public void AlterarProduto(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void CadastrarUsuario(UsuarioBC u)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "insert into Usuario (cpfUsuario, nomeUsuario, dt_NascUsuario) ";
                sql += "values(@cpfUsuario, @nomeUsuario, @dt_NascUsuario)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfUsuario", SqlDbType.VarChar);
                cmd.Parameters["@cpfUsuario"].Value = u.CpfLeitor;

                cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar);
                cmd.Parameters["@nomeUsuario"].Value = u.NomeLeitor;

                cmd.Parameters.Add("@dt_NascUsuario", SqlDbType.VarChar);
                cmd.Parameters["@dt_NascUsuario"].Value = u.DtNascimento;              

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }

        public List<UsuarioBC> ListarProdutos(UsuarioBC u)
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto(UsuarioBC u)
        {
            throw new NotImplementedException();
        }
    }
}
