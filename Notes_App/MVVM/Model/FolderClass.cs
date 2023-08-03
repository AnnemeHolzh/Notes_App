using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_App.MVVM.Model
{
    public class FolderClass
    {
        public string FolderName { get; set; } = String.Empty;

        public ObservableCollection<NotesClass> Notes { get; set; } = new ObservableCollection<NotesClass>();

        public FolderClass(String FN, ObservableCollection<NotesClass> OC) 
        { 
            this.FolderName = FN;
            this.Notes = OC;
        }    

        public FolderClass() 
        { 
        }

        public void AddNoteToFolder(NotesClass NC)
        {
            Notes.Add(NC);
        }
    }
}
