﻿using ParseData.HelpfulFunctions;
using ParseData.PenaltyPoints;
using System;

namespace ParseData
{
    class Program
    {
        static void Main()
        {
            //string data = "1998M01 1998M02 1998M03 1998M04 1998M05 1998M06 1998M07 1998M08	1998M09	1998M10	1998M11	1998M12	1999M01	1999M02	1999M03	1999M04	1999M05	1999M06	1999M07	1999M08	1999M09	1999M10	1999M11	1999M12	2000M01	2000M02	2000M03	2000M04	2000M05	2000M06	2000M07	2000M08	2000M09	2000M10	2000M11	2000M12	2001M01	2001M02	2001M03	2001M04	2001M05	2001M06	2001M07	2001M08	2001M09	2001M10	2001M11	2001M12	2002M01	2002M02	2002M03	2002M04	2002M05	2002M06	2002M07	2002M08	2002M09	2002M10	2002M11	2002M12	2003M01	2003M02	2003M03	2003M04	2003M05	2003M06	2003M07	2003M08	2003M09	2003M10	2003M11	2003M12	2004M01	2004M02	2004M03	2004M04	2004M05	2004M06	2004M07	2004M08	2004M09	2004M10	2004M11	2004M12	2005M01	2005M02	2005M03	2005M04	2005M05	2005M06	2005M07	2005M08	2005M09	2005M10	2005M11	2005M12	2006M01	2006M02	2006M03	2006M04	2006M05	2006M06	2006M07	2006M08	2006M09	2006M10	2006M11	2006M12	2007M01	2007M02	2007M03	2007M04	2007M05	2007M06	2007M07	2007M08	2007M09	2007M10	2007M11	2007M12	2008M01	2008M02	2008M03	2008M04	2008M05	2008M06	2008M07	2008M08	2008M09	2008M10	2008M11	2008M12	2009M01	2009M02	2009M03	2009M04	2009M05	2009M06	2009M07	2009M08	2009M09	2009M10	2009M11	2009M12	2010M01	2010M02	2010M03	2010M04	2010M05	2010M06	2010M07	2010M08	2010M09	2010M10	2010M11	2010M12	2011M01	2011M02	2011M03	2011M04	2011M05	2011M06	2011M07	2011M08	2011M09	2011M10	2011M11	2011M12	2012M01	2012M02	2012M03	2012M04	2012M05	2012M06	2012M07	2012M08	2012M09	2012M10	2012M11	2012M12	2013M01	2013M02	2013M03	2013M04	2013M05	2013M06	2013M07	2013M08	2013M09	2013M10	2013M11	2013M12	2014M01	2014M02	2014M03	2014M04	2014M05	2014M06	2014M07	2014M08	2014M09	2014M10	2014M11	2014M12	2015M01	2015M02	2015M03	2015M04	2015M05	2015M06	2015M07	2015M08	2015M09	2015M10	2015M11	2015M12	2016M01	2016M02	2016M03	2016M04	2016M05	2016M06	2016M07	2016M08	2016M09";
            //Console.WriteLine(ParsingFunctions.ParseThisDataByMonth(data));
            //Console.WriteLine(ParsingFunctions.ParseThisDataByYear(data));

            //for (int i = 0; i < 226; i++)
            //{
            //    Console.WriteLine("25 - 74 years");
            //}
            //ParsingFunctions.PrintOutMonths29Times();
            //PenaltyPointParsing.ParseBlanksAndDashesForPenaltyPointData();
            //PenaltyPointParsing.ParseBlanksAndDashesForPenaltyPointDataForSecondStage();
            ParsingFunctions.PrintOutMonthYearAndTime("2014");
            ParsingFunctions.PrintOutMonthYearAndTime("2015");
            ParsingFunctions.PrintOutMonthYearAndTime("2016");
            for (int i = 1998; i <= 2016; i++)
            {
                ParsingFunctions.PrintOutMonthYearAndTime(i.ToString());
            }
        }
    }
}
