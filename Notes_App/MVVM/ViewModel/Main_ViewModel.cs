using Notes_App.Core;
using Notes_App.MVVM.View;
using Notes_App.UI_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using static Notes_App.Core.ObservableObjectsClass;
using static Notes_App.Core.RelayCommandClass;

namespace Notes_App.MVVM.ViewModel
{
    public class Main_ViewModel : ObservableObjectsClass, INotifyPropertyChanged
    {

        private bool isThoughtBubbleVisible;
        public bool IsThoughtBubbleVisible
        {
            get { return isThoughtBubbleVisible; }
            set
            {
                if (isThoughtBubbleVisible != value)
                {
                    isThoughtBubbleVisible = value;
                    OnPropertyChanged(nameof(IsThoughtBubbleVisible));
                }
            }
        }

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
        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Main_ViewModel()
        {
            // Instantiate view models for the home page, all recipes page, and new recipe page
            HomeVM = new Home_View();
            NewNoteVM = new NewNotePage();
            ViewAllVM = new ViewAllNotesView(); 

            // Set the current view to the home page initially
            CurrentView = HomeVM;

            IsThoughtBubbleVisible = true;

            // Assign commands to navigate to different views
            HomeCommand = new Core.RelayCommandClass(o =>
            {
                CurrentView = HomeVM;
                IsThoughtBubbleVisible = true;
            });


            NewNoteCommand = new Core.RelayCommandClass(o =>
            {
                CurrentView = NewNoteVM;
                IsThoughtBubbleVisible = false; // Set to false when navigating to other views
            });

            ViewAllCommand = new Core.RelayCommandClass(o =>
            {
                ViewAllVM.RefreshData();
                CurrentView = ViewAllVM;
                IsThoughtBubbleVisible = false; // Set to false when navigating to other views
            });

        }


    }
}
