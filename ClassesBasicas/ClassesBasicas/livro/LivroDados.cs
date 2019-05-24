using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasicas.conexao;

namespace ClassesBasicas.Livro
{
    class LivroDados : Conexao, ILivroInterface
    {
        #region Método Cadastrar
        public void CadastrarProduto(LivroBC l)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "insert into Livro (titulo_Livro, editora_Livro, situacao_Livro, autor_Livro) ";
                sql += "values (@titulo_Livro, @editora_Livro, @situacao_Livro, @autor_Livro)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@@titulo_Livro", SqlDbType.VarChar);
                cmd.Parameters["@titulo_Livro"].Value = l.TituloLivro;

                cmd.Parameters.Add("@editora_Livro", SqlDbType.VarChar);
                cmd.Parameters["@editora_Livro"].Value = l.EditoraLivro ;

                cmd.Parameters.Add("@situacao_Livro", SqlDbType.Integer);
                cmd.Parameters["@situacao_Livro"].Value = l.Situaçao;

                cmd.Parameters.Add("@autor_Livro", SqlDbType.VarChar);
                cmd.Parameters["@autor_Livro"].Value = l.Autor;


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
        #endregion
        #region Método Alterar
        public void AlterarProduto(LivroBC l)
        {
       
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "UPDATE Livro SET titulo_Livro = @titulo_Livro, editora_Livro = @editora_Livro,  ";
                sql += "situacao_Livro = @situacao_Livro, autor_Livro = @autor_Livro WHERE id_Livro = @id_Livro";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
    
                cmd.Parameters.Add("@titulo_Livro", SqlDbType.VarChar);
                cmd.Parameters["@titulo_Livro"].Value = l.TituloLivro;

                cmd.Parameters.Add("@editora_Livro", SqlDbType.VarChar);
                cmd.Parameters["@editora_Livro"].Value = l.EditoraLivro;

                cmd.Parameters.Add("situacao_Livro", SqlDbType.Integer);
                cmd.Parameters["situacao_Livro"].Value = l.Situaçao;

                cmd.Parameters.Add("@autor_Livro", SqlDbType.VarChar);
                cmd.Parameters["@autor_Livro"].Value = l.Autor;

                cmd.Parameters.Add("@id_Livro", SqlDbType.Integer);
                cmd.Parameters["@id_Livro"].Value = l.CodLivro;

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
        #region Método Listar
        public List<LivroBC> ListarProdutos(LivroBC filtro)
        {
            List<LivroBC> retorno = new List<LivroBC>();       
            
            //abrir a conexão
            this.AbrirConexao();
            //instrução sql correspondente a inserção do aluno
            String sql = "select l.id_Livro, l.titulo_Livro, l.editora_Livro, l.situacao_Livro, l.autor_Livro";
            sql += " from Livro as l ";
            sql += "Where l.id_Livro IS NOT NULL ";

            if (filtro.CodLivro.ToString != null && filtro.CodLivro.ToString.Trim().Equals("") == false)
            {
                sql += " and l.id_Livro like @id_Livro ";
            }
            if (filtro.TituloLivro != null && filtro.TituloLivro.Trim().Equals("") == false)
            {
                sql += " and l.titulo_Livro like @titulo_Livro ";
            }
            if (filtro.EditoraLivro != null && filtro.EditoraLivro.Trim().Equals("") == false)
            {
                sql += " and l.editora_Livro like @editora_Livro ";
            }

            if (filtro.Situaçao.ToString() != null && filtro.Situaçao.ToString().Trim().Equals("") == false)
            {
                sql += " and l.situacao_Livro like @situacao_Livro ";
            }
            if (filtro.Autor != null && filtro.Autor.Trim().Equals("") == false)
            {
                sql += " and l.autor_Livro like @autor_Livro ";
            }
           

            
            //instrucao a ser executada
            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            if (filtro.CodLivro.ToString != null && filtro.CodLivro.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("id_Livro", SqlDbType.VarChar);
                cmd.Parameters["@id_Livro"].Value = "%" + filtro.CodLivro.ToString + "%";                
            }                       
            if (filtro.TituloLivro != null && filtro.TituloLivro.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@titulo_Livro", SqlDbType.VarChar);
                cmd.Parameters["@titulo_Livro"].Value = "%" + filtro.TituloLivro + "%";
            }
            if (filtro.EditoraLivro != null && filtro.EditoraLivro.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@editora_Livro", SqlDbType.VarChar);
                cmd.Parameters["@editora_Livro"].Value = "%" + filtro.EditoraLivro + "%";
            }
            if (filtro.Situaçao.ToString() != null && filtro.Situaçao.ToString().Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@situacao_Livro", SqlDbType.VarChar);
                cmd.Parameters["@situacao_Livro"].Value = "%" + filtro.Situaçao.ToString() + "%";
            }
            if (filtro.Autor != null && filtro.Autor.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@autor_Livro", SqlDbType.VarChar);
                cmd.Parameters["@autor_Livro"].Value = "%" + filtro.Autor + "%";
            }
           
            //cmd.ExecuteNonQuery();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                LivroBC livro = new LivroBC();
                livro.CodLivro = Convert.ToInt32(rd["id_Livro"]); //(rd.GetString(0));
                livro.TituloLivro = rd["titulo_Livro"].ToString(); //(rd.GetString(1));
                livro.EditoraLivro = rd["editora_Livro"].ToString(); //(rd.GetString(2));
                livro.Situaçao = Convert.ToInt32(rd["situacao_Livro"]); //(rd.GetInt32(4));
                livro.Autor = rd["autor_Livro"].ToString(); //(rd.GetString(5));
                retorno.Add(livro);
            }

            return retorno;
            

        }
        #endregion
        #region Método Remover
        public void RemoverProduto(LivroBC l)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "DELETE FROM Livro WHERE id_Livro = @id_Livro";                
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@id_Livro", SqlDbType.Integer);
                cmd.Parameters["@id_Livro"].Value = l.CodLivro;
               
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
