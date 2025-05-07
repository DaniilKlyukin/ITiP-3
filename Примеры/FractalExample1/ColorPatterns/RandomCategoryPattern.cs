namespace WinFormsApp2.ColorPatterns
{
    public class RandomCategoryPattern : ColorPattern
    {
        private readonly Dictionary<double, Color> categoriesValues= new Dictionary<double, Color>();
        private static Random rnd = new Random();

        public override Color GetColor(double val, double minVal, double maxVal)
        {
            if (minVal == maxVal)
                return Color.Black;

            //var intValue = (int)Math.Round(val);

            if (!categoriesValues.ContainsKey(val))
                categoriesValues.Add(
                    val,
                    Color.FromArgb(
                        rnd.Next(256),
                        rnd.Next(256),
                        rnd.Next(256)));

            return categoriesValues[val];
        }
    }
}
