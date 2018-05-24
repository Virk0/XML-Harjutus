using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlHarjutus
{
    /// <summary>
    /// Class used to read notes
    /// </summary>
    public class Add_note
    {
       public static void Add_Note()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../Notes.xml");

            XmlNode Notes = xmlDoc.CreateElement("Note");
            XmlNode rootnode = xmlDoc.SelectSingleNode("Notes");
            XmlAttribute NoteTitle = xmlDoc.CreateAttribute("Title");
            XmlAttribute NoteContent = xmlDoc.CreateAttribute("Content");
            while (true)
            {
                Console.WriteLine("Enter Your desired title for note!");
                NoteTitle.Value = Console.ReadLine();
                /// <summary>
                /// Asks user for note title
                /// </summary>

                if (NoteTitle.Value.Contains(" "))
                {
                    Console.WriteLine("Note can't contain spaces");
                }
                /// <summary>
                /// Checks if note contains spaces
                /// </summary>
                if (NoteTitle.Value.Length <= 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Title must be atleast 2 letters long!");
                        Console.WriteLine("Enter Your desired title for note!");
                        NoteTitle.Value = Console.ReadLine();
                        if (NoteTitle.Value.Length <= 1)
                        {

                        }
                        if (NoteTitle.Value.Length >= 1)
                        {
                            break;
                        }
                    }
                }
                /// <summary>
                /// Checks if note is atleas 2 letters long
                /// </summary>
                if (NoteTitle.Value.Length >= 13)
                {
                    while (true)
                    {
                        Console.WriteLine("Title can't be longer than 12 letters");
                        Console.WriteLine("Enter Your desired title for note!");
                        NoteTitle.Value = Console.ReadLine();
                        if (NoteTitle.Value.Length >= 13)
                        {

                        }
                        if (NoteTitle.Value.Length <= 13)
                        {
                            break;
                        }
                    }
                }
                /// <summary>
                /// Checks if letter is longer than 13 letters
                /// </summary>
                {

                }
                if (!NoteTitle.Value.Contains(" "))
                {
                    break;
                }
            }
            Notes.Attributes.Append(NoteTitle);

            Console.WriteLine("Write your desired note.");
            NoteContent.Value = Console.ReadLine();
            /// <summary>
            /// Asks user to write a note
            /// </summary>
            if (NoteContent.Value.Length >= 140)
            /// <summary>
            /// Checks if not isn't longer than 140 letters
            /// </summary>
            {
                while (true)
                {
                    Console.WriteLine("Note can't be longer than 140 letters");
                    Console.WriteLine("Write your desired note.");
                    NoteTitle.Value = Console.ReadLine();
                    if (NoteTitle.Value.Length >= 140)
                    {

                    }
                    if (NoteTitle.Value.Length <= 140)
                    {
                        break;
                    }

                }
            }
            Notes.Attributes.Append(NoteContent);

            rootnode.AppendChild(Notes);
            xmlDoc.Save("../../Notes.xml");

            Console.WriteLine("Would you like to return to menu or quit?\n1.Return\n2.Quit");
            /// <summary>
            /// Gives user a choice of returning to menu or quitting
            /// </summary>
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.Clear();
            }
            if (choice2 == "2")
            {
                Environment.Exit(0);
            }

        }
    }
}
