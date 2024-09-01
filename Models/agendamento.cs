// Importa as bibliotecas necessárias para trabalhar com coleções, conexões de banco de dados, e manipulação de dados.
using System.Collections.Generic; // Biblioteca para trabalhar com coleções como listas e dicionários
using System.Data.SqlClient; // Biblioteca para conectar e executar comandos em um banco de dados SQL Server
using MySqlConnector; // Biblioteca para conectar e executar comandos em um banco de dados MySQL
using System; // Biblioteca básica que inclui funcionalidades de console e manipulação de dados primitivos
using System.Text; // Biblioteca para manipulação de strings e codificação

namespace Atividade_2.Models {
    // Define a classe 'agendamento' que representa um agendamento com várias propriedades.
    public class agendamento {

        // Identificador único para o agendamento (geralmente usado como chave primária no banco de dados).
        public int id { get; set; }

        // Descrição da necessidade ou tipo de serviço requerido no agendamento.
        public string necessidade { get; set; }

        // Endereço de e-mail do usuário que está fazendo o agendamento.
        public string email { get; set; }

        // Nome do usuário que está fazendo o agendamento.
        public string nome { get; set; }

        // Data desejada para o agendamento.
        public DateTime dataa { get; set; }

        // Número de telefone para contato relacionado ao agendamento.
        public string fone { get; set; }

        // Idade do usuário que está fazendo o agendamento.
        public int idade { get; set; }
        
    }
}