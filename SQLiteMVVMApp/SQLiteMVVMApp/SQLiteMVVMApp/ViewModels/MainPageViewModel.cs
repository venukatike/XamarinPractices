using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SQLiteMVVMApp.Annotations;
using SQLiteMVVMApp.Database;
using SQLiteMVVMApp.Services;
using Xamarin.Forms;

namespace SQLiteMVVMApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private readonly  PeopleDb peopleDb;
        private readonly INotificationsService notificationsService;

        public MainPageViewModel(INotificationsService notificationsService, PeopleDb peopleDb)
        {
            this.notificationsService = notificationsService;
            this.peopleDb = peopleDb;

            var people = peopleDb.GetPeople();

            if (people.Any())
            {
                var lastRecord = people.OrderByDescending(by => by.PersonId).First();
                firstName = lastRecord.FirstName;
                lastName = lastRecord.LastName;
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if(firstName == value) return;
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if(lastName == value) return;
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand SaveDataCommand
        {
            get => new Command(SaveData);
        }

        private async void SaveData()
        {
            try
            {
                peopleDb.AddPerson(firstName, lastName);
                await notificationsService.ShowSuccessMessageAsync("Data saved");
            }
            catch (Exception e)
            {
                await notificationsService.ShowErrorMessageAsync(e.Message);
            }
            
         
        }
    }
}