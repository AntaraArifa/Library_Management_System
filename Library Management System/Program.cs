using System;
using System.Collections.Generic;

namespace Library_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library using a loop
            List<BookState> bookStates = new List<BookState>
            {
                new BookState { Title = "The Hobbit", Author = "J.R.R. Tolkien" },
                new BookState { Title = "To Kill a Mockingbird", Author = "Harper Lee" },
                new BookState { Title = "1984", Author = "George Orwell" },
                new BookState { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new BookState { Title = "The Catcher in the Rye", Author = "J.D. Salinger" },
                new BookState { Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling" },
                new BookState { Title = "The Lord of the Rings", Author = "J.R.R. Tolkien" },
                new BookState { Title = "Pride and Prejudice", Author = "Jane Austen" },
                new BookState { Title = "The Da Vinci Code", Author = "Dan Brown" },
                new BookState { Title = "The Alchemist", Author = "Paulo Coelho" }
            };

            foreach (BookState bookState in bookStates)
            {
                library.AddItem(bookState);
            }

            // Adding library members to the library using a loop
            List<LibraryMember> members = new List<LibraryMember>
            {
                new BorrowMember { MemberName = "Alice" },
                new ReserveMember { MemberName = "Bob" },
                new BorrowMember { MemberName = "Charlie" },
                new BorrowMember { MemberName = "David" },
                new BorrowMember { MemberName = "Eve" },
                new ReserveMember { MemberName = "Frank" }
            };

            foreach (LibraryMember member in members)
            {
                library.AddMember(member);
            }

            // Displaying available items
            Console.WriteLine("Library Items:");
            library.DisplayItems();
            Console.WriteLine("\n=================================================================================================\n");

            // Perform actions with library members (e.g., borrowing, reserving)
            foreach (LibraryMember member in members)
            {
                if (member is BorrowMember)
                {
                    // Perform borrowing-related actions for BorrowMembers
                    ((BorrowMember)member).BorrowItem(library.GetItem("The Hobbit"), new BorrowingService()); // Use the first book state
                }
                else if (member is ReserveMember)
                {
                    // Perform reserving-related actions for ReserveMembers
                    ((ReserveMember)member).ReserveItem(library.GetItem("To Kill a Mockingbird"), new ReservingService()); // Use the second book state
                }
            }

            Console.WriteLine("\n================================================================================================\n");

            // Displaying updated status
            Console.WriteLine("Updated Library Items:");
            library.DisplayItems();
        }
    }
}
