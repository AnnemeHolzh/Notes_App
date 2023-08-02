using Notes_App.Core;
using Notes_App.MVVM.Model;
using System.Collections.ObjectModel;

namespace Notes_App.MVVM.ViewModel
{
    /// <summary>
    /// View Model for the ViewAllNotesView
    /// </summary>
    public class ViewAllNotesViewModel : ObservableObjectsClass
    {

        //___________________________________________________________________________________________________________
        //__________________________________________Parameters_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// a local list of all the notes stored
        /// </summary>
        private ObservableCollection<NotesClass> _Notes { get; set; }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// a local list of all the notes stored
        /// </summary>
        public ObservableCollection<NotesClass> Notes
        {
            get { return _Notes; }
            set
            {
                _Notes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// constructor that sets the local list of notes to the global list
        /// </summary>
        public ViewAllNotesViewModel()
        {
            Notes = new ObservableCollection<NotesClass>(NotesListClass.ReturnNotes());
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________