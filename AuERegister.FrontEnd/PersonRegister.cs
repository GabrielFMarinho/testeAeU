using AuERegister.FrontEnd.ViewModel;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Text.Json;
using System.Text;

namespace AuERegister.FrontEnd
{
    public partial class PersonRegister : Form
    {
        private const string apiUrl = "https://localhost:7195/";
        public PersonRegister()
        {
            InitializeComponent();
            Load += dataGridView1_CellContentClick;
        }

        private async Task GetAllPersons()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl + "api/Contact/GetAllContacts");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // Convertendo a resposta JSON para um objeto adequado
                        // Certifique-se de ter uma classe correspondente aos dados retornados pela API
                        var dados = JsonConvert.DeserializeObject<List<ContactViewModel>>(json);

                        // Adicionar os itens do seu objeto à ListView
                        AddItensListView(dados);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter os dados da API: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void AddItensListView(List<ContactViewModel> persons)
        {
            ListPersons.ClearSelection();
            ListPersons.DataSource = persons;
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            GetAllPersons();
        }

        public async Task<List<ContactViewModel>> GetAllContacts()
        {
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl + "api/Contact/GetAllContacts");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // Convertendo a resposta JSON para um objeto adequado
                        // Certifique-se de ter uma classe correspondente aos dados retornados pela API
                        var dados = JsonConvert.DeserializeObject<List<ContactViewModel>>(json);

                        // Adicionar os itens do seu objeto à ListView
                        contacts = dados;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter os dados da API: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            return contacts;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            contacts = await this.GetAllContacts();

            var citys = contacts.Select(x => x.City).Distinct();
            string result = "Análise dos contatos \n";
            result = result + $"Número de contatos no banco de dados: {contacts.Count()}, " +
                $"{contacts.Count(p => p.Sex == "M")} Homens e {contacts.Count(p => p.Sex == "F")} Mulheres \n";
            foreach (var city in citys)
            {
                result = result + $"Contatos em {city}; \n";
                var months = contacts.Where(a => a.City == city).Select(s => s.Date.Month).Distinct();
                foreach (var month in months)
                {
                    string nomeDoMes;
                    switch (month)
                    {
                        case 1:
                            nomeDoMes = "Janeiro";
                            break;
                        case 2:
                            nomeDoMes = "Fevereiro";
                            break;
                        case 3:
                            nomeDoMes = "Março";
                            break;
                        case 4:
                            nomeDoMes = "Abril";
                            break;
                        case 5:
                            nomeDoMes = "Maio";
                            break;
                        case 6:
                            nomeDoMes = "Junho";
                            break;
                        case 7:
                            nomeDoMes = "Julho";
                            break;
                        case 8:
                            nomeDoMes = "Agosto";
                            break;
                        case 9:
                            nomeDoMes = "Setembro";
                            break;
                        case 10:
                            nomeDoMes = "Outubro";
                            break;
                        case 11:
                            nomeDoMes = "Novembro";
                            break;
                        case 12:
                            nomeDoMes = "Dezembro";
                            break;
                        default:
                            nomeDoMes = "Mês Inválido"; // Tratamento para valores fora do intervalo de 1 a 12
                            break;
                    }

                    var sex = contacts.Where(p => p.Date.Month == month && p.City == city);
                    result = result + $"{nomeDoMes}: {sex.Count()}, {sex.Count(s => s.Sex == "M")} Homens e {sex.Count(s => s.Sex == "F")}; \n";
                }
                result = result + $"Total: {contacts.Count(p => p.City == city)} \n\n";
            }
            richTextBox1.Text = result;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
                // Get values from UI controls
                string name = txtNome.Text;
                string gender = clickMasculino.Checked ? "M" : "F";
                string city = txtCidade.Text;
                DateTime date = DateTime.Now;

                // Create an object to represent the data
                ContactViewModel contact = new ContactViewModel
                {
                    Name = name,
                    Sex = gender,
                    City = city,
                    Date = date
                };

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string json = System.Text.Json.JsonSerializer.Serialize(contact);
                         HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                         // Assuming apiUrl is the base URL of your API
                         HttpResponseMessage response = await client.PostAsync($"{apiUrl}api/Contact/AddContact", content);

                        if (response.IsSuccessStatusCode)
                        {
                            // Data saved successfully
                            MessageBox.Show("Data saved successfully!");
                            txtNome.Text = string.Empty;
                            txtCidade.Text = string.Empty;
                            clickMasculino.Checked=false;
                            clickFeminino.Checked=false;
                            GetAllPersons();


                    }
                    else
                        {
                            MessageBox.Show($"Failed to save data. Status code: {response.StatusCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllPersons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Your code for the buttonExclui click event
            // For example:
            // MessageBox.Show("Button Exclui Clicked!");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}