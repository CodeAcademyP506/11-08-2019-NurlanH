using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkStudentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Hi, What is your name ?");
            string personName = (Console.ReadLine()).ToUpper();
            if (personName != null && personName != "")
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Wellcome " + personName);
            }
            else
            {
                Console.WriteLine("Answer isn't correct");
                return;
            }
            Console.WriteLine("=======================");
            Console.WriteLine("Are you a student ? Please answer (yes or no)");
            string isStudent = (Console.ReadLine()).ToUpper();
            Console.WriteLine("=======================");
            if (isStudent == "YES")
            {
                var result = student();
                Console.WriteLine("Thank you " + personName + " " + result);
                Console.WriteLine("=======================");
            }
            else if(isStudent == "NO")
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Are you a worker ? Please answer (Yes or No)");
                string isWorker = (Console.ReadLine()).ToUpper();
                if (isWorker == "YES")
                {
                    Console.WriteLine("=======================");
                    var result2 = worker();
                    Console.WriteLine("Thank you " + personName + " " + result2);
                    Console.WriteLine("=======================");
                }
                else if (isWorker == "NO")
                {
                    Console.WriteLine("=======================");
                    var result3 = pupil();
                    Console.WriteLine("Thank you " + personName + " " + result3);
                    Console.WriteLine("=======================");
                }
                else
                {
                    Console.WriteLine("Answer is not correct");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Answer is not correct");
                return;
            }
        }

        static string student() 
        {
            Console.WriteLine("Where are you study ?");
            string universty = Console.ReadLine();
            Console.WriteLine("=======================");
            Console.WriteLine("What is your speciality");
            string speciality = Console.ReadLine();
            Console.WriteLine("=======================");
            Console.WriteLine("Please input a number 1 between 100 or higher :D");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if(i%2 != 0)
                {
                    sum += i;
                }
            }
            return ("You are study in " + universty + " Your speciality is  \n" + speciality + " and " + "you know answer 1 between " + num + " numbers sum" + " is : " + sum);
            
        }
        static string worker()
        {
            Console.WriteLine("What is your Company? ");
            string company = (Console.ReadLine()).ToUpper();
            Console.WriteLine("=======================");
            Console.WriteLine("What is your job position? ");
            string job = (Console.ReadLine()).ToUpper();
            Console.WriteLine("=======================");
            Console.WriteLine("Plese input a number 1 between 101 or higher :D");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return ("You are in " + company + " " + job + " working" + " \n and you know answer 1 between " + num + " even numbers sum : " + sum);
        }

        static string pupil()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Please input a Number 1 between 200");
            Console.WriteLine(" ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");
            int sum = 0;

            for (int i =1; i < num; i++)
            {
                if(i % 6 ==0)
                {
                    sum += i;
                }
            }
            return (" Probably you are a pupil but you know \n 1 between " + num + " number divide 3 even numbers sum is : " + sum);
        }
    }
}
