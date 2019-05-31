using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;

namespace ClassesBasicas.Aluguel
{
    public class AluguelDados : Conexao, IAluguelInterface
    {

        #region Cadastrar
        public void cadastrarAluguel(AluguelBC a)
        {
            
            try
            {

                
                this.AbrirConexao();
                String sql = "insert into aluguel (dt_Emprestimo,dt_Entrega,cpf_Usuario,id_Livro) values (@dt_Emprestimo,@dt_Entrega,@cpf_Usuario,@id_Livro)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_Emprestimo", SqlDbType.Date);
                cmd.Parameters["@dt_Emprestimo"].Value = a.DtEmprestimo;

                cmd.Parameters.Add("@dt_Entrega", SqlDbType.Date);
                cmd.Parameters["@dt_Entrega"].Value = a.DtEntrega;

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = a.Usuario.CpfUsuario;

                cmd.Parameters.Add("@id_Livro", SqlDbType.Int);
                cmd.Parameters["@id_Livro"].Value = a.Livro.CodLivro;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao conectar cadastro " + ex.Message);
            }
        }
        #endregion
        #region Listar
        public List<AluguelBC> listarAluguel(AluguelBC filtro)
        {
            List<AluguelBC> retorno = new List<AluguelBC>();

            this.AbrirConexao();
            //instrução sql correspondente a inserção do aluno
            String sql = "select dt_Emprestimo, dt_Entrega,cpf_usuario, id_Livro";
            sql += " from Aluguel";
            sql += "Where cpf_usuario IS NOT NULL ";

            if (filtro.DtEmprestimo != null && filtro.DtEmprestimo.Equals("") == false)
            {
                sql += " and dt_Emprestimo like @dt_Emprestimo ";
            }
            if (filtro.DtEntrega != null && filtro.DtEntrega.Equals("") == false)
            {
                sql += " and dt_Entrega like @dt_Entrega ";
            }
            if (filtro.Usuario.CpfUsuario != null && filtro.Usuario.CpfUsuario.Trim().Equals("") == false)
            {
                sql += " and cpf_usuario like @cpf_usuario ";
            }
            if (filtro.Livro.CodLivro != 0 && filtro.Livro.CodLivro.Equals("") == false)
            {
                sql += " and codlivro like @codlivro ";
            }




            //instrucao a ser executada
            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            if (filtro.DtEmprestimo != null && filtro.DtEmprestimo.Equals("") == false)
            {
                cmd.Parameters.Add("@dt_Emprestimo", SqlDbType.Date);
                cmd.Parameters["@dt_Emprestimo"].Value = "%" + filtro.DtEmprestimo + "%";
            }
            if (filtro.DtEntrega != null && filtro.DtEntrega.Equals("") == false)
            {
                cmd.Parameters.Add("@dt_Entrega", SqlDbType.Date);
                cmd.Parameters["@dt_Entrega"].Value = "%" + filtro.DtEntrega + "%";
            }
            if (filtro.Usuario.CpfUsuario != null && filtro.Usuario.CpfUsuario.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@cpf_usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_usuario"].Value = "%" + filtro.Usuario.CpfUsuario + "%";
            }
            if (filtro.Livro.CodLivro != 0 && filtro.Livro.CodLivro.Equals("") == false)
            {
                cmd.Parameters.Add("@codlivro", SqlDbType.Int);
                cmd.Parameters["@codlivro"].Value = "%" + filtro.Livro.CodLivro + "%";
            }

            //cmd.ExecuteNonQuery();

            SqlDataReader rd = cmd.ExecuteReader();
          
            while (rd.Read())
            {

                AluguelBC aluguel = new AluguelBC();
                aluguel.DtEmprestimo =Convert.ToDateTime(rd["dt_Emprestimo"]); //(rd.GetString(0));
               aluguel.DtEntrega = Convert.ToDateTime(rd["dt_Entrega"]); //(rd.GetString(1));
                aluguel.Livro.CodLivro = Convert.ToInt32(rd["codlivro"]); //(rd.GetString(2));
                aluguel.Usuario.CpfUsuario = rd["cpf_usuario"].ToString(); //(rd.GetString(3));
                retorno.Add(aluguel);
            }
            return retorno;
           
        }
        #endregion
        #region Alterar
        public void alterarAluguel(AluguelBC a)
        {

            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "UPDATE Aluguel SET dt_Emprestimo = @dt_Emprestimo, dt_Entrega = @dt_Entrega,  ";
                sql += "WHERE cpf_Usuario = @cpf_Usuario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_Emprestimo", SqlDbType.Date);
                cmd.Parameters["@dt_Emprestimo"].Value = a.DtEmprestimo;

                cmd.Parameters.Add("@dt_Entrega", SqlDbType.Date);
                cmd.Parameters["@dt_Entrega"].Value = a.DtEntrega;

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = a.Usuario.CpfUsuario;

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
        #endregion
        #region Deletar
        public void deletarAluguel(AluguelBC a)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "DELETE FROM Aluguel WHERE cpf_Usuario = @cpf_Usuario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = a.Usuario.CpfUsuario;

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
        #endregion
    }
}
