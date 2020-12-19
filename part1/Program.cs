using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace part1
{
    class Program
    {

        static void Main(string[] args)
        {
            int result = 0;
            int totalstudents = 0;
            var data = System.IO.File.ReadAllText("c:StudentInformation.txt");
            var arrays = new List<float[]>();
            var lines = data.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                // Create a new List<float> representing all the commaseparated numbers in this line
                totalstudents++;
                var lineArray = new List<float>();

                // Slipt line by , and loop through all the numeric valus
                foreach (var s in line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    // Add converted numeric value to our lineArray 
                    lineArray.Add(Convert.ToInt64(s));
                    //lineArray.Add(Convert.ToSingle(s));
                }
                // Add lineArray to main array
                arrays.Add(lineArray.ToArray());


                // Loop repeats until there are noe more lines

                int i = 0;
                while (i < lineArray.Count)
                {
                    result += Convert.ToInt32(lineArray[i++]);
                }

                
               
            }
            Console.ReadLine();

           data.Close();
           int totalscore = result;
           double average = totalscore / totalstudents;
           StreamWriter pw = new StreamWriter("StudentStats.txt");
           pw.WriteLine("The average score of the students was: " + average);
           pw.Close();


        }
    }
}
