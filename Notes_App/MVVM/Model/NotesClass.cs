using System;

namespace Notes_App.MVVM.Model
{
    /// <summary>
    /// used to create a NoteClass Object that stores the notes title, content and the last time it was edited
    /// </summary>
    public class NotesClass
    {
        //___________________________________________________________________________________________________________
        //__________________________________________Parameters_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the notes title
        /// </summary>
        public string NoteTitle { get; set; } = String.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the notes content
        /// </summary>
        public string NoteContent { get; set; } = String.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the last time the note was edited
        /// </summary>
        public DateTime lastEdited { get; set; } = DateTime.MinValue;
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Notes class constructor to populate the NotesClass object
        /// </summary>
        /// <param Title="NT"></param>
        /// <param Content="NC"></param>
        public NotesClass(String NT, String NC)
        {
            this.NoteTitle = NT;
            this.NoteContent = NC;
            this.lastEdited = this.GetDateTime();
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Default constructor
        /// </summary>
        public NotesClass()
        {
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //_____________________________________________Methods_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// returns the note title
        /// </summary>
        /// <returns></returns>
        public string GetTitle()
        {
            return this.NoteTitle;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// returns the notes content
        /// </summary>
        /// <returns></returns>
        public string GetContent()
        {
            return this.NoteContent;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// sets the notes content to the newContent parameter
        /// </summary>
        /// <param name="newContent"></param>
        public void SetContent(string newContent)
        {
            this.NoteContent = newContent;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// returns the datetime from the last time the note was edited
        /// </summary>
        /// <returns></returns>
        public DateTime GetLastEdited()
        {
            return this.lastEdited;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// returns the current datetime
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// sets the lastEdited value to the current datetime
        /// </summary>
        /// <returns></returns>
        public void SetDateTime()
        {
            this.lastEdited = DateTime.Now;
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________