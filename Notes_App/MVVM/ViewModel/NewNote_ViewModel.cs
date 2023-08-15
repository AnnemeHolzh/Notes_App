using Notes_App.Core;
using Notes_App.MVVM.Model;
using System;

namespace Notes_App.MVVM.ViewModel
{
    /// <summary>
    /// View Model for the NewNotePage
    /// </summary>
    internal class NewNote_ViewModel : ObservableObjectsClass
    {
        //___________________________________________________________________________________________________________
        //__________________________________________Parameters_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the New notes title
        /// </summary>
        private String _NoteTitle { get; set; }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the New notes title
        /// </summary>
        public String NoteTitle
        {
            get { return _NoteTitle; }
            set
            {
                _NoteTitle = value;
                OnPropertyChanged(nameof(NoteTitle));
            }
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the New notes Content
        /// </summary>
        private String _NoteContent { get; set; }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the New notes Content
        /// </summary>
        public String NoteContent
        {
            get { return _NoteContent; }
            set
            {
                _NoteContent = value;
                OnPropertyChanged(nameof(NoteContent));
            }
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// constructor that instantiates relayCommands
        /// </summary>
        public NewNote_ViewModel()
        {
            AddNoteCommand = new RelayCommandClass(AddNote);
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Allocates the AddNoteCommand
        /// </summary>
        public RelayCommandClass AddNoteCommand { get; private set; }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //_____________________________________________Methods_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// A method to add a new note to the global list
        /// </summary>
        /// <param name="p"></param>
        private void AddNote(Object p)
        {

            var note = new NotesClass
            {
                NoteTitle = this.NoteTitle,
                NoteContent = this.NoteContent,
            };
            if (!String.IsNullOrEmpty(note.NoteContent))
            {
                NotesListClass.AddNote(note);
                this.ClearNote();
            }


        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// a method to clear the textboxes
        /// </summary>
        public void ClearNote()
        {
            this.NoteTitle = String.Empty;
            this.NoteContent = String.Empty;
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________