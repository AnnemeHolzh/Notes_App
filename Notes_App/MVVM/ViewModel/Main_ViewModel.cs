using Notes_App.Core;
using Notes_App.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Notes_App.Core.ObservableObjectsClass;
using static Notes_App.Core.RelayCommandClass;

namespace Notes_App.MVVM.ViewModel
{
    internal class Main_ViewModel : ObservableObjectsClass
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
            }
        }

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
    }
}
