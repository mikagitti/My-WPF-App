using My_WPF_App.Model;
using System.Net.Http;
using System.Text.Json;

namespace My_WPF_App.Data
{
    public interface IPersonDataProvider
    {
        IEnumerable<Person> GetPersonData();
    }

    public class DataProvider : IPersonDataProvider
    {
        public IEnumerable<Person> GetPersonData()
        {
            return new List<Person>
            {
                new Person{Name="Jaska", Address="Linkkitie 1", PostalNumber=90100, City="Oulu"},
                new Person{Name="Ville", Address="Kiertotie 72", PostalNumber=90200, City="Oulu"},
                new Person{Name="Essi", Address="Laanilantie", PostalNumber=90410, City="Oulu"},
                new Person{Name="Mervi", Address="Kaukokatu 144", PostalNumber=90700, City="Oulu"}
            };
        }

        
        /****************
        API CALL example
          
        public async Task<IEnumerable<Person>> GetPersonsFromApiAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string apiUrl = "https://api-call-example.com/persons"; //Change this!!
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<IEnumerable<Person>>(json);
                }
                return new List<Person>();
            }
        }
        ********************/
    }
}
