namespace basketball_app
{
    public class ScoreHandler
    {
        public int HomeTeamScore = 0;
        public int AwayTeamScore = 0;


        public string UpdateScore(bool isHome, int toAdd)
        {
            if (isHome)
                HomeTeamScore += toAdd;
            else
                AwayTeamScore += toAdd;

            return isHome ? HomeTeamScore.ToString() : AwayTeamScore.ToString();
        }

        public void ResetScore()
        {
            HomeTeamScore = 0;
            AwayTeamScore = 0;
        }
    }

    public class FoulHandler
    {
        public int HomeTeamFouls = 0;
        public int AwayTeamFouls = 0;


        public string AddFouls(bool isHome)
        {
            if (isHome)
                HomeTeamFouls += 1;
            else
                AwayTeamFouls += 1;

            return isHome ? HomeTeamFouls.ToString() : AwayTeamFouls.ToString();
        }

        public string RemoveFouls(bool isHome)
        {
            if (isHome)
                HomeTeamFouls = HomeTeamFouls == 0 ? 0 : HomeTeamFouls - 1;
            else
                AwayTeamFouls = AwayTeamFouls == 0 ? 0 : AwayTeamFouls - 1;

            return isHome ? HomeTeamFouls.ToString() : AwayTeamFouls.ToString();
        }

        public void ResetFouls()
        {
            HomeTeamFouls = 0;
            AwayTeamFouls = 0;
        }
    }

    public class TimeoutHandler
    {
        public int HomeTeamTimeouts = 5;
        public int AwayTeamTimeouts = 5;

        public string AddTimeout(bool isHome)
        {
            if (isHome)
                HomeTeamTimeouts += 1;
            else
                AwayTeamTimeouts += 1;

            return isHome ? HomeTeamTimeouts.ToString() : AwayTeamTimeouts.ToString();
        }

        public string RemoveTimeout(bool isHome)
        {
            if (isHome)
                HomeTeamTimeouts = HomeTeamTimeouts == 0 ? 0 : HomeTeamTimeouts - 1;
            else
                AwayTeamTimeouts = AwayTeamTimeouts == 0 ? 0 : AwayTeamTimeouts - 1;

            return isHome ? HomeTeamTimeouts.ToString() : AwayTeamTimeouts.ToString();
        }

        public void ResetTimeouts()
        {
            HomeTeamTimeouts = 5;
            AwayTeamTimeouts = 5;
        }
    }

    public class TimeHandler
    {
        public int quarterTime = 4800;
        public int halfTime = 6000;
        public int time = 4800;
        public int quarter = 1;

        public string SetHalftime()
        {
            time = halfTime;
            quarter += 1;
            return FindTime();
        }
        public string ResetClock()
        {
            quarter = 1;
            time = quarterTime;
            return FindTime();
        }

        public string ResetTime()
        {
            time = quarterTime;
            return FindTime();
        }
        public string AddOneSecond()
        {
            time += 10;
            return FindTime();
        }
        public string SubtractOneSecond()
        {
            time = time < 10 ? 0 : time - 10;
            return FindTime();
        }
        public string AddOneMinute()
        {
            time += 600;
            return FindTime();
        }

        public string SubtractOneMinute()
        {
            time = time < 600 ? 0 : time - 600;
            return FindTime();
        }

        public string FindTime()
        {
            int tempTime = time;
            int minutes = time / 600;

            tempTime -= minutes * 600;

            string seconds = (tempTime / 10).ToString("D2");

            if (time / 600 > 0)
                return $"{minutes}:{seconds}";
            else
                return $"{seconds}.{time % 10}";
        }
    }

}
