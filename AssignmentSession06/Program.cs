namespace AssignmentSession06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Quesion01

            ///*
            // Q10. Write a method called PrintWelcomeMessage that takes no parameters and 
            //prints "Welcome to the Library!". Call it from Main.
            // */
            //PrintWelcomeMessage();

            #endregion

            #region Question02

            //    /*
            // Q11. Write a method PrintBookTitle(string title) that prints 
            //"Book title: " + title. Call it with "Clean Code".
            // */
            //    PrintBookTitle("Clean Code");
            #endregion

            #region Question03

            ///*
            // Add a private string password = "secret"; field to a Book class.
            //Try to print it from Main (outside the class). What happens, and why? 
            // */
            Book Bk = new Book();
            //Bk.password = "yousef"; // # compile error=> can not becouse private access only inside class 
            #endregion

            #region Question04

            ///*
            //  Add an internal int copiesInStock = 5;
            //field to Book. Print it from Main. Does it compile? Why?
            // */
            //Bk.copiesInStock = 7; // yes => becouse internal accessed in same project 

            #endregion

            #region Question05

            ///*
            // Add a public string Title; field to Book. Set it and print it from Main. 
            // */

            //Bk.Title = "Clean Code";
            //Console.WriteLine(Bk.Title);

            #endregion

            #region Question06

            ///*
            // Declare an enum Genre { Fiction, NonFiction, Science }.
            //Add a Genre property to Book, assign it Genre.Science, and print it.
            // */

            //Bk.GenreBook = Genre.Science;
            //Console.WriteLine(Bk.GenreBook);

            #endregion

            #region Question07

            ///*
            // * Using the Genre enum above, print the underlying int value of Genre.Fiction,
            // * Genre.NonFiction, and Genre.Science by casting each to int.
            // */

            //Console.WriteLine((int)Genre.Science);
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);

            #endregion

            #region Question08

            ///*
            // Given int genreNumber = 1;, cast it into a Genre value and print the result. 
            // */
            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber); // value

            #endregion

            #region Question09

            ///*
            // Given Genre genre = Genre.Fiction;, 
            //convert it into a string using ToString() and print it. 
            // */
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString()); // Fiction as string
            #endregion

            #region Question10

           // /*
           //  Given string genreText = "Science";,
           // convert it into a Genre value using Enum.Parse() and print the result.
           //  */
           // string genreText = "Science";
           // Genre G_Text;
           // G_Text = Enum.Parse<Genre>(genreText);
           ////  G_Text => must store data exist in enum
           // Console.WriteLine(G_Text);

            #endregion
        }

        #region Qestion01

        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}

        #endregion

        #region Question02

        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}

        #endregion



    }
}
