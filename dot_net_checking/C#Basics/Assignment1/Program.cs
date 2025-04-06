 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {

        static void primeOrNot()
        {
            Console.WriteLine("Enter a number to check if it is Prime:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("Number is not Prime (Prime numbers are greater than 1)");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("The given number is not Prime.");
            }
        }


        static void isPalindrom()
        {
            Console.WriteLine("Enter Number for to chaek is Palindrom or Not ..");
           int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int palindrom = 0;
           while(temp > 0) { 
                int num1 = temp % 10;
                palindrom = palindrom * 10 + num1;
                temp= temp / 10;
                

            }
           if(palindrom == num)
            {
                Console.WriteLine("number is palindrom ");
            }
            else
            {
                Console.WriteLine("number is not palindrom");
            }

        }

        static void squreRoot()
        {
            Console.WriteLine("Enter Number for squre root");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num <= 0)
            {
                Console.WriteLine("Please Enter Positive Number ... ");
            }
            else
            {
                double sqroot = Math.Sqrt(num);
                Console.WriteLine("squre root of "+num +" is : "+sqroot);
            }
            
        }


        static void Shuffl()
        {
            string str = "fergusson";
            Console.WriteLine("String Shuffling : "+str);
            char[] charArray = str.ToCharArray();

            char temp = charArray[0];
            charArray[0] = charArray[str.Length - 1];
            charArray[str.Length - 1] = temp;

            string newString = new string(charArray);
            Console.WriteLine("shuffled string is " + newString);
    }


        static void sumDigit()
        {
            Console.WriteLine("Enter Number for sum Digit :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            while(num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine("sum of digit is : " + sum);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Check Prime");
                Console.WriteLine("2. Check Palindrome");
                Console.WriteLine("3. Find Square Root");
                Console.WriteLine("4. Shuffle String");
                Console.WriteLine("5. Sum of Digits");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        primeOrNot();
                        break;
                    case "2":
                        isPalindrom();
                        break;
                    case "3":
                        squreRoot();
                        break;
                    case "4":
                        Shuffl();
                        break;
                    case "5":
                        sumDigit();
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

    }
}
