using Notes_App.Core;
using Notes_App.MVVM.Model;
using System.Collections.ObjectModel;

namespace Notes_App.MVVM.ViewModel
{
    public class ViewAllNotesViewModel : ObservableObjectsClass
    {
        private ObservableCollection<NotesClass> _Notes { get; set; }
        //___________________________________________________________________________________________________________

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

        public ViewAllNotesViewModel()
        {
            Notes = new ObservableCollection<NotesClass>(NotesListClass.ReturnNotes());
        }
    }
}
//____________________________________EOF_________________________________________________________________________