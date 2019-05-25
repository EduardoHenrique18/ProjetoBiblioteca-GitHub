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
    class AluguelDados : Conexao, IAluguelInterface
    {

        public void cadastrarAluguel(AluguelBC a)
        {
            try {
                this.AbrirConexao();
                String sql = "insert into aluguel (dtemprestimo,dtentrega,codlivro,cpf_usuario) values (@dtemprestimo,@dtentrega,@codlivro,@cpf_usuario)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dtemprestimo", SqlDbType.VarChar);
                cmd.Parameters["@dtemprestimo"].Value = a.DtEmprestimo;

                cmd.Parameters.Add("@dtentrega", SqlDbType.VarChar);
                cmd.Parameters["@dtentrega"].Value = a.DtEntrega;

                cmd.Parameters.Add("@codlivro", SqlDbType.Int);
                cmd.Parameters["@codlivro"].Value = a.Livro.CodLivro;

                cmd.Parameters.Add("@cpf_usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_usuario"].Value = a.Usuario.CpfUsuario;
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

        public void deletarAluguel(AluguelBC a)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "DELETE FROM aluguel WHERE cpf_usuario = @cpf_usuario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpf_usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_usuario"].Value = a.Usuario;

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

        public List<AluguelBC> listarAluguel(AluguelBC filtro)
        {
            List<AluguelBC> retorno = new List<AluguelBC>();

            //abrir a conexão
            this.AbrirConexao();
            //instrução sql correspondente a inserção do aluno
            String sql = "select dtemprestimo, dtentrega, codlivro, cpf_usuario";
            sql += " from aluguel";
            sql += "Where cpf_usuario IS NOT NULL ";

            if (filtro.DtEmprestimo != null && filtro.DtEmprestimo.Trim().Equals("") == false)
            {
                sql += " and dtemprestimo like @dtemprestimo ";
            }
            if (filtro.DtEntrega != null && filtro.DtEntrega.Trim().Equals("") == false)
            {
                sql += " and dtentrega like @dtentrega ";
            }
            if (filtro.Livro.CodLivro != null && filtro.Livro.CodLivro.Equals("") == false)
            {
                sql += " and codlivro like @codlivro ";
            }
            if (filtro.Usuario.CpfUsuario != null && filtro.Usuario.CpfUsuario.Trim().Equals("") == false)
            {
                sql += " and cpf_usuario like @cpf_usuario ";
            }
            



            //instrucao a ser executada
            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            if (filtro.DtEmprestimo != null && filtro.DtEmprestimo.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@dtemprestimo", SqlDbType.VarChar);
                cmd.Parameters["@dtemprestimo"].Value = "%" + filtro.DtEmprestimo + "%";
            }
            if (filtro.DtEntrega != null && filtro.DtEntrega.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@dtentrega", SqlDbType.VarChar);
                cmd.Parameters["@dtentrega"].Value = "%" + filtro.DtEntrega + "%";
            }
            if (filtro.Livro.CodLivro != null && filtro.Livro.CodLivro.Equals("") == false)
            {
                cmd.Parameters.Add("@codlivro", SqlDbType.Int);
                cmd.Parameters["@codlivro"].Value = "%" + filtro.Livro.CodLivro + "%";
            }
            if (filtro.Usuario.CpfUsuario!= null && filtro.Usuario.CpfUsuario.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@cpf_usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_usuario"].Value = "%" + filtro.Usuario.CpfUsuario + "%";
            }
            

            //cmd.ExecuteNonQuery();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                AluguelBC aluguel = new AluguelBC();
                aluguel.DtEmprestimo = Convert.ToString(rd["dtemprestimo"]); //(rd.GetString(0));
                aluguel.DtEntrega = rd["dtentrega"].ToString(); //(rd.GetString(1));
                aluguel.Livro.CodLivro = Convert.ToInt32(rd["codlivro"]); //(rd.GetString(2));
                aluguel.Usuario.CpfUsuario = rd["cpf_usuario"].ToString(); //(rd.GetString(3));
                retorno.Add(aluguel);
            }

            return retorno;

        }
    }
}
