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
            ////Exercise 1
            //console_write("Exercise 1", true);
            //double numone, numtwo = 0;
            //string fname = "Chaminda", lname = "Amunugama";
            //console_write(fname + " " + lname);

            ////Exercise 2
            //console_write("Exercise 2", true);
            //DateTime today_date = DateTime.Today;
            //DateTime yest_day = DateTime.Today.AddDays(-1);
            //DateTime tomo_day = DateTime.Today.AddDays(+1);

            //Console.WriteLine("Hello " + fname + " " + lname + "..!");
            //Console.WriteLine("Yesterdays date was :" + yest_day);
            //Console.WriteLine("Todays date is : " + today_date.ToString("dd/MM/yyyy"));
            //Console.WriteLine("Tomorrows date is :" + tomo_day);

            ////Exercise 3
            //console_write("Exercise 3", true);
            //Console.WriteLine("Hello I like to know you");
            //Console.WriteLine("What is your first name :");
            //string guest_fname = Console.ReadLine();
            //string guest_lname = Console.ReadLine();
            //Console.WriteLine("You are :" + guest_fname + " " + guest_lname + " Nice to meet you");

            ////Exercise 4
            //void ex04_fuction()
            //{
            //    console_write("Exercise 4", true);
            //    string ori_text = "The quick fox Jumped Over the DOG";
            //    string swiched_text = ori_text.Replace("quick", "brown").Replace("DOG", "lazy dog");
            //    Console.WriteLine("Original text :" + ori_text);
            //    Console.WriteLine("Swiched text :" + swiched_text);
            //}

            ////Exercise 5
            //console_write("Exercise 5", true);
            //string ori = "sdsdsdsdsrttktjhtjhio[1,2,3,4,5]trrtrtr";
            //int ex05_1 = ori.IndexOf('[');
            //int ex05_2 = ori.IndexOf(']');
            //int ex05_length = ex05_2 - ex05_1;
            //string ori_new = ori.Substring(ex05_1,ex05_length+1);
            //string ori_num_patn = ori_new.Replace("[", "").Replace("]", "");
            //List<string> numbers = ori_num_patn.Split(',').ToList();
            //string[] to_compair = { "2", "3","4" };
            //string[] to_add = { "6", "7", "8", "9", "10" };

            //Console.WriteLine("Original number pattern" + ori_new);
            //foreach (string compair in to_compair)
            //{
            //    if (numbers.Contains(compair))
            //    {
            //        numbers.Remove(compair);
            //    }
            //}
            //numbers.AddRange(to_add);
            //string inner_text = "";
            //foreach (var sxs in numbers)
            //{
            //    inner_text = inner_text + "," + sxs;
            //}
            //int index = inner_text.IndexOf(",");
            //if (index >= 0)
            //{
            //    inner_text = inner_text.Remove(index, 1);
            //}
            //Console.Write("Modifyed text :");
            //Console.Write("[");
            //Console.Write(inner_text);
            //Console.Write("]");


            ////Exercise 6
            //console_write("Exercise 6",true);
            //double ex6_number_1, ex6_number_2 = 0;
            //console_write("Enter two numbers to find biggest, smallest, difference (- ), sum(+), product(* ) and ratio( / ) between the two numbers",true);
            //console_write("Enter 1st number : ");
            //double.TryParse(Console.ReadLine(), out ex6_number_1);
            //Console.WriteLine();
            //console_write("Enter 2nd number : ");
            //double.TryParse(Console.ReadLine(), out ex6_number_2);
            //Console.WriteLine();
            //if (ex6_number_1 > ex6_number_2)
            //{
            //    console_write("1st Number is the biggest which is :" + ex6_number_1,true);
            //    console_write("2nd Number is the smallest which is :" + ex6_number_2,true);
            //}
            //else
            //{
            //    console_write("2nd Number is the biggest which is :" + ex6_number_2,true);
            //    console_write("1st Number is the smallest which is :" + ex6_number_1,true);
            //}

            //string add = (ex6_number_1 + ex6_number_2).ToString();
            //string sub = (ex6_number_1 - ex6_number_2).ToString();
            //string mul = (ex6_number_1 * ex6_number_2).ToString();
            //string div = (ex6_number_1 / ex6_number_2).ToString();

            //console_write("Sum is :" + add, true);
            //console_write("Difference is :" + sub,true);
            //console_write("Product is :" + mul,true);
            //console_write("Ratio is :" + div,true);


            ////Exercise 7
            //console_write("Exercise 7", true);
            //console_write("Input radius of the sphere :");
            //double sphere_radius = 0;
            //if (double.TryParse(Console.ReadLine(), out sphere_radius))
            //{
            //    console_write("",true);
            //    double area = (2 * 22 * sphere_radius)/7;
            //    double volume = (4 * 22 * Math.Pow(sphere_radius, 3))/21;
            //    console_write("Sphere area will be :" + area + "  =~  " + Math.Round(area,2), true);
            //    console_write("Sphere volume will be :" + volume + "  =~  " + Math.Round(volume, 2), true);
            //}
            //else
            //{
            //    console_write("please enter a valid number !",true);
            //    console_write("",true);
            //    console_write("Input radius of the sphere :", true);
            //}

            ////Exercise 8
            //double ex8_number = 0;
            //console_write("Exercise 8", true);
            //console_write("Input the number to calculate square root and raised to the power of 2 and 10",true);
            //console_write("Input the number :");
            //if (double.TryParse(Console.ReadLine(), out ex8_number))
            //{
            //    double ex8_square = Math.Sqrt(ex8_number);
            //    double ex8_power2 = Math.Pow(ex8_number, 2);
            //    double ex8_power10 = Math.Pow(ex8_number,10);

            //    console_write("The square root of the number :" + ex8_square + " =~ " + Math.Round(ex8_square,2),true);
            //    console_write("The number into power of 2 :" + ex8_power2, true);
            //    console_write("The number into power of 10 :" + ex8_power10, true);
            //}
            //else
            //{
            //    console_write("please enter a valid number !", true);
            //    console_write("", true);
            //    console_write("Input the number :", true);
            //}


            //Exercise 10
            //while (true)
            //{
            //    int ex10_option = 0;
            //    double ex10_number1, ex10_number2 = 0;
            //    console_write("Exercise 10", true);
            //    console_write("Please choose between following options", true);
            //    console_write("Option 1 : Divide number1 by number 2 ", true);
            //    console_write("Option 2 : Invoke Exercise 04 ", true);
            //    console_write("Option 3 : Toggle foreground color between red and yellow for each key stroke ", true);
            //    console_write("Option 00 : Return to menu or exit ", true);
            //    console_write("Type 1 or 2 or 3 or 00 and press enter to select a option",true);
            //    console_write("Type your selection", true);
            //    if (int.TryParse(Console.ReadLine(), out ex10_option))
            //    {
            //        switch (ex10_option)
            //        {
            //            case 1:
            //                console_write("Enter Number 1 :");
            //                string check = Console.ReadLine();
            //                int run = 0;
            //                while ("00" != check)
            //                {

            //                  if (0 != run)
            //                  {
            //                        console_write("Enter Number 1 :");
            //                        check = Console.ReadLine();
            //                  }
            //                    if ("00" != check)
            //                    {
            //                        if (double.TryParse(check, out ex10_number1))
            //                        {
            //                            console_write("", true);
            //                            console_write("Enter Number 2 :");
            //                            string check2 = Console.ReadLine();
            //                            console_write("", true);
            //                            if ("0" == check2)
            //                            {
            //                                console_write("cannot divide by zero", true);
            //                            }
            //                            else if ("00" == check2)
            //                            {
            //                                break;
            //                            }
            //                            else
            //                            {
            //                                double.TryParse(check2, out ex10_number2);
            //                                console_write("Answer is : " + ex10_number1 / ex10_number2, true);
            //                            }
            //                        }

            //                        else
            //                        {
            //                            console_write("Please enter valid number!:", true);
            //                            console_write("Enter Number 1 :");
            //                            check = Console.ReadLine();
            //                        }
            //                        run++;
            //                    }
            //                    else
            //                    {
            //                        Console.Clear();
            //                        break;
            //                    }
            //                }
            //                Console.Clear();
            //                break;
            //            case 2:
            //                ex04_fuction();
            //                console_write("",true);
            //                console_write("", true);
            //                //Console.Clear();
            //                break;
            //            case 3:
            //                string color_check = Console.ReadLine();
            //                while ("00" != color_check)
            //                {
            //                    if (Console.BackgroundColor == ConsoleColor.Black)
            //                    {
            //                        Console.BackgroundColor = ConsoleColor.Red;
            //                    }
            //                    else
            //                    {
            //                        Console.BackgroundColor = ConsoleColor.Black;
            //                    }
            //                    color_check = Console.ReadLine();
            //                }
            //                Console.Clear();
            //                break;
            //            case 00:
            //                Environment.Exit(0);
            //                break;
            //            default:
            //                Console.Clear();
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        console_write("please enter a valid option !", true);
            //        console_write("", true);
            //        console_write("Type 1 or 2 or 3 and press enter to select a option");
            //    }
            //}

            ////Exercise 11
            //console_write("Exercise 11", true);
            //console_write("Input a number :", true);
            //int ex11_number = 0;
            //while (true)
            //{
            //    string ex11_input = Console.ReadLine();
            //    if ("00" == ex11_input)
            //    {
            //        Environment.Exit(0);
            //    }
            //    else
            //    { 
            //        if (int.TryParse(ex11_input,out ex11_number))
            //        {
            //            if (ex11_number > 0)
            //            {
            //                for (int i = 0; i <= ex11_number; i++)
            //                {
            //                    int reminder = 0;
            //                    Math.DivRem(i, 2, out reminder);
            //                    if (0 == reminder)
            //                    {
            //                        Console.BackgroundColor = ConsoleColor.Red;
            //                        console_write("Counting up" + i, true);
            //                    }
            //                    else
            //                    {
            //                        Console.BackgroundColor = ConsoleColor.Green;
            //                        console_write("Counting up" + i, true);
            //                    }
            //                }
            //                console_write("", true);
            //                console_write("", true);
            //                for (int j = ex11_number; j >= 0; j--)
            //                {
            //                    int reminder = 0;
            //                    Math.DivRem(j, 2, out reminder);
            //                    if (0 == reminder)
            //                    {
            //                        Console.BackgroundColor = ConsoleColor.Red;
            //                        console_write("Counting down" + j, true);
            //                    }
            //                    else
            //                    {
            //                        Console.BackgroundColor = ConsoleColor.Green;
            //                        console_write("Counting down" + j, true);
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            console_write("please enter a valid number !", true);
            //            console_write("", true);
            //            console_write("Input the number :", true);
            //        }
            //    }
            //}

            ////Exercise 12
            //console_write("Exercise 12", true);
            //for (int i = 1; i <= 10 ; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        console_write("\t"+(i*j).ToString());
            //    }
            //    console_write("", true);
            //}

            ////Exercise 13
            //console_write("Exercise 13", true);
            //while (true)
            //{

            //    string ex13_input = Console.ReadLine();
            //    if ("00" == ex13_input)
            //    {
            //        Environment.Exit(0);
            //    }
            //    else
            //    {
            //        Random ex13_number = new Random();
            //        int rand_number = ex13_number.Next(1, 500);
            //        int ex11_user__number = 0;
            //        int.TryParse(ex13_input,out ex11_user__number);

            //        if (rand_number != ex11_user__number && rand_number < ex11_user__number)
            //        {
            //            console_write("Your guess was too big", true);
            //        }
            //        else if (rand_number != ex11_user__number && rand_number > ex11_user__number)
            //        {
            //            console_write("Your guess was too small", true);
            //        }
            //        else if (rand_number == ex11_user__number)
            //        {
            //            console_write("!!!!!!!!!!!!! Ohooo yeahhhh you are correct !!!!!!!!!!!!!", true);
            //        }
            //    }



            //}

            ////Exercise 14
            //console_write("Exercise 14", true);
            //List<double> ex14_number_list = new List<double>();
            //while (true)
            //{
            //    console_write("Enter a number :");
            //    string ex14_input = Console.ReadLine();
            //    if ("-1" != ex14_input)
            //    {
            //        double ex14_number_to_remember = 0;
            //        double.TryParse(ex14_input, out ex14_number_to_remember);
            //        ex14_number_list.Add(ex14_number_to_remember);
            //    }
            //    else if ("-1" == ex14_input)
            //    {
            //        double sum = 0;
            //        double avg = 0;
            //        foreach (double ex14_mem_number in ex14_number_list)
            //        {
            //            sum = sum + ex14_mem_number;
            //        }
            //        avg = sum / ex14_number_list.Count();
            //        console_write("Sum is "+sum,true);
            //        console_write("Average is " + avg, true);
            //        ex14_number_list.Clear();
            //    }

            //}

            ////Exercise 15
            //console_write("Exercise 15", true);
            //while (true)
            //{
            //    console_write("Enter a number :");
            //    string ex15_input = Console.ReadLine();
            //    if ("-1" != ex15_input)
            //    {
            //        double ex15_number = 0;
            //        double.TryParse(ex15_input,out ex15_number);
            //        for (int i = 0; i < ex15_number; i++)
            //        {
            //            if (0 == ex15_number%i)
            //            {
            //                console_write(i.ToString()+"\t");
            //            }
            //        }
            //        console_write("",true);
            //        console_write("How many perfect numbers to generate :");
            //        int ex15_number_of_pef = 0;
            //        int.TryParse(Console.ReadLine(),out ex15_number_of_pef);
            //        int ex15_comp_num = 5;
            //        int ex15_sum_check = 0;
            //        int ex15_found_perf = 0;

            //        List<int> ex15_perfect_numbers = new List<int>();
            //        List<int> ex15_perf_divi = new List<int>();
            //        List<int> ex153_perf_divi = new List<int>();
            //        List<int> ex152_perf_divi = new List<int>();
            //        List<int> ex151_perf_divi = new List<int>();
            //        while (ex15_found_perf != ex15_number_of_pef)
            //        {

            //            int i = 1;
            //            if (ex15_number_of_pef == 4) {
            //                while (i < ex15_comp_num)
            //                {
            //                    if (0 == ex15_comp_num % i)
            //                    {
            //                        ex15_perf_divi.Add(i);
            //                    }
            //                    i++;
            //                }
            //            }

            //            int ex15_perf_divi_length = ex15_perf_divi.Count();
            //            int ex15_length_count = 1;
            //            foreach (int ex15_perf_each_div in ex15_perf_divi)
            //            {
            //                ex15_sum_check = ex15_sum_check + ex15_perf_each_div;

            //                if (ex15_sum_check == ex15_comp_num && ex15_perf_divi_length == ex15_length_count)
            //                {
            //                    ex15_perfect_numbers.Add(ex15_comp_num);
            //                    ex15_found_perf++;
            //                }
            //                ex15_length_count++;
            //            }
            //            ex15_perf_divi.Clear();
            //            ex15_sum_check = 0;
            //            ex15_comp_num++;
            //        }
            //        foreach (int ex15_print_pref in ex15_perfect_numbers)
            //        {
            //            console_write(ex15_print_pref.ToString()+"\t",true);
            //        }
            //    }
            //    else if ("-1" == ex15_input)
            //    {
            //        Environment.Exit(0);
            //    }

            //}

            ////Exercise 16
            //console_write("Exercise 16", true);
            //console_write("How long the Fibonacci Sequence need to be :");
            //int ex16_feb_long = 0;
            //int.TryParse(Console.ReadLine(),out ex16_feb_long);
            //List<int> ex16_feb_seq = new List<int>();
            //int ex16_feb_start = 2;
            //int ex16_feb_next = 0;
            //ex16_feb_seq.Add(0);
            //ex16_feb_seq.Add(1);

            //while (ex16_feb_seq.Count() <= ex16_feb_long)
            //{
            //    ex16_feb_next = ex16_feb_seq.ElementAt(ex16_feb_start - 2) + ex16_feb_seq.ElementAt(ex16_feb_start - 1);
            //    ex16_feb_seq.Add(ex16_feb_next);
            //    ex16_feb_start++;

            //}
            //foreach (int ex16_print_feb in ex16_feb_seq)
            //{
            //    console_write(ex16_print_feb.ToString() + "\t");
            //}

            //Exercise 17
            console_write("Exercise 17", true);
            while (true)
            {
                console_write("Enter the text to check palindrome :");
                string ex17_entered = Console.ReadLine();
                string ex17_enter = ex17_entered.Replace(" ", "");
                string ex17_enter_invert = "";
                char[] ex17_char_list_invert = ex17_enter.ToCharArray();
                Array.Reverse(ex17_char_list_invert);
                foreach (char item in ex17_char_list_invert)
                {
                    ex17_enter_invert = ex17_enter_invert + item;
                }

                if (ex17_entered != "-1")
                {
                    if (ex17_enter == ex17_enter_invert)
                    {
                        console_write(ex17_entered + " is a palindrome ", true);
                    }
                    else
                    {
                        console_write(ex17_entered + " is not a palindrome ", true);
                    }
                }
                else if (ex17_entered == "-1")
                {
                    Environment.Exit(0);
                }
            }
            Console.ReadKey();
            //function to print base on newline true or false
            void console_write(string to_print, bool br = false)
            {
                if (true == br)
                {
                    Console.WriteLine(to_print);
                    
                }
                else
                {
                    Console.Write(to_print);
                    
                }
            }
        }
    }
}
