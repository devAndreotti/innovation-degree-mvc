using System.Collections.Generic; // Biblioteca (BANCO DE DADOS E LISTA)
using System.Data.SqlClient;
using MySqlConnector;
using System; // Biblioteca (CONSOLE E FUNÇÃO WRITE LINE)
using System.Text;

namespace Atividade_2.Models {

public class AgendamentoRepository {

private const string _strConexao = "Database= destino; Data Source= localhost; User Id= root; Password= teste";


        // public void testeConexao() {

            // MySqlConnection Conexao = new MySqlConnection(_strConexao);

            // Conexao.Open();

            // Console.WriteLine("CONSEGUI");

            // Conexao.Close(); TESTE ANTIGO


        public void Insert(agendamento novoAgendamento) {

            MySqlConnection Conexao = new MySqlConnection(_strConexao);

            Conexao.Open();

            string sql = "INSERT INTO agendamento(necessidade, email, nome, dataa, fone, idade) VALUES (@necessidade, @email, @nome, @dataa, @fone, @idade)";

            MySqlCommand Comando = new MySqlCommand(sql, Conexao);

            Comando.Parameters.AddWithValue("@necessidade", novoAgendamento.necessidade);

            Comando.Parameters.AddWithValue("@email", novoAgendamento.email);

            Comando.Parameters.AddWithValue("@nome", novoAgendamento.nome);

            Comando.Parameters.AddWithValue("@dataa", novoAgendamento.dataa);

            Comando.Parameters.AddWithValue("@fone", novoAgendamento.fone);

            Comando.Parameters.AddWithValue("@idade", novoAgendamento.idade);

            Comando.ExecuteNonQuery();

            Conexao.Close();

        } // MÉTODO INSERIR

}

} // OK