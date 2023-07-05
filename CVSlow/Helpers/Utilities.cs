namespace CVSlow.Helpers
{
    public static class Utilities
    {
        private static List<string> _cannedImages = new List<string> { "dotnet_bot.png", "enter.png", "expand_2x.png","lastquarter_2x.png","meeting75_1x.png","offline_grey.png","priority_h.png","priority_l_3x.png","priority_m.png","trash_2x.png","updateblue.png","view_icon_inactive.png" };
        public static string RandomWords()
        {
            var text = new RandomText();
            return text.RandomWords();
        }

        public static string RandomSentences()
        {
            var text = new RandomText();
            return text.RandomSentences();
        }

        public static string RandomImage()
        {
            return _cannedImages.ElementAtOrDefault(Constants.Random.Next(_cannedImages.Count));
        }

        public static DateTime RandomDateTime(DateTime? startDate = null, DateTime? endDate = null)
        {
            if (endDate == null)
            {
                endDate = DateTime.Now.AddYears(25);
            }
            if (startDate == null)
            {
                startDate = DateTime.Now.AddYears(-25);
            }
            var timeSpan = endDate.Value - startDate.Value;
            var newSpan = new TimeSpan(0, Constants.Random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate.Value + newSpan;
        }

        public static bool RandomBool()
        {
            return Constants.Random.NextDouble() > 0.5d;
        }
    }
}
