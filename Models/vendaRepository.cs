using System.Collections.Generic; // Biblioteca (BANCO DE DADOS E LISTA)
using System.Data.SqlClient;
using MySqlConnector;
using System; // Biblioteca (CONSOLE E FUNÇÃO WRITE LINE)
using System.Text;

namespace Atividade_2.Models {

public class VendaRepository {

private const string _strConexao = "Database= destino; Data Source= localhost; User Id= root; Password= teste";


        public void Inserir(venda novaVenda) {

            MySqlConnection Conexao = new MySqlConnection(_strConexao);

            Conexao.Open();

            string sql = "INSERT INTO venda(conceito, email, nome, fone, idade) VALUES (@conceito, @email, @nome, @fone, @idade)";

            MySqlCommand Comando = new MySqlCommand(sql, Conexao);

            Comando.Parameters.AddWithValue("@conceito", novaVenda.conceito);

            Comando.Parameters.AddWithValue("@email", novaVenda.email);

            Comando.Parameters.AddWithValue("@nome", novaVenda.nome);

            Comando.Parameters.AddWithValue("@fone", novaVenda.fone);

            Comando.Parameters.AddWithValue("@idade", novaVenda.idade);

            Comando.ExecuteNonQuery();

            Conexao.Close();

        } // MÉTODO INSERIR
    
}

} // OK