using System.Collections.Generic; // Biblioteca (BANCO DE DADOS E LISTA)
using System.Data.SqlClient;
using MySqlConnector;
using System; // Biblioteca (CONSOLE E FUNÇÃO WRITE LINE)
using System.Text;

namespace Atividade_2.Models {

    public class usuarios {
        
        public int id {get; set;}
        
        public string nome {get; set;}
        
        public string login {get; set;}
        
        public string senha {get; set;}
        
        public DateTime nascimento {get; set;}
    
    }

} // OK