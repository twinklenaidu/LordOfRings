using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProb_01
{
    class Parent
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\TestFolder\input.txt");
            foreach (var item in lines)
            {
                string[] passphrase = item.Split(' ');
                if (passphrase.Distinct().Count() == passphrase.Count())
                    count++;
            }
           
            Console.WriteLine("Total count of passphrases:" + lines.Count());
            Console.WriteLine("Total valid passphrases:"+count);
            Console.WriteLine("Total invalid passphrases:" + (lines.Count() - count));
            Console.ReadLine();
        }
    }
}
