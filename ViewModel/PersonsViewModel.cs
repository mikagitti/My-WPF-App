using My_WPF_App.Data;
using My_WPF_App.Model;
using System.Collections.ObjectModel;

namespace My_WPF_App.ViewModel
{
    public class PersonsViewModel : ViewModelBase
    {
        private readonly IPersonDataProvider _personDataProvider;

        public PersonsViewModel(IPersonDataProvider personDataProvider)
        {
            _personDataProvider = personDataProvider;
            GetPersonData();
        }

        public ObservableCollection<Person> Persons { get; } = new();
        
        public void GetPersonData()
        {
            if (Persons.Any())
            {
                return;
            }

            var persons = _personDataProvider.GetPersonData();

            if (persons is not null)
            {
                foreach (var person in persons)
                {
                    Persons.Add(person);
                }
            }
        }
    }
}
