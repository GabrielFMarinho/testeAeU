using AuERegister.Repository.Entities;
using System.Data;
using System.Data.OleDb;
//Gabriel Marinho
namespace AuERegister.Repository
{
    public class Repository
    {
        private const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gabri\OneDrive\Área de Trabalho\estagiojf\src\dados\auebd.mdb;Persist Security Info=False;";

        public List<Contact> GetAllPersons()
        {
            List<Contact> contacts = new List<Contact>();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Contatos"; 

                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Contact contact = new Contact();
                        contact.Id = Convert.ToInt32(reader["CodContato"]);
                        contact.Name = reader["Nome"].ToString();
                        contact.Sex = reader["Sexo"].ToString();
                        string date = reader["Data"].ToString();
                        contact.Date = DateTime.Parse(date);
                        contact.City = reader["Cidade"].ToString();

                        contacts.Add(contact);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }


            return contacts;
        }


        public int GetMaxCodeContact()
        {
            int id = 0;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "select max(codContato) as CodContato from contatos";

                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["CodContato"]);
                       
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }


            return id;
        }

        public bool AddContact(Contact contact)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO Contatos (CodContato, Nome, Sexo, Data, Cidade) VALUES (@CodContato, @Nome, @Sexo, @Data, @Cidade)";

                OleDbCommand command = new OleDbCommand(query, connection);

                int CodContato = GetMaxCodeContact()+1;
                string Nome = contact.Name;
                string Sexo = contact.Sex;
                string Data = $"{contact.Date.Day}-{contact.Date.Month}-{contact.Date.Year}";
                string Cidade = contact.City;

                command.Parameters.Add("@CodContato", CodContato);
                command.Parameters.Add("@Nome", Nome);
                command.Parameters.Add("@Sexo", Sexo);
                command.Parameters.Add("@Data", Data);
                command.Parameters.Add("@Cidade", Cidade);
                try
                {
                    connection.Open();

                    int linhasAfetadas = command.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        Console.WriteLine("Inserção realizada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma linha inserida.");
                    }
                }
                catch (DataException ex)
                {
                    Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
                }
        }


            return true;
        }



    }

}
