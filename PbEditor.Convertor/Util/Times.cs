using System;

namespace PbEditor.Convertor.Util
{
    class Times
    {
        public static ulong GetCurrentTimeStamp()
        {
            ulong unixTimestamp = (ulong)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            return unixTimestamp;
        }

        public static ulong GetCurrentMinutes()
        {
            ulong currentMinutes = (ulong)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMinutes);
            return currentMinutes;
        }
        public static ulong GetTimeStamp(DateTime dt)
        {
            ulong unixTimestamp = (ulong)(dt.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            return unixTimestamp;
        }

        public static ulong GetUnixTimeMilionSecs()
        {
            ulong unixTimestamp = (ulong)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            return unixTimestamp;
        }
    }
}
