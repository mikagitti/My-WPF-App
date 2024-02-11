using My_WPF_App.Model;

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
                new Person{Name="Mervi", Address="Kaukovainionkatu 144", PostalNumber=90700, City="Oulu"}
            };
        }
    }
}
