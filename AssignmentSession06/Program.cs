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
