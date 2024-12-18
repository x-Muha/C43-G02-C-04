using System.Threading.Channels;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            /*1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Example 
            Input: 5
            Output: 1, 2, 3, 4, 5
            */

            //Console.Write("Enter a number: ");
            //int number =0;
            //if (int.TryParse(Console.ReadLine(), out number))
            //    {
            //        for (int i = 1; i < number; i++)
            //        {
            //            Console.Write($"{i}, ");
            //        } 
            //        Console.Write(number);
            //    }
            #endregion

            #region Q2

            /*2- Write a program that allows the user to insert an integer then 
            print a multiplication table up to 12.
            */

            //Console.Write("insert a number: ");
            //int number;
            //if (int.TryParse(Console.ReadLine(),out number)){
            //    for(int i=1;i<13;i++)
            //        Console.Write($"{i*number} ");
            //}
            #endregion

            #region Q3

            //Console.Write("insert a number: ");
            //int number;
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    for (int i = 2; i <= number; i += 2)
            //        Console.Write($"{i} ");
            //}

            #endregion

            #region Q4

            //Console.WriteLine("insert Two Numbers");
            //int number1, number2;
            //if (int.TryParse(Console.ReadLine(), out number1) && int.TryParse(Console.ReadLine(), out number2))
            //{
            //    Console.WriteLine(Math.Pow(number1,number2));
            //}

            #endregion

            #region Q5

            //Console.Write("Enter Marks of five subjects:");
            //int[] numbers = new int[5];
            //int totalMarks=0;

            //bool isParsed = true;
            //int counter = 0;
            //while (isParsed && counter < 5) { 
            //    isParsed = int.TryParse(Console.ReadLine(), out numbers[counter++]);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    totalMarks += numbers[i];
            //}
            //Console.Write($"Total marks = {totalMarks}\nAverage Marks = {totalMarks/5.0}\nPercentage = {totalMarks/5.0}%");

            #endregion

            #region Q6 & Q7

            //string? str = Console.ReadLine();
            //if (str != null)
            //    for (int i = str.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(str[i]);
            //    }

            #endregion

            #region Q8

            //bool isParsed = true;
            //int startNumber, endNumber;
            //isParsed &= int.TryParse(Console.ReadLine(), out startNumber);
            //isParsed &= int.TryParse(Console.ReadLine(), out endNumber);

            //if (isParsed)
            //{
            //    for (int i = startNumber; i <= endNumber; i++)
            //    {
            //        bool isPrime = true;
            //        int j = 2;
            //        while (j <= i / 2)
            //        {
            //            if (i % j++ == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }

            //        }
            //        if (isPrime) Console.Write($"{i} ");
            //    }

            //}

            #endregion

            #region Q9

            //int number = int.Parse(Console.ReadLine());
            //int divisbleByTwo;
            //String binary = "";
            //while (number > 0)
            //{
            //    divisbleByTwo = number % 2;
            //    binary = divisbleByTwo + binary;
            //    number /= 2;
            //}
            //Console.WriteLine(binary);


            #endregion

            #region Q10

            //Console.WriteLine("please input three points (x1, y1), (x2, y2), and (x3, y3):");
            //double[] v = new double[6];
            //for (int i = 0; i < 6; i++) v[i] = double.Parse(Console.ReadLine());

            //if (Math.Abs(v[0] - v[2]) / Math.Abs(v[1] - v[3]) == Math.Abs(v[0] - v[4]) / Math.Abs(v[1] - v[5]))
            //    Console.WriteLine("Single Line");
            //else Console.WriteLine("Not on Single Line");

            #endregion

            #region Q11

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //        if (i == j) Console.Write("1 ");
            //        else Console.Write("0 ");
            //    Console.WriteLine();
            //}

            #endregion

            #region Q12

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum+= arr[i];
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Q13
            //int[] arr1 = { 1, 80, 55, 13};
            //int[] arr2 = { 30, 2, 19, 14};
            //int[] arr = new int[8];

            //int i = 0;
            //foreach (int x in arr1)
            //{
            //    arr[i] = x;
            //    i++;
            //}
            //foreach (int x in arr2)
            //{
            //    arr[i] = x;
            //    i++;    
            //}
            //foreach(int x in arr) Console.Write($"{x} ");
            //Console.WriteLine();
            //Array.Sort(arr);
            //foreach (int x in arr) Console.Write($"{x} ");
            #endregion

        }
    }
}
