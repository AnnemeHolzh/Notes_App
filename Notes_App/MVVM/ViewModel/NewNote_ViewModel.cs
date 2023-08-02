using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes_App.Core;
using Notes_App.MVVM.Model;

namespace Notes_App.MVVM.ViewModel
{
    internal class NewNote_ViewModel : ObservableObjectsClass
    {

        private String _NoteTitle {  get; set; }

        public String NoteTitle
        {
            get { return _NoteTitle; }
            set
            {
                _NoteTitle = value;
                OnPropertyChanged(nameof(NoteTitle));
            }
        }

        private String _NoteContent { get; set; }

        public String NoteContent
        {
            get { return _NoteContent; }
            set
            {
                _NoteContent = value;
                OnPropertyChanged(nameof(NoteContent));
            }
        }

        public NewNote_ViewModel()
        {
            AddNoteCommand = new RelayCommandClass(AddNote);
        }

        public RelayCommandClass AddNoteCommand { get; private set; }

        private void AddNote(Object p)
        {
            var note = new NotesClass
            {
                NoteTitle = this.NoteTitle,
                NoteContent = this.NoteContent,
            };

            NotesListClass.AddNote(note);
            this.ClearNote();
        }

        public void ClearNote()
        {
            this.NoteTitle = String.Empty;
            this.NoteContent = String.Empty;
        }
    }
}
//____________________________________EOF_________________________________________________________________________