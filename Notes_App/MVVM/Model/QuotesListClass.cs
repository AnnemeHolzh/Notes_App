using System.Collections.Generic;

namespace Notes_App.MVVM.Model
{
    internal class QuotesListClass
    {
        List<QuotesClass> quotesList = new List<QuotesClass>
            {
                new QuotesClass("The first draft is just you telling yourself the story.", "Terry Pratchett"),
                new QuotesClass("There is no greater agony than bearing an untold story inside you.", "Maya Angelou"),
                new QuotesClass("Easy reading is damn hard writing.", "Nathaniel Hawthorne"),
                new QuotesClass("Writing is a way of talking without being interrupted.", "Jules Renard"),
                new QuotesClass("The scariest moment is always just before you start.", "Stephen King"),
                new QuotesClass("Write what should not be forgotten.", "Isabel Allende"),
                new QuotesClass("I write entirely to find out what I'm thinking, what I'm looking at, what I see, and what it means.", "Joan Didion"),
                new QuotesClass("The art of writing is the art of discovering what you believe.", "Gustave Flaubert"),
                new QuotesClass("Start writing, no matter what. The water does not flow until the faucet is turned on.", "Louis L'Amour"),
                new QuotesClass("The only writer to whom you should compare yourself is the writer you were yesterday.", "David Schlosser"),
                new QuotesClass("If you don’t have time to read, you don’t have the time (or the tools) to write.", "Stephen King"),
                new QuotesClass("Writing is both mask and unveiling.", "E.B. White"),
                new QuotesClass("Writing is an exploration. You start from nothing and learn as you go.", "E.L. Doctorow"),
                new QuotesClass("A word after a word after a word is power.", "Margaret Atwood"),
                new QuotesClass("Write drunk; edit sober.", "Peter De Vries"),
                new QuotesClass("The role of a writer is not to say what we all can say, but what we are unable to say.", "Anaïs Nin"),
                new QuotesClass("To survive, you must tell stories.", "Umberto Eco"),
                new QuotesClass("No tears in the writer, no tears in the reader. No surprise in the writer, no surprise in the reader.", "Robert Frost"),
                new QuotesClass("A professional writer is an amateur who didn't quit.", "Richard Bach"),
                new QuotesClass("Writing is the painting of the voice.", "Voltaire"),
                new QuotesClass("You can make anything by writing.", "C.S. Lewis"),
                new QuotesClass("The most important things are the hardest to say. They are the things you get ashamed of, because words diminish them.", "Stephen King"),
                new QuotesClass("Writing is the geometry of the soul.", "Plato"),
                new QuotesClass("Write the kind of story you would like to read. People will give you all sorts of advice about writing, but if you are not writing something you like, no one else will like it either.", "Meg Cabot"),
                new QuotesClass("Writing is like giving yourself homework, really hard homework, every day, for the rest of your life.", "Anne Lamott"),
                new QuotesClass("Writing is a form of therapy; sometimes I wonder how all those who do not write, compose or paint can manage to escape the madness, melancholia, the panic and fear which is inherent in a human situation.", "Graham Greene"),
                new QuotesClass("Writing is an act of faith, not a trick of grammar.", "E.B. White"),
                new QuotesClass("The beautiful part of writing is that you don't have to get it right the first time, unlike, say, a brain surgeon.", "Robert Cormier"),
                new QuotesClass("Writing is the best way to talk without being interrupted.", "Jules Renard"),
                new QuotesClass("I can shake off everything as I write; my sorrows disappear, my courage is reborn.", "Anne Frank")
            };


        public QuotesListClass()
        {
        }

        public string DisplayQuote(int id)
        {
            var quote = quotesList[id].PrintQuote();
            return quote;
        }

        public int QuotesListCount()
        {
            return quotesList.Count;
        }

    }
}
//____________________________________EOF_________________________________________________________________________