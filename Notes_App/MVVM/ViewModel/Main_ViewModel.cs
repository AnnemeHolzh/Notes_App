using Notes_App.Core;
using Notes_App.MVVM.View;
using Notes_App.UI_Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using static Notes_App.Core.ObservableObjectsClass;
using static Notes_App.Core.RelayCommandClass;
using System.Windows.Controls;
using System.ComponentModel;

namespace Notes_App.MVVM.ViewModel
{
    internal class Main_ViewModel : ObservableObjectsClass, INotifyPropertyChanged
    { 
        public Core.RelayCommandClass NewNoteCommand { get; set; }

        public NewNotePage NewNoteVM { get; set; }

        public Core.RelayCommandClass ViewAllCommand { get; set; }

        public ViewAllNotesView ViewAllVM { get; set; }
        public Core.RelayCommandClass HomeCommand { get; set; }

        public Home_View HomeVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CurrentView));
                OnPropertyChanged(nameof(IsHomeView));
            }
        }

        public bool IsHomeView => CurrentView == HomeVM;

        public Main_ViewModel()
        {
            // Instantiate view models for the home page, all recipes page, and new recipe page
            HomeVM = new Home_View();
            NewNoteVM = new NewNotePage();
            ViewAllVM = new ViewAllNotesView(); 

            // Set the current view to the home page initially
            CurrentView = HomeVM;

            // Assign commands to navigate to different views
            HomeCommand = new Core.RelayCommandClass(o =>
            {
                CurrentView = HomeVM;
            });

            NewNoteCommand = new Core.RelayCommandClass(o =>
            {
                CurrentView = NewNoteVM;
            });

            ViewAllCommand = new Core.RelayCommandClass(o =>
            {
                CurrentView = ViewAllVM;
            });

          
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
