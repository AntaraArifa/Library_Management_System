using Library_Management_System;

class Program
{
    static void Main(string[] args)
    {
        LibraryItemManager library = new LibraryItemManager();

        // Adding 8 different books to the library
        List<BookState> bookStates = new List<BookState>
        {
            new BookState { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
            new BookState { Title = "To Kill a Mockingbird", Author = "Harper Lee" },
            new BookState { Title = "1984", Author = "George Orwell" },
            new BookState { Title = "The Catcher in the Rye", Author = "J.D. Salinger" },
            new BookState { Title = "Pride and Prejudice", Author = "Jane Austen" },
            new BookState { Title = "The Hobbit", Author = "J.R.R. Tolkien" },
            new BookState { Title = "The Da Vinci Code", Author = "Dan Brown" },
            new BookState { Title = "The Alchemist", Author = "Paulo Coelho" }
        };

        foreach (BookState bookState in bookStates)
        {
            library.AddItem(bookState);
        }


        Console.WriteLine("Library Items:");
        library.DisplayItems();

        Console.WriteLine("\n========================================================================================================================\n");

        // Adding 4 members to the library
        List<LibraryMember> members = new List<LibraryMember>
        {
            new BorrowMember { MemberName = "Farhan" },
            new BorrowMember { MemberName = "Rayshad" },
            new ReserveMember { MemberName = "Niaz" },
            new ReserveMember { MemberName = "Sajid" }
        };

        foreach (LibraryMember member in members)
        {
            member.AddMember(member);
        }

        Console.WriteLine("\n========================================================================================================================\n");


        // Borrow Members borrow books
        ((BorrowMember)members[0]).BorrowItem(library.GetItem("The Great Gatsby"), new BorrowBook(library.GetItem("The Great Gatsby")));
        ((BorrowMember)members[1]).BorrowItem(library.GetItem("To Kill a Mockingbird"), new BorrowBook(library.GetItem("To Kill a Mockingbird")));

        Console.WriteLine("\n========================================================================================================================\n");

        // Reserve Members reserve books
        ((ReserveMember)members[2]).ReserveItem(library.GetItem("1984"), new ReserveBook(library.GetItem("1984")));
        ((ReserveMember)members[3]).ReserveItem(library.GetItem("The Catcher in the Rye"), new ReserveBook(library.GetItem("The Catcher in the Rye")));

        Console.WriteLine("\n========================================================================================================================\n");

        // Borrow Member returns a book
        ((BorrowMember)members[0]).ReturnItem(library.GetItem("The Great Gatsby"), new BorrowBook(library.GetItem("The Great Gatsby")));

        Console.WriteLine("\n========================================================================================================================\n");

        // Reserve Member cancels a reservation
        ((ReserveMember)members[2]).CancelReservation(library.GetItem("1984"), new ReserveBook(library.GetItem("1984")));

        Console.WriteLine("\n========================================================================================================================\n");

        // Displaying updated library status
        Console.WriteLine("Updated Library Items:");
        library.DisplayItems();
    }
}
