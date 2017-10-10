using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_Extra.Models;
using System.IO;
using System.Threading;

namespace Lesson_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Write to a textfile using the person list, name and age of accountants over 33

            // var allAcountants = 

            //create a file with a song or poet, write it out in console

            //string textToSave = "";
            //var p = Person.GenerateListOfPeople();

            //var accountantsOver33 = p.Where(x => x.Occupation.ToLower() == "accountant" && x.Age > 33);

            //foreach (var item in accountantsOver33)
            //{
            //    textToSave += item.FirstName + " " + item.LastName.PadRight(10) + "Age: " + item.Age + " " + item.Occupation + Environment.NewLine;
            //}

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            docPath += @"\poem.txt";

            //File.WriteAllText(docPath, textToSave);

            //Console.WriteLine(docPath);

            try
            {
                using (StreamReader sr = new StreamReader(docPath))
                {
                    string poem = sr.ReadToEnd();
                    foreach (char c in poem)
                    {
                        Console.Write(c);
                        Thread.Sleep(80);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("You did something wrong..");
                Console.WriteLine(e.Message);
            }
        }


    
    }
}
