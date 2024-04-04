using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Collections.ObjectModel;

namespace Testing
{
    public class DashBoardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<PracticeData> _userPracties;
        public ObservableCollection<PracticeData> UserPractices
        {
            get => _userPracties;
            set
            {
                _userPracties = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Training> _trainings;
        public ObservableCollection<Training> Trainings
        {
            get => _trainings;
            set
            {
                _trainings = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<MenuItem> _menuItems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get => _menuItems;
            set
            {
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        public DashBoardViewModel()
        {
            _userPracties = new ObservableCollection<PracticeData>()
            {
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 100, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 50, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 40, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 42, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 25, Word =  3.5},
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 34, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 30, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 20, Word = 3.5 },
                new PracticeData() { Date =  new DateTime(2024,2,26), Time = 2.98, Accuracy = 8, Word = 3.5 }
            };

            _trainings = new ObservableCollection<Training>()
            {
                new Training() { Title = "Tapping", Description = "Basic Training", Trainer = "John Kennedy", TrainingType = "Training"},
                new Training() { Title = "Tapping", Description = "Advanced Training", Trainer = "John Kennedy", TrainingType = "Training"},
            };

            _menuItems = new ObservableCollection<MenuItem>()
            {
                new MenuItem() { Title = "GENERAL", MenuItemType = MenuItemType.GroupItem},
                new MenuItem(){ Title = "Dashboard", Icon = IconType.DashBoard},
                new MenuItem(){ Title = "How It Works", Icon = IconType.Book},
                new MenuItem(){ Title = "Resources", Icon = IconType.Resource},
                
                new MenuItem() {Title = "COURSES",  MenuItemType= MenuItemType.GroupItem},
                new MenuItem(){ Title = "Workout", Icon = IconType.Brain},
                new MenuItem(){ Title = "Trainings", Icon = IconType.BookOpen},
                
                new MenuItem() {Title = "OTHER", MenuItemType = MenuItemType.GroupItem},
                new MenuItem(){ Title = "Leader Board", Icon = IconType.Medal},
                new MenuItem(){ Title = "Setting", Icon = IconType.Setting}
            };
        }
    }

    public class PracticeData
    {
        public DateTime Date { get; set; }
        public double Time { get; set; }
        public double Accuracy { get; set; }
        public double Word { get; set; }
    }

    public class Training
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Trainer { get; set; }
        public string TrainingType { get; set; }
    }
}
