using System.Collections.Generic;
using System.IO;

namespace ParseData.PenaltyPoints
{
    public class PenaltyPointParsing
    {
        // There has to be a better way of doing this but it is working now
        public static void ParseAllDataIntoDifferentFormatsForPenaltyPointDataForFirstStage()
        {
            List<string> listOfSections = new List<string>();
            var values = File.ReadAllLines("C:\\Users\\Daniel\\Desktop\\College Work\\InteractiveMediaDesign\\InteractiveMediaDesignCA1\\PenaltyPointsData\\PenaltyPointsParsingCSV.csv");
            StreamWriter sw = new StreamWriter("C:\\Users\\Daniel\\Desktop\\College Work\\InteractiveMediaDesign\\InteractiveMediaDesignCA1\\PenaltyPointsData\\MonthByMonthPenaltyPointParsing.txt");
            string holdThisHere = "";

            int counter = 0;
            // make into char array
            char[] charArray;

            int cycles = 29;

            for (int i = 0; i < values.Length; i++)
            {
                charArray = values[i].ToCharArray();
                holdThisHere = "";
                for (int j = 0; j < 1; j++)
                {
                    holdThisHere += values[i];
                    listOfSections.Add(holdThisHere);
                    counter++;
                }
                if (counter == cycles)
                {
                    counter = 0;
                }
            }
            int lineBreaks = 67;
            for (int i = 0; i < listOfSections.Count; i++)
            {
                if (i % lineBreaks == 0)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        sw.WriteLine();
                    }
                    sw.Write(listOfSections[i] + "\t");
                }
                else if (i % lineBreaks != 0)
                {
                    sw.Write(listOfSections[i] + "\t");
                }
            }
            sw.Close();
        }

        public static void ParseBlanksAndDashesForPenaltyPointDataForSecondStage()
        {
            List<string> listOfSections = new List<string>();
            var values = File.ReadAllLines("C:\\Users\\Daniel\\Desktop\\College Work\\InteractiveMediaDesign\\InteractiveMediaDesignCA1\\DataSets\\PenaltyPointsData\\PenaltyPointsParsingCSV.csv");
            StreamWriter sw = new StreamWriter("C:\\Users\\Daniel\\Desktop\\College Work\\InteractiveMediaDesign\\InteractiveMediaDesignCA1\\DataSets\\PenaltyPointsData\\MonthByMonthPenaltyPointParsingBlanksAndDashes.csv");

            char[] charArray;
            string holdThisHere = "";
            int counter = 0;
            int cycles = 29;
            for (int i = 0; i < values.Length; i++)
            {
                charArray = values[i].ToCharArray();
                holdThisHere = "";
                for (int j = 0; j < 1; j++)
                {
                    holdThisHere += values[i];
                    listOfSections.Add(holdThisHere);
                    counter++;
                }
                if (counter == cycles)
                {
                    counter = 0;
                }
            }
            int lineBreaks = 67;

            for (int i = 0; i < listOfSections.Count; i++)
            {
                listOfSections[i] = listOfSections[i].Replace('-', '0');
                listOfSections[i] = listOfSections[i].Replace(' ', '0');
                if (listOfSections[i].Contains("#")) {
                        listOfSections[i] = "0";
                }
                if (i % lineBreaks == 0)
                {
                    
                    for (int j = 0; j < 1; j++)
                    {
                        sw.WriteLine();
                    }
                    sw.Write(listOfSections[i] + "\t");
                }
                else if (i % lineBreaks != 0)
                {
                    sw.Write(listOfSections[i] + "\t");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
