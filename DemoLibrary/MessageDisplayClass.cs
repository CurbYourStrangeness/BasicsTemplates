using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class MessageDisplayClass
    {
        public string Greet(string fName, int DayHour)
        {
            string outp = "";
            if(DayHour < 12)
            {
                outp = $"Greetings {fName}, it is now {DayHour} in the morning.";
            }
            else if (DayHour >= 12 && DayHour < 17)
            {
                outp = $"Greetings {fName}, it is now {DayHour - 12} in the afternoon.";
            }
            else
            {
                outp = $"Greetings {fName}, it is now {DayHour} in the evening.";
            }

            return outp;
        }
    }
}
