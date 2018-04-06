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

            string ori = "[1,2,3,4,5]";
            string ori_num_patn = ori.Replace("[", "").Replace("]", "");
            List<string> numbers = ori_num_patn.Split(',').ToList();
            //numbers.Add("]");
            string[] to_compair = { "2", "3" };
            string[] to_add = { "6", "7", "8", "9", "10" };

            Console.WriteLine("Original number pattern" + ori);
            foreach (string compair in to_compair) {
                if (numbers.Contains(compair)) {
                    numbers.Remove(compair);
                }
            }
            numbers.AddRange(to_add);
            string inner_text="";
            foreach (var sxs in numbers) {
                  inner_text  = inner_text + "," + sxs;
            }
            int index = inner_text.IndexOf(",");
            if (index>=0)
            {
                inner_text = inner_text.Remove(index,1);
            }
            Console.Write("[");
            Console.Write(inner_text);
            Console.Write("]");


            //Addition 
            Console.WriteLine("Enter numbers to add followed by enter");

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out numone))
                {
                    string operater = Console.ReadLine();
                    switch (operater)
                    {
                        case "+":
                           numtwo = double.TryParse(Console.ReadLine(),out numtwo);
                            break;
                        case "-":

                        case "/":

                        case "*":

                        default:
                            Console.WriteLine("Operator error");
                            break;
                    }
                    numtwo = numtwo + numone;
                }
                Console.WriteLine("Sum is " + numtwo);
            }

            double convert_string_numbers(string num_str)
            {
                if (double.TryParse(Console.ReadLine(), out int_number))
                {
                    return int_numbers;
                }
        }
    }
}
