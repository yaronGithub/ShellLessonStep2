using MonkeyCollection.Models;
using ShellLessonStep2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyCollection.ViewModels
{
    [QueryProperty(nameof(SelectedMonkey), "selectedMonkey")]
    public class MonkeyDetailsViewModel : ViewModelBase
    {
        private Animal selectedMonkey;
        public Animal SelectedMonkey
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
    }
}
