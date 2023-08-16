using Notes_App.Core;
using Notes_App.MVVM.Model;
using System.Collections.ObjectModel;

namespace Notes_App.MVVM.ViewModel
{

    public class Home_ViewModel : ObservableObjectsClass
    {
        //___________________________________________________________________________________________________________
        //__________________________________________Parameters_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores list of notes that need to be displayed on the home view
        /// </summary>
        private ObservableCollection<NotesClass> _HomeNotes { get; set; }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores list of notes that need to be displayed on the home view
        /// </summary>
        public ObservableCollection<NotesClass> HomeNotes
        {
            get { return _HomeNotes; }
            set
            {
                _HomeNotes = value;
                OnPropertyChanged(nameof(HomeNotes));
            }
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Constructor used to set the HomeNotes Collection value
        /// </summary>
        public Home_ViewModel()
        {
            this.HomeNotes = new ObservableCollection<NotesClass>(NotesListClass.homeDisplay());
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //_____________________________________________Methods_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// method used to reset the HomeNotes value
        /// </summary>
        public void ResetHomeView()
        {
            this.HomeNotes = new ObservableCollection<NotesClass>(NotesListClass.homeDisplay());
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________