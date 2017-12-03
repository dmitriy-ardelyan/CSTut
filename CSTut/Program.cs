using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CSTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello internet");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));

            SayHello();

            bool canIVote = true;
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            decimal decPiVal = 3.14159265358979M;
            decimal decBigNum = 3.00000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);

            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000000;
            Console.WriteLine("DEC : PI + bigNum = {0}", dblPiVal + dblBigNum);

            Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Double : {0}", Double.MinValue);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            bool boolFromStr = bool.Parse("true");
            int inFromStr = int.Parse("100");
            double doubleFromStr = double.Parse("1,234");

            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of weer : {0}", awesomeDate.DayOfWeek);

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New date : {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());


            BigInteger bigNum = BigInteger.Parse("12345622222222222");
            Console.WriteLine("Big num * 2 = {0}", bigNum * 2);

            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4553333);
            Console.WriteLine("Currency : {0:n4}", 2300);

            string randomString = "This is a string";
            Console.WriteLine("String Length : {0}", randomString.Length);
            Console.WriteLine("String contains is : {0}", randomString.Contains("is"));
            Console.WriteLine("Index of is : {0}", randomString.IndexOf("is"));
            Console.WriteLine("Remove string : {0}", randomString.Remove(0, 6));
            Console.WriteLine("Insert string : {0}", randomString.Insert(10, "short "));
            Console.WriteLine("Replace string : {0}", randomString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}", String.Compare("A","B", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("A = a :{0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}", randomString.PadLeft(20, '.'));
            Console.WriteLine("Pad Left : {0}", randomString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}", randomString.Trim());
            Console.WriteLine("Uppercase : {0}", randomString.ToUpper());
            Console.WriteLine("Uppercase : {0}", randomString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            Console.Write(@"Exactly wht i typed '\");
            Console.WriteLine("String for Git testing");
            //random comment33
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
