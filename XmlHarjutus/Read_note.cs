using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
/// <summary>
/// 
/// </summary>
namespace XmlHarjutus
{
    /// <summary>
    /// Class used to read notes
    /// </summary>
    public class Read_note
    {
        public static void Read_Note()
        {
            Console.Clear();
            {
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("../../Notes.xml");
                
                foreach (XmlNode xmlnode in xmlDoc.DocumentElement.ChildNodes)
                {
                    
                    Console.WriteLine("Title " + xmlnode.Attributes["Title"].Value + ": ");
                    /// <summary>
                    /// Writes out note's title
                    /// </summary>
                    Console.WriteLine("Content: " + xmlnode.Attributes["Content"].Value);
                    /// <summary>
                    /// Writes out note's content
                    /// </summary>
                    Console.WriteLine("\n");

                }
                Console.ReadLine();
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
}
