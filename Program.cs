using IndianCensusAnalyzer;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace IndianStateCensusAnalyzer
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ImportCSVData obj = new ImportCSVData(C: /Users/Shivam Shekhar/source/DAY 29 / IndianStateCensusData.csv");
            obj.ImportData();
        }
    }
}