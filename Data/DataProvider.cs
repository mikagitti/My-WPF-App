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
                new Person{Id=1, Name="Jaska", Address="Linkkitie 1", Postalnumber=90100, City="Oulu"},
                new Person{Id=2, Name="Ville", Address="Kiertotie 72", Postalnumber=90200, City="Oulu"},
                new Person{Id=3, Name="Essi", Address="Laanilantie", Postalnumber=90410, City="Oulu"},
            };
        }
    }
}
