using Notes_App.Core;
using Notes_App.MVVM.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Notes_App.MVVM.ViewModel
{

    public class Home_ViewModel : ObservableObjectsClass
    {
        private ObservableCollection<NotesClass> _HomeNotes { get; set; }

        public ObservableCollection<NotesClass> HomeNotes
        {
            get { return _HomeNotes; }
            set
            {
                _HomeNotes = value;
                OnPropertyChanged(nameof(HomeNotes));
            }
        }


        public Home_ViewModel()
        {
            this.HomeNotes = new ObservableCollection<NotesClass>(NotesListClass.homeDisplay());
        }


        public void ResetHomeView()
        {
            this.HomeNotes = new ObservableCollection<NotesClass>(NotesListClass.homeDisplay());
        }
       
    }
}
