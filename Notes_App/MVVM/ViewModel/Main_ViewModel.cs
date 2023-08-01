using Notes_App.Core;
using Notes_App.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Notes_App.Core.ObservableObjectsClass;
using static Notes_App.Core.RelayCommandsClass;

namespace Notes_App.MVVM.ViewModel
{
    internal class Main_ViewModel : ObservableObjectsClass
    { 
        public RelayCommand NewNoteCommand { get; set; }

        public NewNotePage NewNoteVM { get; set; }

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
            NewNoteVM = new NewNotePage();

            // Set the current view to the home page initially
            CurrentView = NewNoteVM;

            // Assign commands to navigate to different views
            NewNoteCommand = new RelayCommand(o =>
            {
                CurrentView = NewNoteVM;
            });

        }
    }
}
