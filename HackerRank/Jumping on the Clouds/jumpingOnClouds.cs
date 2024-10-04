using System.Runtime.InteropServices;

namespace HackerRank.JumpingontheClouds
{
	public class jumpingOnClouds
	{
        public static int jumpingOnTheClouds(List<int> c)
        {
            //0 0 0 0 1 0  0 0 0 1 0 0  0 0 1 0 0 1 0  0 0 0 1 0 0

            int jumps = 0;
            int currentIndex = 0;

            while (currentIndex < c.Count - 1)
            {
                currentIndex += (currentIndex + 2 < c.Count && c[currentIndex + 2] == 0) ?  2 :  1 ; 
                jumps++;
            }

            return jumps;
        }
    }
}

