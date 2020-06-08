using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/angle-between-hands-of-a-clock/
    /*
    Given two numbers, hour and minutes. Return the smaller angle (in degrees) formed between the hour and the minute hand. 
    */
    //O()
    public class AngleClock
    {
        public double ClockAngle(int hour, int minutes)
        {

            if (hour > 12 || minutes > 59)
                return 0;

            if (hour == 12 && minutes == 0)
                return 0;

            decimal hourPos = 0;
            decimal minutePos = minutes;

            if (hour == 12)
                hourPos = 0;
            else
                hourPos = hour * 5;

            //determine extra position change w.r.t minutes.
            decimal extraPos = (((decimal)minutes / 60) * 5);

            hourPos = hourPos + extraPos;

            decimal diff = Math.Abs(minutePos - hourPos);

            //multiply diff by 6 degree angle for each minute.
            return ((double)Math.Min(diff * 6, 360 - (diff * 6)));


        }
    }
}
