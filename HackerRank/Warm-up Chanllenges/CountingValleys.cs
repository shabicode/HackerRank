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

            foreach(char step in path)
            {
                seaLevel = processStepSeal(step, ref seaLevel);
                if (seaLevel < 1) {
                    belowSea++;
                }

                if (seaLevel == 1 && belowSea > 0) {
                    valley++;
                    belowSea = 0;
                }
            }
            return valley;
        }

        public static int processStepSeal(char step, ref int seaLevel)
        {
            return (step == 'U') ? ++seaLevel : --seaLevel;
        }
    }
}
