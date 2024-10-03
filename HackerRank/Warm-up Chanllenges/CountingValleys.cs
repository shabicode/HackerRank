using System;
namespace HackerRank.WarmupChanllenges
{
	public class CountingValleys
	{
        public static int countingValleys(int steps, string path)
        {
            // UUUDDD  UDDDUDUU     DDUU
            int valley = 0;
            int belowSea = 0;
            int seaLevel = 1;

            for (int i = 0; i < steps; i++)
            {
                processStepSeal(path[i], ref seaLevel);

                if (seaLevel < 1)
                {
                    belowSea++;
                }

                if (seaLevel == 1 && belowSea > 0)
                {
                    valley++;
                    belowSea = 0;
                }
            }
            return valley;

        }

        public static void processStepSeal(char step, ref int seaLevel)
        {
            if (step == 'U')
            {
                seaLevel++;
                return;
            }
            seaLevel--;
        }
    }
}
