using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlHarjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("1. Create new note");
                Console.WriteLine("2. Read already existing note");
                string choice1 = Console.ReadLine();
                if (choice1 == "1")
                {
                    i = i + 1;
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("../../Notes.xml");

                    XmlNode Notes = xmlDoc.CreateElement("Note" + i);
                    XmlNode rootnode = xmlDoc.SelectSingleNode("Notes");
                    XmlAttribute NoteTitle = xmlDoc.CreateAttribute("Title");
                    XmlAttribute NoteContent = xmlDoc.CreateAttribute("Content");
                    while (true)
                    {
                        Console.WriteLine("Enter Your desired title for note!");
                        NoteTitle.Value = Console.ReadLine();
                        //if (!string.IsNullOrEmpty(NoteTitle.Value))
                        //{
                        //    SomeFunction(NoteTitle.Value);
                        //}
                        //if (!string.IsNullOrEmpty(NoteTitle.Value))
                        //{
                        //    while (true)
                        //    {
                        //        Console.WriteLine("Title can't be empty");
                        //        Console.WriteLine("Enter Your desired title for note!");
                        //        NoteTitle.Value = Console.ReadLine();
                        //        if (!string.IsNullOrEmpty(NoteTitle.Value))
                        //        {
                        //            Console.WriteLine("Title can't be empty");
                        //            Console.WriteLine("Enter Your desired title for note!");
                        //            NoteTitle.Value = Console.ReadLine();
                        //            if (!string.IsNullOrEmpty(NoteTitle.Value))
                        //            {

                        //            }
                        //        }
                        //        break;
                        //    }
                        //}
                        if (NoteTitle.Value == "" || NoteTitle.Value == " " || NoteTitle.Value == "  " || NoteTitle.Value == "   " || NoteTitle.Value == "   " )
                        {
                            Console.WriteLine("Note can't be empty");
                        }
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
                        {

                        }
                        //while (!string.IsNullOrEmpty(NoteTitle.Value))
                        //{
                        //    Console.WriteLine("Note can't be empty");
                        //    Console.WriteLine("Enter Your desired title for note!");
                        //    NoteTitle.Value = Console.ReadLine();
                        //}
                        if (NoteTitle.Value != "" || NoteTitle.Value != " ")
                        {
                            break;
                        }
                    }
                    Notes.Attributes.Append(NoteTitle);

                    Console.WriteLine("Write your desired note.");
                    NoteContent.Value = Console.ReadLine();
                    //if (!string.IsNullOrEmpty(NoteContent.Value))
                    //{
                    //    Console.WriteLine("Note can't be empty");
                    //}
                    if (NoteContent.Value.Length >= 140)
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
                if (choice1 == "2")
                {
                    Console.Clear();
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load("../../Notes.xml");

                        foreach (XmlNode xmlnode in xmlDoc.DocumentElement.ChildNodes)
                        {
                            Console.WriteLine("Title " + xmlnode.Attributes["Title"].Value + ": ");

                            Console.WriteLine("Content: " + xmlnode.Attributes["Content"].Value);
                            Console.WriteLine("\n");

                        }
                        Console.ReadLine();
                        Console.WriteLine("Would you like to return to menu or quit?\n1.Return\n2.Quit");
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
            Environment.Exit(0);
           
        }
    }
    class Note
    {
        public string Content { get; set; }
        public string Title { get; set; }
    }
}
