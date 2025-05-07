namespace WinFormsApp2.ColorPatterns
{

    public class ColorListPattern : ColorPattern
    {
        private readonly IList<Color> colors;

        public ColorListPattern(IList<Color> colors)
        {
            this.colors = colors;
        }

        public override Color GetColor(double val, double minVal, double maxVal)
        {
            if (minVal == maxVal)
                return Color.Black;

            var valuePcnt = (val - minVal) / (maxVal - minVal);

            double colorPerc = 1d / (colors.Count - 1);// % of each block of color. the last is the "100% Color"
            double blockOfColor = valuePcnt / colorPerc;// the integer part repersents how many block to skip
            int blockIdx = (int)Math.Truncate(blockOfColor);// Idx of 
            double valPercResidual = valuePcnt - blockIdx * colorPerc;//remove the part represented of block 
            double percOfColor = valPercResidual / colorPerc;// % of color of this block that will be filled

            Color cTarget = colors[blockIdx];
            Color cNext = colors[Math.Min(blockIdx + 1, colors.Count - 1)];

            var deltaR = cNext.R - cTarget.R;
            var deltaG = cNext.G - cTarget.G;
            var deltaB = cNext.B - cTarget.B;

            var R = cTarget.R + deltaR * percOfColor;
            var G = cTarget.G + deltaG * percOfColor;
            var B = cTarget.B + deltaB * percOfColor;

            return Color.FromArgb((byte)R, (byte)G, (byte)B);
        }
    }
}
