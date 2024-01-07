using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryItemManager
    {
        private List<BookState> items;

        public LibraryItemManager()
        {
            items = new List<BookState>();
        }

        public void AddItem(BookState item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            foreach (BookState item in items)
            {
                Console.WriteLine(item.Display());
            }
        }

        public BookState GetItem(string title)
        {
            return items.Find(item => item.Title == title);
        }
    }
}
