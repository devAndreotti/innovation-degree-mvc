using System.Collections.Generic; // Biblioteca (BANCO DE DADOS E LISTA)
using System.Data.SqlClient;
using MySqlConnector;
using System; // Biblioteca (CONSOLE E FUNÇÃO WRITE LINE)
using System.Text;

namespace Atividade_2.Models {

public class UsuariosRepository {

private const string _strConexao = "Database= destino; Data Source= localhost; User Id= root; Password= teste";


        public void Insert(usuarios novoUsuario) {

            MySqlConnection conexao = new MySqlConnection(_strConexao);

            conexao.Open();

            string sql = "INSERT INTO usuarios(nome, login, senha, nascimento) VALUES (@nome, @login, @senha, @nascimento)";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", novoUsuario.nome);

            comando.Parameters.AddWithValue("@login", novoUsuario.login);

            comando.Parameters.AddWithValue("@senha", novoUsuario.senha);

            comando.Parameters.AddWithValue("@nascimento", novoUsuario.nascimento);

            comando.ExecuteNonQuery();
            
            conexao.Close();
        
        } // MÉTODO INSERIR


        public usuarios QueryLogin(usuarios u) {

            MySqlConnection conexao = new MySqlConnection(_strConexao);

            conexao.Open();

            string sql = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";

            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);

            comandoQuery.Parameters.AddWithValue("@login", u.login);

            comandoQuery.Parameters.AddWithValue("@senha", u.senha);

            MySqlDataReader reader = comandoQuery.ExecuteReader();

            usuarios usr = null;

            while (reader.Read()) {

                usr = new usuarios();

                usr.id = reader.GetInt32("id");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                {
                usr.nome = reader.GetString("nome");
                }

                 if (!reader.IsDBNull(reader.GetOrdinal("login"))) 
                 {
                usr.nome = reader.GetString("login");
                 }

                 if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                 {
                usr.nome = reader.GetString("senha");
                 }

            }

            conexao.Close();
            return usr;

        }
    
}

} // OK