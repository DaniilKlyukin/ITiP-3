namespace WinFormsApp2.ColorPatterns
{
    public class ReverseHeatMapPattern : HeatMapPattern
    {
        public override Color GetColor(double val, double minVal, double maxVal)
        {
            if (minVal == maxVal)
                return Color.Black;

            var heatMapColor =  base.GetColor(val, minVal, maxVal);

            return Color.FromArgb(255-heatMapColor.R, 255-heatMapColor.G, 255-heatMapColor.B);
        }
    }
}
