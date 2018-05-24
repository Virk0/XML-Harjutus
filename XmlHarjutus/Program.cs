using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

///
namespace XmlHarjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("1. Create new note");
                Console.WriteLine("2. Read already existing note");
                string choice1 = Console.ReadLine();
                if (choice1 == "1")
                {
                    Add_note.Add_Note();
                }
                if (choice1 == "2")
                {
                    Read_note.Read_Note();
                }
            }
            Environment.Exit(0);
           
        }
    }
    class Note
    {
        public string Content { get; set; }
        public string Title { get; set; }
    }
}
