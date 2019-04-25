using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             * A one-dimensional array p contains four elements.  
             * The array access expressions to access each of the elements in p are ___p[0]____, ____p[1]___,___p[2]____ and ___p[3]___.
             * 
             */

            //Q3
            string[] month = new string[12];
            month[0] = "January";
            month[1] = "Febraury";
            month[2] = "March";
            month[3] = "April";
            month[4] = "May";
            month[5] = "June";
            month[6] = "July";
            month[7] = "August";
            month[8] = "September";
            month[9] = "October";
            month[10] = "November";
            month[11] = "December";
            {
                for (int counter = 0; counter < month.Length; ++counter)
                    Console.WriteLine("{0}{1,15}", counter + 1, month[counter]);

            }
            //Q4

            string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
            Console.WriteLine("The Four Seasons");
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }

            //Q5

            int[] randomNumber = new int[1000];
            Random random = new Random();
            for (int a = 0; a < randomNumber.Length; a++)
            {
                randomNumber[a] = random.Next(0, 100);

            }
            foreach (int a in randomNumber)
            {
                Console.Write("{0} ",a.ToString());
            }

            //Q6

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("\n {0}",names[i]);
                i++;
            }

            //Q7

            string[] znames = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int ii = 0;
            while (ii < znames.Length)
            {
                Console.WriteLine("{0,2}. {1} \n", ii, znames[ii]);
                ii++;
            }

            //Q8

            string[] persons = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int p = 0;
            foreach (string person in persons)
            {
                Console.WriteLine("{0,2}. {1} \n", p, persons[p]);
                p++;
            }


            /*Command which allows you close Window*/
            Console.WriteLine("\n \n Press the Enter Key to Close..");// Command used to display closed message.
            Console.ReadLine(); // Command used to keep window open

        }
    }
}
