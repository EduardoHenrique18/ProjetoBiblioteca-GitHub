using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;
using ClassesBasicas.Livro;
using ClassesBasicas.Usuario;

namespace ClassesBasicas.Aluguel
{
    public class AluguelDados : Conexao, IAluguelInterface
    {

      
        public void CadastrarAluguel(AluguelBC a)
        {
            try
            {
                this.AbrirConexao();
                String sql = "insert into aluguel (dt_Emprestimo,dt_Entrega,cpf_Usuario,id_Livro, status_aluguel, valor_aluguel) " +
                             "values (@dt_Emprestimo,@dt_Entrega,@cpf_Usuario,@id_Livro,@status_aluguel,@valor_aluguel)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_Emprestimo", SqlDbType.Date);
                cmd.Parameters["@dt_Emprestimo"].Value = a.DtEmprestimo;

                cmd.Parameters.Add("@dt_Entrega", SqlDbType.Date);
                cmd.Parameters["@dt_Entrega"].Value = a.DtEntrega;

                cmd.Parameters.Add("@cpf_Usuario", SqlDbType.VarChar);
                cmd.Parameters["@cpf_Usuario"].Value = a.Usuario.CpfUsuario;

                cmd.Parameters.Add("@id_Livro", SqlDbType.Int);
                cmd.Parameters["@id_Livro"].Value = a.Livro.CodLivro;

                cmd.Parameters.Add("@status_aluguel", SqlDbType.Int);
                cmd.Parameters["@status_aluguel"].Value = a.Status;

                cmd.Parameters.Add("@valor_aluguel", SqlDbType.Int);
                cmd.Parameters["@valor_aluguel"].Value = a.Valor;

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
        
        public List<AluguelBC> ListarAluguel()
        {
            try
            {
                AluguelNegocio neg = new AluguelNegocio();
                List<AluguelBC> retorno = new List<AluguelBC>();
                this.AbrirConexao();
                //instrução sql correspondente a inserção do aluno
                String sql = "select a.id_Aluguel ,a.dt_Emprestimo, a.dt_Entrega, a.cpf_usuario, a.id_Livro, a.status_aluguel, a.valor_aluguel ";
                sql += "from Aluguel as a inner join usuario as u on a.cpf_usuario = u.cpf_usuario ";
                sql += "inner join livro as l on a.id_Livro = l.id_Livro ";
                sql += "Where a.status_aluguel > 0";

                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    AluguelBC aluguel = new AluguelBC();
                    aluguel.Id_Aluguel = Convert.ToInt32(rd["id_Aluguel"]);
                    aluguel.DtEmprestimo = Convert.ToDateTime((rd["dt_Emprestimo"])); //(rd.GetString(0));
                    aluguel.DtEntrega = Convert.ToDateTime(rd["dt_Entrega"].ToString()); //(rd.GetString(1));
                    aluguel.Livro.CodLivro = Convert.ToInt32(rd["id_livro"]); //(rd.GetString(2));
                    aluguel.Usuario.CpfUsuario = rd["cpf_usuario"].ToString(); //(rd.GetString(3));
                    aluguel.Status = Convert.ToInt32(rd["status_aluguel"]);
                    aluguel.Valor = Convert.ToInt32(rd["valor_aluguel"]);                   
                    neg.CalcularValor(aluguel);
                    retorno.Add(aluguel);

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao conectar listar " + ex.Message);
            }
        }
        
        public void AlterarAluguel(AluguelBC a)
        {

            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "UPDATE Aluguel SET dt_Emprestimo = @dt_Emprestimo, dt_Entrega = @dt_Entrega, status_aluguel = @status_aluguel, valor_aluguel = @valor_aluguel ";
                sql += "WHERE cpf_Usuario = @cpf_Usuario";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@dt_Emprestimo", SqlDbType.Date);
                cmd.Parameters["@dt_Emprestimo"].Value = a.DtEmprestimo;

                cmd.Parameters.Add("@dt_Entrega", SqlDbType.Date);
                cmd.Parameters["@dt_Entrega"].Value = a.DtEntrega;

                cmd.Parameters.Add("@status_aluguel", SqlDbType.Int);
                cmd.Parameters["@status_aluguel"].Value = a.Status;

                cmd.Parameters.Add("@valor_aluguel", SqlDbType.Int);
                cmd.Parameters["@valor_aluguel"].Value = a.Valor;

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
              

        public void CalcularValor(AluguelBC a)
        {
            int totalDias = DateTime.Today.Subtract(a.DtEntrega).Days;
            AluguelBC aluguel = new AluguelBC();
            aluguel = a;
            if (totalDias > 0) {
                aluguel.Valor = totalDias;
                AluguelNegocio neg = new AluguelNegocio();
                neg.AlterarAluguel(aluguel);
            }
        }

        public void ConfirmarEntrega(AluguelBC a)
        {
            //habilita o usuario a alugar novamente
            UsuarioBC usuario = new UsuarioBC();
            usuario.CpfUsuario = a.Usuario.CpfUsuario;
            UsuarioNegocio neg = new UsuarioNegocio();
            neg.AlterarUsuario(usuario);
            //deixa o aluguel off
            AluguelBC aluguel = new AluguelBC();
            aluguel.Usuario.CpfUsuario = a.Usuario.CpfUsuario;
            aluguel.Status = 0;
            AluguelNegocio alneg = new AluguelNegocio();
            alneg.AlterarAluguel(aluguel);
            //habilita o livro a alugar novamente
            LivroBC livro = new LivroBC();
            livro.CodLivro = a.Livro.CodLivro;
            LivroNegocio negl = new LivroNegocio();
            negl.AlterarLivro(livro);

        }
        
    }
}
