using NodaTime;
using System;

namespace TripDatesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //User wants to have a flexible trip in some specific period of dates.
            //She wants to visit several destination (up to 5 places) during this period 
            //and return to the first place before or at the end date of the period.
            //Amount of days to stay in each of the destinations is also flexible and is set
            //by the range of days 'to stay' in this destination.

            //There is a need in generating all the possible valid routes for the User.
            //Output should be a Json in form:
            //{
            //    "Routes": [
            //        {
            //            "Departures": [
            //                "2019-01-02",
            //                "2019-01-05"
            //            ]
            //        },
            //        {
            //            "Departures": [
            //                "2019-01-03",
            //                "2019-01-06"
            //            ]
            //        }
            //    ]
            //}

            //For example:
            //Trip start date: "2019-06-01"
            //Trip end date: "2019-06-11"
            //3 Places to visit:
            //  In 1st stay from 1 to 4 days (any of this days)
            //  In 2nd stay for 5 days
            //  In 3rd stay for 3-5 days
            //Possible routes to generate are:
            //2019-06-01 -(1 day)- 2019-06-02 -(5 days)- 2019-06-07 -(3 days)- 2019-06-10
            //2019-06-02 -(1 day)- 2019-06-03 -(5 days)- 2019-06-08 -(3 days)- 2019-06-11
            //2019-06-01 -(1 day)- 2019-06-02 -(5 days)- 2019-06-07 -(4 days)- 2019-06-11
            //2019-06-01 -(2 days)- 2019-06-03 -(5 days)- 2019-06-08 -(3 days)- 2019-06-11

            Console.WriteLine("Hello world!");
        }
    }
}
