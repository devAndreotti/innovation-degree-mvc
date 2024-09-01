using System.Collections.Generic; // Biblioteca (BANCO DE DADOS E LISTA)
using System.Data.SqlClient;
using MySqlConnector;
using System; // Biblioteca (CONSOLE E FUNÇÃO WRITE LINE)
using System.Text;

namespace Atividade_2.Models {

public class venda {

    public int id {get; set;}

    public string conceito {get; set;}

    public string email {get; set;}

    public string nome {get; set;}

    public string fone {get; set;}

    public int idade {get; set;}
    
}

} // OK