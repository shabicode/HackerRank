using System;
using System.Linq;

namespace HackerRank.RepeatedString
{
	public class RepeatedString
	{
        public static long repeatedString(string s, long n)
        {
            //    abcac 10
            long countChar = 0;
            countChar = s.Count(c => c == 'a') * (n / s.Length);
            long missedChar = (n % s.Length);
            for ( long m = 0; m < missedChar; m++)
            {
                if (s[(int)m] == 'a')
                {
                    countChar += 1;
                }
            }
            return countChar;
        }
    }
}

