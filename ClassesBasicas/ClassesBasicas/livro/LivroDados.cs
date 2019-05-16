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
        public void AlterarProduto(LivroBC l)
        {
       
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "UPDATE livros SET titulolivro = @titulolivro, editoralivro = @editoralivro,  ";
                sql += "qtdlivro = @qtdlivro, situacao = @situacao, autor = @autor WHERE codlivro = @codlivro";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
    
                cmd.Parameters.Add("@titulolivro", SqlDbType.VarChar);
                cmd.Parameters["@titulolivro"].Value = l.TituloLivro;

                cmd.Parameters.Add("@editoralivro", SqlDbType.VarChar);
                cmd.Parameters["@editoralivro"].Value = l.EditoraLivro;

                cmd.Parameters.Add("@qtdlivro", SqlDbType.Integer);
                cmd.Parameters["@qtdlivro"].Value = l.QntLivro;

                cmd.Parameters.Add("@situacao", SqlDbType.Integer);
                cmd.Parameters["@situacao"].Value = l.Situaçao;

                cmd.Parameters.Add("@autor", SqlDbType.VarChar);
                cmd.Parameters["@autor"].Value = l.Autor;

                cmd.Parameters.Add("@codlivro", SqlDbType.Integer);
                cmd.Parameters["@codlivro"].Value = l.CodLivro;

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

        public void CadastrarProduto(LivroBC l)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "insert into livros ( titulolivro, editoralivro, qtdlivro, situacao,autor)";
                sql += "values(@titulolivro, @editoralivro, @qtdlivro, @situacao, @autor)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@titulolivro", SqlDbType.VarChar);
                cmd.Parameters["@titulolivro"].Value = l.TituloLivro;

                cmd.Parameters.Add("@editoralivro", SqlDbType.VarChar);
                cmd.Parameters["@editoralivro"].Value = l.EditoraLivro ;

                cmd.Parameters.Add("@qtdlivro", SqlDbType.Integer);
                cmd.Parameters["@qtdlivro"].Value = l.QntLivro;

                cmd.Parameters.Add("@situacao", SqlDbType.Integer);
                cmd.Parameters["@situacao"].Value = l.Situaçao;

                cmd.Parameters.Add("@autor", SqlDbType.VarChar);
                cmd.Parameters["@autor"].Value = l.Autor;


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

        public List<LivroBC> ListarProdutos(LivroBC filtro)
        {
            List<LivroBC> retorno = new List<LivroBC>();       
            
            //abrir a conexão
            this.AbrirConexao();
            //instrução sql correspondente a inserção do aluno
            String sql = "select l.codlivro, l.titulolivro, l.editoralivro, l.qtdlivro, l.situacao, l.autor";
            sql += " from livros as l ";
            sql += "Where l.codlivro IS NOT NULL ";

            if (filtro.CodLivro.ToString != null && filtro.CodLivro.ToString.Trim().Equals("") == false)
            {
                sql += " and l.codlivro like @codlivro ";
            }
            if (filtro.TituloLivro != null && filtro.TituloLivro.Trim().Equals("") == false)
            {
                sql += " and l.titulolivro like @titulolivro ";
            }
            if (filtro.EditoraLivro != null && filtro.EditoraLivro.Trim().Equals("") == false)
            {
                sql += " and l.editoralivro like @editoralivro ";
            }
            if (filtro.QntLivro != null && filtro.QntLivro.Trim().Equals("") == false)
            {
                sql += " and l.qtdlivro like @qtdlivro ";
            }
            if (filtro.Situaçao.ToString() != null && filtro.Situaçao.ToString().Trim().Equals("") == false)
            {
                sql += " and l.situacao like @situacao ";
            }
            if (filtro.Autor != null && filtro.Autor.Trim().Equals("") == false)
            {
                sql += " and l.autor like @autor ";
            }
           

            
            //instrucao a ser executada
            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            if (filtro.CodLivro.ToString != null && filtro.CodLivro.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@codlivro", SqlDbType.VarChar);
                cmd.Parameters["@codlivro"].Value = "%" + filtro.CodLivro.ToString + "%";                
            }                       
            if (filtro.TituloLivro != null && filtro.TituloLivro.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@titulolivro", SqlDbType.VarChar);
                cmd.Parameters["@titulolivro"].Value = "%" + filtro.TituloLivro + "%";
            }
            if (filtro.EditoraLivro != null && filtro.EditoraLivro.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@editoralivro", SqlDbType.VarChar);
                cmd.Parameters["@editoralivro"].Value = "%" + filtro.EditoraLivro + "%";
            }
            if (filtro.QntLivro.ToString != null && filtro.QntLivro.ToString.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@qtdlivro", SqlDbType.VarChar);
                cmd.Parameters["@qtdlivro"].Value = "%" + filtro.QntLivro.ToString + "%";
            }
            if (filtro.Situaçao.ToString() != null && filtro.Situaçao.ToString().Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@situacao", SqlDbType.VarChar);
                cmd.Parameters["@situacao"].Value = "%" + filtro.Situaçao.ToString() + "%";
            }
            if (filtro.Autor != null && filtro.Autor.Trim().Equals("") == false)
            {
                cmd.Parameters.Add("@autor", SqlDbType.VarChar);
                cmd.Parameters["@autor"].Value = "%" + filtro.Autor + "%";
            }
           
            //cmd.ExecuteNonQuery();

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                LivroBC livro = new LivroBC();
                livro.CodLivro = Convert.ToInt32(rd["codlivro"]); //(rd.GetString(0));
                livro.TituloLivro = rd["titulolivro"].ToString(); //(rd.GetString(1));
                livro.EditoraLivro = rd["editoralivro"].ToString(); //(rd.GetString(2));
                livro.QntLivro = Convert.ToInt32(rd["qtdlivro"]); //(rd.GetString(3));
                livro.Situaçao = Convert.ToInt32(rd["situacao"]); //(rd.GetInt32(4));
                livro.Autor = rd["autor"].ToString(); //(rd.GetString(5));
                retorno.Add(livro);
            }

            return retorno;
            

        }

        public void RemoverProduto(LivroBC l)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "DELETE FROM livros WHERE codlivro = @codlivro";                
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@codlivro", SqlDbType.Integer);
                cmd.Parameters["@codlivro"].Value = l.CodLivro;
               
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
