﻿using System;

namespace Stump.Core.Extensions
{
    public static class TimeExtensions
    {
        public static long GetUnixTimeStampLong(this DateTime date)
        {
            return (long)( date - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime() ).TotalMilliseconds;
        }

        public static int GetUnixTimeStamp(this DateTime date)
        {
            return (int)( date - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime() ).TotalSeconds;
        }
    }
}