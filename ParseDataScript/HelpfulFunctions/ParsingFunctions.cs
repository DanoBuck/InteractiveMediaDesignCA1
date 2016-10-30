using System;
using System.IO;

namespace ParseData.HelpfulFunctions
{
    public class ParsingFunctions
    {
        public static string getMonth(string month)
        {
            string result = "";
            if (month == "01")
            {
                result = "January";
            }
            else if (month == "02")
            {
                result = "February";
            }
            else if (month == "03")
            {
                result = "March";
            }
            else if (month == "04")
            {
                result = "April";
            }
            else if (month == "05")
            {
                result = "May";
            }
            else if (month == "06")
            {
                result = "June";
            }
            else if (month == "07")
            {
                result = "July";
            }
            else if (month == "08")
            {
                result = "August";
            }
            else if (month == "09")
            {
                result = "September";
            }
            else if (month == "10")
            {
                result = "October";
            }
            else if (month == "11")
            {
                result = "November";
            }
            else if (month == "12")
            {
                result = "December";
            }
            return result;
        }

        public static string ParseThisDataByMonth(String dataToParse)
        {
            char[] month;
            string months = "";
            string resultToSplitAgain = "";
            string[] dataParsing = dataToParse.Split('M');
            foreach (string str in dataParsing)
            {
                month = str.ToCharArray();
                months = month[0].ToString() + month[1].ToString();
                resultToSplitAgain += getMonth(months) + "\n";
            }

            return resultToSplitAgain;
        }

        public static string ParseThisDataByYear(String dataToParse)
        {
            string result = "";
            char[] yearArray;
            string[] dataParsing = dataToParse.Split('M');
            foreach (string str in dataParsing)
            {
                yearArray = str.ToCharArray();
                if (yearArray.Length > 6)
                {
                    result += yearArray[3].ToString() + yearArray[4].ToString() + yearArray[5].ToString() + yearArray[6].ToString() + "\n";
                }
                else if (yearArray.Length == 4)
                {
                    result += str + "\n";
                }
            }
            return result;
        }

        public static void PrintOutMonths29Times()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            StreamWriter sw = new StreamWriter("C:\\Users\\Daniel\\Desktop\\College Work\\InteractiveMediaDesign\\InteractiveMediaDesignCA1\\DataSets\\PenaltyPointsData\\Months.txt");


            for (int i = 0; i < months.Length; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    sw.WriteLine(months[i]);
                }
            }
            sw.Close();
        }

        public static void PrintOutMonthYearAndTime(string year)
        {
            for(int i = 1; i < 13; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    if (i < 10)
                    {
                        Console.WriteLine("01/0" + i + "/" + year + " 00:00:00");
                    }
                    else
                    {
                        Console.WriteLine("01/" + i + "/" + year + " 00:00:00");
                    }
                }
            }
        }
    }

}
