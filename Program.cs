using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numone, numtwo = 0;
            string fname = "Chaminda", lname = "Amunugama";
            DateTime today_date = DateTime.Today;
            DateTime yest_day = DateTime.Today.AddDays(-1);
            DateTime tomo_day = DateTime.Today.AddDays(+1);

            Console.WriteLine("Hello " + fname + " " + lname + "..!");
            Console.WriteLine("Yesterdays date was :" + yest_day);
            Console.WriteLine("Todays date is : " + today_date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Tomorrows date is :" + tomo_day);

            Console.WriteLine("Hello I like to know you");
            Console.WriteLine("What is your first name :");
            string guest_fname = Console.ReadLine();
            string guest_lname = Console.ReadLine();
            Console.WriteLine("You are :" + guest_fname + " " + guest_lname + " Nice to meet you");

            string ori_text = "The quick fox Jumped Over the DOG";
            string swiched_text = ori_text.Replace("quick", "brown").Replace("DOG", "lazy dog");
            Console.WriteLine("Original text :" + ori_text);
            Console.WriteLine("Swiched text :" + swiched_text);

            string ori_num_patn = "[1,2,3,4,5]";
            ori_num_patn = ori_num_patn.Replace("[", "").Replace("]", "");
            List<string> numbers = ori_num_patn.Split(',').ToList();
            string[] to_compair = { "2", "3" };
            string[] to_add = { "6", "7", "8", "9", "10" };

            Console.WriteLine("Original number pattern" + ori_num_patn);
            foreach (string compair in to_compair) {
                if (numbers.Contains(compair)) {
                    numbers.Remove(compair);
                }
            }
            numbers.AddRange(to_add);
            Console.Write("[");
            foreach (var sxs in numbers) {
                    Console.Write(sxs);
                    Console.Write(",");
            }
            Console.WriteLine("]");

            //Addition 
            Console.WriteLine("Enter numbers to add followed by enter");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out numone))
                {
                    numtwo = numtwo + numone;
                }
                Console.WriteLine("Sum is " + numtwo);
            }
        }
    }
}
