using ShellLessonStep2.Models;
using ShellLessonStep2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonkeyCollection.ViewModels
{
    public class MonkeysViewModel : ViewModelBase
    {
        private ObservableCollection<Animal> monkeys;
        public ObservableCollection<Animal> Monkeys
        {
            get
            {
                return this.monkeys;
            }
            set
            {
                this.monkeys = value;
                OnPropertyChanged();
            }
        }
        private AnimalService monkeysService;
        public MonkeysViewModel(AnimalService service)
        {
            this.monkeysService = service;
            monkeys = new ObservableCollection<Animal>();
            ReadMonkeys();
        }

        private string location;
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
                OnPropertyChanged();
            }
        }

        private async void ReadMonkeys()
        {
            AnimalService service =  this.monkeysService;
            List<Animal> list = await service.GetMonkeys();
            this.Monkeys = new ObservableCollection<Animal>(list);
        }

        private Object selectedMonkey;
        public Object SelectedMonkey
        {
            get
            {
                return selectedMonkey;
            }
            set
            {
                this.selectedMonkey = value;
                OnPropertyChanged();
            }
        }

        public ICommand SingleSelectCommand => new Command(OnSingleSelectMonkey);

        async void OnSingleSelectMonkey()
        {
            if (SelectedMonkey != null)
            {
                var navParam = new Dictionary<string, object>()
                {
                    {"selectedMonkey", SelectedMonkey }
                };
                await Shell.Current.GoToAsync($"monkeyDetails", navParam);
                SelectedMonkey = null;
            }
        }
    }
}
