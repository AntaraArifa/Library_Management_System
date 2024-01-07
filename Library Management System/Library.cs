using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{

    public class Library
    {
        private List<BookState> items;
        private List<LibraryMember> members;

        public Library()
        {
            items = new List<BookState>();
            members = new List<LibraryMember>();
        }

        public void AddItem(BookState item)
        {
            items.Add(item);
        }

        public void AddMember(LibraryMember member)
        {
            members.Add(member);
        }

        public void DisplayItems()
        {
            foreach (BookState item in items)
            {
                Console.WriteLine(item.Display());
            }
        }

        // Assuming you have a method to get a book state by title
        public BookState GetItem(string title)
        {
            return items.Find(item => item.Title == title);
        }
    }
}
