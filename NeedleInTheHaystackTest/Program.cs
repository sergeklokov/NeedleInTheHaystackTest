using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace NeedleInTheHaystack
{
    public class Program
    {

        public static bool isNeedleInHaystock(string haystack, string needle)
        {

            // TODO: check for null conditions
            if (string.IsNullOrWhiteSpace(haystack))
                return false; // ??

            // if we have nothing to look, then it exists
            if (string.IsNullOrWhiteSpace(needle))
                return true; // ??

            int pos = 0;
            for (int j = 0; j < needle.Length; ++j)
            {
                bool currntMatch = false;
                for (int i = pos; i < haystack.Length; ++i) 
                {
                    if (needle[j] == haystack[i])
                    {
                        pos = i + 1;
                        currntMatch = true;
                        break;
                    }
                }
                if (!currntMatch)
                    return false;
            }

            return true;
        }


        public static bool isNeedleInHaystockByRegex(string haystack, string needle)
        {
            var pattern = new Regex("(" + string.Join(")|(", needle) + ")");

            var isFound = pattern.IsMatch(haystack);

            // let's print with $ - string interpolation
            Debug.WriteLine($"hay: {haystack} | needle: {needle} | pattern: {pattern} | isFound: {isFound}");
            return isFound;
        }


        static void Main()
        {
            Console.WriteLine(isNeedleInHaystock("aslkfjdsklfjls;adfk", "asl"));
            Console.WriteLine(isNeedleInHaystock("aslkfjdsklfjls;adfk", "dfk"));
            Console.WriteLine(isNeedleInHaystock("aslkfjdsklfjl", "kfss"));
            Console.WriteLine(isNeedleInHaystock("aslkf", null));
            Console.WriteLine(isNeedleInHaystock("aslkfjdsklfjls;adfk", "test"));

            //Console.WriteLine("press any key..");
            //Console.ReadKey();

        }
    }
}
