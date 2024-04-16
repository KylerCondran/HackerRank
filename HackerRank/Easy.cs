using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Easy
    {
        #region "Easy"
        //Title: Solve Me First
        //Link: https://www.hackerrank.com/challenges/solve-me-first
        //Tags: Problem Solving (Basic)
        public static int solveMeFirst(int a, int b)
        {
            return a + b;
        }
        //Title: A Very Big Sum
        //Link: https://www.hackerrank.com/challenges/a-very-big-sum
        //Tags: Problem Solving (Basic)
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (long i in ar)
            {
                sum += i;
            }
            return sum;
        }
        //Title: Compare the Triplets
        //Link: https://www.hackerrank.com/challenges/compare-the-triplets
        //Tags: Problem Solving (Basic)
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            int count = a.Count();
            List<int> ans = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
            }
            ans.Add(alice);
            ans.Add(bob);
            return ans;
        }
        //Title: Simple Array Sum
        //Link: https://www.hackerrank.com/challenges/simple-array-sum
        //Tags: Problem Solving (Basic)
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach (int i in ar)
            {
                sum += i;
            }
            return sum;
        }
        //Title: Plus Minus
        //Link: https://www.hackerrank.com/challenges/plus-minus
        //Tags: Problem Solving (Basic)
        public static void plusMinus(List<int> arr)
        {
            int total = arr.Count();
            int pos = 0;
            int neg = 0;
            int zero = 0;
            foreach (int i in arr)
            {
                if (i == 0)
                {
                    zero++;
                }
                else if (i > 0)
                {
                    pos++;
                }
                else if (i < 0)
                {
                    neg++;
                }
            }
            decimal a1 = (decimal)pos / (decimal)total;
            decimal a2 = (decimal)neg / (decimal)total;
            decimal a3 = (decimal)zero / (decimal)total;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
        }
        //Title: Staircase
        //Link: https://www.hackerrank.com/challenges/staircase
        //Tags: Problem Solving (Basic)
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string result = "";
                for (int j = 1; j < n - i; j++)
                {
                    result += " ";
                }
                for (int j = 0; j < i + 1; j++)
                {
                    result += "#";
                }
                Console.WriteLine(result);
            }
        }
        #endregion
    }
}
