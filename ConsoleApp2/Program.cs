using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> namen = new List<string>();

            //namen.Add("Yunus");
            //namen.Add("Max");

            //for (int i = 0; i < namen.Count; i++) 
            //{
            //    namen[i] = namen[i].ToUpper();
            //}

            FileStream fileStream = new FileStream(@"..\..\Dateien\irgendwas.txt", 
                FileMode.Create,FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);

            writer.WriteLine("Hallo Welt!");

            writer.WriteLine("");
            writer.WriteLine("Ich grüße dich vom Neptun!\nIch gehe nach Hause.");

            writer.Close();
            FileStream fileStream2 = new FileStream(@"..\..\Dateien\irgendwas.txt",
                FileMode.Open);
            StreamReader reader = new StreamReader(fileStream2);

            string datei = reader.ReadToEnd();
            Console.WriteLine(datei);
            reader.Close();
            Console.ReadKey();

        }
    }
}
