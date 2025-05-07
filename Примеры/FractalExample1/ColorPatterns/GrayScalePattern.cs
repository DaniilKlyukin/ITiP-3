namespace WinFormsApp2.ColorPatterns
{
    public class GrayScalePattern : ColorPattern
    {
        public override Color GetColor(double val, double minVal, double maxVal)
        {
            if (minVal == maxVal)
                return Color.Black;

            var valuePcnt = 1 - (val - minVal) / (maxVal - minVal);

            var colorValue = (int)Math.Round(255.0 * valuePcnt);

            return Color.FromArgb(colorValue, colorValue, colorValue);
        }
    }
}
