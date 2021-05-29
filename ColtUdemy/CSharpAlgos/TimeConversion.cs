using System;

namespace CSharpAlgos
{
    public class TimeConversion
    {
        public string ToMilitaryTime(string time)
        {
            var hrsMinsSecs = time.Substring(0, 8);
            var minutesAndSeconds = time.Substring(2, 6);

            Int32.TryParse($"{time[0]}{time[1]}", out int hour);
            if (IsPM(time))
            {
                if (hour == 12)
                    return $"{hrsMinsSecs}";

                hour += 12;

                return $"{hour}{minutesAndSeconds}";
            }

            if (hour == 12) return $"00{minutesAndSeconds}";

            return hrsMinsSecs;
        }

        private bool IsPM(string time) => time.IndexOf("P") != -1;
    }
}