﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Notes_App.MVVM.Model
{
    /// <summary>
    /// Handles the NotesClass list 
    /// </summary>
    internal class NotesListClass
    {

        //___________________________________________________________________________________________________________
        //__________________________________________Parameters_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// List of Notes
        /// </summary>
        private static ObservableCollection<NotesClass> NotesList = new ObservableCollection<NotesClass>();
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// default constructor
        /// </summary>
        public NotesListClass()
        {
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //_____________________________________________Methods_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// adds note to the NotesList
        /// </summary>
        /// <param name="note"></param>
        public static void AddNote(NotesClass note)
        {
            if(string.IsNullOrEmpty(note.NoteTitle))
            {
                note.SetTitle("Untitled");
            }

            NotesList.Add(note);
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// returns the list of notes
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<NotesClass> ReturnNotes()
        {
            return NotesList;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// removes note from notesList
        /// </summary>
        /// <param name="note"></param>
        public static void RemoveNote(NotesClass note)
        {
            NotesList.Remove(note);
        }
        //___________________________________________________________________________________________________________

        public static ObservableCollection<NotesClass> homeDisplay()
        {
            // sort noteslist last edited
            var sortedNotes = new ObservableCollection<NotesClass>(NotesList.OrderBy(note => note.lastEdited));

            //add top 6 to OC
            var HomeSix = new ObservableCollection<NotesClass>();

            var DefaultTitle = "Title";
            var DefaultContent = "Make more notes to display here";

            if (sortedNotes.Any())
            {
                for (var i = 0; i < 6; i++)
                {
                    if (i < sortedNotes.Count)
                    {
                        HomeSix.Add(sortedNotes[i]);
                    }
                    else
                    {
                        var defaultNote = new NotesClass(DefaultTitle, DefaultContent);
                        HomeSix.Add(defaultNote);
                    }
                }
            }
            else
            {
                for (var i = 0; i < 6; i++)
                {
                    var defaultNote = new NotesClass(DefaultTitle, DefaultContent);
                    HomeSix.Add(defaultNote);
                }
            }
            //return OC
            return HomeSix;
        }



    }
}
//____________________________________EOF_________________________________________________________________________