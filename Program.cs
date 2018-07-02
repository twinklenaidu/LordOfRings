using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace StairCase
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Program
    {
        public void PrintStars()
        {
            // standard input for total number of rows or maximum number of #s
            int T = Convert.ToInt16(Console.ReadLine());

            // loop over number of rows
            for (short i = 1; i <= T; ++i)
            {
                for (int j = 1; j <= T; ++j)
                {
                    if (j <= T - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
        public void DivisibleSum(int n, int k, List<int> arr)
        {
            List<int> temp = new List<int>();
            arr.Sort();
            
            int count = 0;
            
            int sum = 0;
            for(int i=0;i< arr.Count(); i++)
            {
                for(int j=0;j<arr.Count();j++)
                {
                    if (arr[i] < arr[j])
                    {
                        sum = arr[i] + arr[j];
                        if (sum % k == 0 && sum != 0)
                            count++;
                    }
                }
            }
            Console.WriteLine(count);
            
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode res = null; 
            ListNode prev = null;
            ListNode temp = null;
            int carry = 0, sum;

            while (l1 != null || l2 != null) 
            {
               
                sum = carry + (l1 != null ? l1.val : 0)
                        + (l2 != null ? l2.val : 0);

                // update carry for next calulation
                carry = (sum >= 10) ? 1 : 0;

                // update sum if it is greater than 10
                sum = sum % 10;

                // Create a new node with sum as data
                temp = new ListNode(sum);

                // if this is the first node then set it as head of
                // the resultant list
                if (res == null)
                {
                    res = temp;
                }
                else // If this is not the first node then connect it to the rest.
                {
                    prev.next = temp;
                }

                prev = temp;

                
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new ListNode(carry);
            }

           
            return res;
        }
        public class Node
        {
            public Node Next;
            public object Value;
        }
        public class LinkedList
        {
            public Node head;
            public Node current;//This will have latest node
            public int Count;
            public LinkedList()
            {
                head = new Node();
                current = head;
            }
        }
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            
            int[] result;
            List<int> temp = new List<int>();
            int Player1 = 0; int Player2=0;

             Player1 = ((a0 > b0) ? 1 : 0) + ((a1 > b1) ? 1 : 0) + ((a2 > b2) ? 1 : 0);
             Player2 = ((a0 < b0) ? 1 : 0) + ((a1 < b1) ? 1 : 0) + ((a2 < b2) ? 1 : 0);

            //if (a0 > b0 || a1>b1 || a2>b2)
            //    Player1++;
            //if (b0 > a0 || b1>a1 || b2>a2)
            //    Player2++;

            temp.Add(Player1); temp.Add(Player2);
            result = temp.ToArray();
            return result;

        }
        static int[] gradingStudents(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if(grades[i]>38 && grades[i]%5>2)
                {
                    grades[i] = grades[i] + (5 - grades[i] % 5);
                }
            }
            return grades;

        }
        static int totalForecastInaccuracy(int[] t, int[] f)
        {
            // Return the sum of the weather forecast inaccuracies across all 7 days.
            int sum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += Math.Abs(t[i] - f[i]);
            }
            return sum;

        }
        public int[] Intersect(int[] nums1, int[] nums2)
        {
           var elements = nums1.Intersect(nums2);
            List<int> result = new List<int>();
            int count_1 = 0; int count_2 = 0;
            foreach (var inter in elements)
            {
                foreach (var input1 in nums1)
                {
                    if (inter == input1)
                        count_1++;
                }
                foreach (var input2 in nums2)
                {
                    if (inter == input2)
                        count_2++;
                }
            }
            result.Add(count_1); result.Add(count_2);
            
            return result.ToArray();
        }
        static string solveYear(int year)
        {
            if (year == 1918)
                return "26.09.1918";
            else if (((year <= 1917) && (year % 4 == 0)) || ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0) ) ))
            {
                string date = "12.09." + year;
                return date;
            }
             else
            {
                string date = "13.09." + year;
                return date;
            }

        }
        public static string BonAppetite(int bill_charged,int k, int[] bill)
        {
            
            int bill_actual = 0; int bill_diff = 0;
            for (int i = 0; i < bill.Length; i++)
            {
                if(bill[i]!=bill[k])
                {
                    bill_actual += bill[i];
                }
            }
            bill_actual = (bill_actual / 2);
            if (bill_charged == bill_actual)
                return "Bon Appetit";
            else
            {
                bill_diff = bill_charged - bill_actual;
                return bill_diff.ToString();
            }
        }
        static void separateNumbers(string s)
        {
            if (s.Length < 2)
                Console.WriteLine("NO");
            else if (s[0] == 0)
                Console.WriteLine("NO");
            else
            {
                //check if consecutive nos or not
                int i = 1;
                long firstx=-1;
               
                while (i<=(s.Length/2))
                {
                   
                    long x = long.Parse(s.Substring(0, i));
                    firstx = x;
                    String test = x.ToString();
                    while (test.Length < s.Length)
                    {
                        test += ++x ;
                    }
                    // Compare to original input
                    if (test.Equals(s))
                    {
                        Console.WriteLine("YES " + firstx);
                        break;
                    }
                }
            }
        }
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        static string caesarCipher(string s, int k)
        {
            string output = string.Empty;
            foreach (char ch in s)
                output += cipher(ch, k);
            return output;
        }
        static string pangrams(string s)
        {
            bool ispangram= s.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
            if (ispangram)
                return "pangram";
            else
                return "not pangram";

        }
        static string super_reduced_string(string s)
        {
            StringBuilder input = new StringBuilder(s);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    if (i + 1 >= input.Length)
                    {
                        input.Remove(i - 1, 2);
                    }
                    else
                    {
                        input.Remove(i - 1, i + 1);
                        i = 0;
                    }
                }
            }
            if (input.Length == 0)
                return "Empty String";
            else
                return input.ToString();

        }
        static int migratoryBirds(int n, int[] ar)
        {
            List<int> birds = ar.ToList();

            var groups = birds.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).FirstOrDefault();
            return largest.Key;
            
        }
        static string hackerrankInString(string s)
        {
            string parent = "hackerrank";
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == parent[j])
                      j++;
                if (j == parent.Length)
                    return "YES";
            }
            return "NO";
        }
        static int introTutorial(int V, int[] arr)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == V)
                    return i;

            }
            return -1;

        }
        static BigInteger fibonacciModified(double t1, double t2, int n)
        {
            BigInteger a1 = new BigInteger(t1);
            BigInteger a2 = new BigInteger(t2);
            List<BigInteger> fibnocci = new List<BigInteger>();
            
            for (int i = 0; i < n-2; i++)
            {
               var a3 = a1 + (a2*a2);
                fibnocci.Add(a3);
                a1 = a2;
                a2 = a3;
            }
            return fibnocci.Last();

        }
         static string[] bigSorting(BigInteger[] unsorted)
        {
          //  var temp = Array.ConvertAll(unsorted, s => BigInteger.Parse(s));
            List<BigInteger> big = new List<BigInteger>();
            foreach (var item in unsorted)
                big.Add(item);
            big.Sort();
           
            return big.Select(x => x.ToString()).ToArray();

        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int max = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b && keyboards[i] + drives[j] > max)
                        max = keyboards[i] + drives[j];
                }
            }
            if (max ==0)
                return -1;
            else
                return max;

        }
        static int viralAdvertising(int n)
        {
            int people = 5;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                people = people / 2;
                sum += people;
                people *= 3;
            }
            return sum;

        }
        static int beautifulDays(int i, int j, int k)
        {
            int rev = 0;
            int count = 0;int rem = 0;
            for (int index = i; index <= j; index++)
            {
                int number = index; rem = 0; rev = 0;
                while (number > 0)
                {
                    rem = number % 10;
                    rev = (rev * 10) + rem;
                    number = number / 10;
                }
                if ((Math.Abs(index - rev) % k==0))
                    count++;
                
            }
            return count;
            

        }
        static int[] countingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            //min and max
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }
            // counting array
            int[] counts = new int[maxVal - minVal + 1];

            //frequency of elements
            for (int i = 0; i < array.Length; i++)
                counts[array[i] - minVal]++;
           
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
                counts[i] = counts[i] + counts[i - 1];

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
                sortedArray[counts[array[i] - minVal]--] = array[i];

            return sortedArray;

        }
        static int findDigits(int n)
        {
            int res = n;int count = 0;
            List<int> div = new List<int>();
            while (res != 0)  
            {
                int digit = res % 10;
                div.Add(digit);
                res = res / 10; 
            }
            foreach (var no in div)
            {
                if (no!=0 && n % no == 0)
                    count++;
            }
            return count;

        }
        static int squares(int a, int b)
        {
            int count = (int)Math.Floor(Math.Sqrt(b)) - (int)Math.Ceiling(Math.Sqrt(a)) + 1; ;
            return count;

        }
        static int jumpingOnClouds(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; )
            {
                if (i + 2 < arr.Length)
                {
                    if (arr[i + 1] == 0 && arr[i + 2] == 0)
                    {
                        count++;
                        i += 2;
                    }
                    else if (arr[i + 1] == 0 && arr[i + 2] == 1)
                    {
                        count++;
                        i += 1;
                    }
                    else if (arr[i + 1] == 1 && arr[i + 2] == 0)
                    {
                        count++;
                        i += 2;
                    }
                }
                else
                {
                    if (i < arr.Length - 1)
                        count++;
                    i++;
                }

            }
            return count;

        }
        static string angryProfessor(int k, int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                    count++;
            }
            if (count >= k)
                return "NO";
            else
                return "YES";

        }
        static int formingMagicSquare(int[][] s)
        {
            int magic_constant = 15;

            List<int> row_result = new List<int>();
            List<int> column_result = new List<int>();
            int row_sum=0;int column_sum = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {

                }
            }
           

            return sum;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            #region Staircase
            //List<int> arr = new List<int>();

            //arr.Add(1);
            //arr.Add(3);
            //arr.Add(2);
            //arr.Add(6);
            //arr.Add(1);
            //arr.Add(2);
            //p.DivisibleSum(6, 3, arr);
            #endregion

            #region ForeCastChallenge
            //int[] a = { 14, 13, 12, 13, 16, 18, 21 };
            //int[] b = { 15, 11, 12, 11, 16, 19, 24 };
            //int sum = totalForecastInaccuracy(a, b);
            //Console.WriteLine(sum);
            #endregion

            #region IntersectionOfArrays
            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //int[] result = p.Intersect(nums1, nums2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region DayOfProgrammer
            //string date = solveYear(1800);
            //Console.WriteLine(date); 
            #endregion

            #region BonApetite
            //string[] st = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(st[0]);
            //int k = Convert.ToInt32(st[1]);
            //int[] bill = Array.ConvertAll(Console.ReadLine().Split(' '), billtemp => Convert.ToInt32(billtemp));
            //int bill_charged = Convert.ToInt32(Console.ReadLine());
            //string output = BonAppetite(bill_charged, k, bill);
            //Console.WriteLine(output); 
            #endregion

            #region String
            //int q = Convert.ToInt32(Console.ReadLine());
            //string s;
            //for (int qItr = 0; qItr <= q; qItr++)
            //{
            //     s = Console.ReadLine();
            //    separateNumbers(s);
            //} 
            #endregion

            #region CeaserCipher
            //int n = Convert.ToInt32(Console.ReadLine());
            //string si = Console.ReadLine();
            //int k = Convert.ToInt32(Console.ReadLine());
            //string result = caesarCipher("middle - Outz", 2);
            //Console.WriteLine(result); 
            #endregion

            #region pangrams
            //string s = Console.ReadLine();
            //string result = pangrams(s);
            #endregion

            #region SuperReducedString
            //string s = Console.ReadLine();
            //string result = super_reduced_string("baab");
            //Console.WriteLine(result); 
            #endregion

            #region MigratoryBirds
            //int[] a = { 1, 4, 4, 4, 5, 3 };
            //int count = migratoryBirds(6, a);
            //Console.WriteLine(count); 
            #endregion

            #region Hackerrank
            //string result = hackerrankInString("hackerworld");
            //Console.WriteLine(result);
            #endregion

            #region ModifiedFibonacci
            //var fib = fibonacciModified(0, 1, 10);
            //Console.WriteLine(fib); 
            #endregion

            #region BigSorting
            //int n = Convert.ToInt32(Console.ReadLine());
            //BigInteger[] unsorted = new BigInteger[n];
            //for (int i = 0; i < n; i++)
            //{
            //    string unsortedItem = Console.ReadLine();
            //    unsorted[i] = BigInteger.Parse(unsortedItem);
            //}
            //string[] res = bigSorting(unsorted);
            //foreach (var item in res)
            //    Console.WriteLine(item); 
            #endregion

            #region E-shopping
            //int[] keyboards = { 4 };
            //int[] drives = { 5 };
            //int b = 5;
            //int max = getMoneySpent(keyboards, drives, b);
            //Console.WriteLine(max); 
            #endregion

            #region ViralAdvertising
            //int result = viralAdvertising(3);
            //Console.WriteLine(result); 
            #endregion

            #region CountingSort
            //int bno = beautifulDays(20, 23, 6);
            // Console.WriteLine(bno); 
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //int[] sortedarray = countingSort(arr);
            //foreach (var item in sortedarray)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Squares
            // int count=findDigits(1012);
            // Console.WriteLine(count);
            //int sq = squares(3,9);
            //Console.WriteLine(sq); 
            #endregion
            //int[] jumparr = { 0, 0, 1, 0, 0, 1, 0 };
            //int jump = jumpingOnClouds(jumparr);
            //Console.WriteLine(jump);
            // int t = Convert.ToInt32(Console.ReadLine());

            // for (int tItr = 0; tItr < t; tItr++)
            //{
            //    string[] nk = Console.ReadLine().Split(' ');

            //    int n = Convert.ToInt32(nk[0]);

            //    int k = Convert.ToInt32(nk[1]);

            //    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            //    ;
            //    string result = angryProfessor(k, a);
            //}
            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }
            int result = formingMagicSquare(s);


            Console.ReadKey(true);
            
        }
    }
}
