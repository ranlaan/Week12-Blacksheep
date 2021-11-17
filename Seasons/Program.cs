using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string Winterfile = @"C:\Users\opilane\Samples\winter.txt";
            string Autumnfile = @"C:\Users\opilane\Samples\autumn.txt";

            string[] winterData = File.ReadAllLines(Autumnfile);
            string[] autumnData = File.ReadAllLines(Winterfile);

            File.WriteAllLines(Autumnfile, autumnData);
            File.WriteAllLines(Winterfile, winterData);
        }
    }
}
