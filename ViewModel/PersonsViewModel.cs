using My_WPF_App.Command;
using My_WPF_App.Data;
using My_WPF_App.Model;
using System.Collections.ObjectModel;

namespace My_WPF_App.ViewModel
{
    public class PersonsViewModel : ViewModelBase
    {
        private readonly IPersonDataProvider? _personDataProvider = null;
        private Person? _selectedPerson;

        public PersonsViewModel()
        {
            _personDataProvider = new DataProvider();

            if (!Persons.Any())
            {
                GetPersonData();
            }

            AddPerson = new DelegateCommand(AddNewPerson);
            DeletePerson = new DelegateCommand(DeletePersonFromList, CanDeletePersonFromList);
        }

        public ObservableCollection<Person> Persons { get; } = new();
        
        public Person? SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedPerson));
                DeletePerson.RaiseCanExecuteChanged();
            }
        }


        public DelegateCommand AddPerson { get; }

        private void AddNewPerson(object? parameter)
        {
            if(parameter == null)
            {
                return;
            }

            Person? person = (Person)parameter;
            Persons.Add(person);
        }
    

        public DelegateCommand DeletePerson { get; }
        private void DeletePersonFromList(object? parameter)
        {
            if (_selectedPerson != null)
                Persons.Remove(_selectedPerson);
        }
        private bool CanDeletePersonFromList(object? parameter)
        {
            if (_selectedPerson != null)
                return !_selectedPerson.IsEmpty();
            return false;
        }



        private void GetPersonData()
        {
            if (Persons.Any())
            {
                return;
            }

            if (_personDataProvider != null)
            {
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

        internal void AddNewPerson(string name = "", string address="", int age = 0, string city = "")
        {
            var person = new Person { Name = name, Address = address, PostalNumber = age, City = city};
            AddNewPerson(person);
        }
    }
}
