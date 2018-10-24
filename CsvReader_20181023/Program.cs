using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsvReader_20181023
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"c:\1.csv";
            var square = ReadCsv(csvPath);
        }

        static string[][] ReadCsv(string csvPath)
        {
            return File.ReadLines(csvPath).Select(x => x.Split(',')).ToArray();
        }
    }
}
