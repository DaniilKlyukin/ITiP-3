namespace WinFormsApp2.ColorPatterns
{
    public abstract class ColorPattern
    {
        public abstract Color GetColor(double val, double minVal, double maxVal);
    }
}
