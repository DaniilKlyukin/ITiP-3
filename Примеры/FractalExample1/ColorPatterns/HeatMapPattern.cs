namespace WinFormsApp2.ColorPatterns
{
    public class HeatMapPattern : ColorPattern
    {
        public HeatMapPattern()
        {
            initColorsBlocks();
        }

        public HeatMapPattern(byte alpha)
        {
            Alpha = alpha;
            initColorsBlocks();
        }

        private void initColorsBlocks()
        {
            ColorsOfMap.AddRange(new Color[]{
            Color.FromArgb(Alpha, 0, 0, 0) ,//Black
            Color.FromArgb(Alpha, 0, 0, 0xFF) ,//Blue
            Color.FromArgb(Alpha, 0, 0xFF, 0xFF) ,//Cyan
            Color.FromArgb(Alpha, 0, 0xFF, 0) ,//Green
            Color.FromArgb(Alpha, 0xFF, 0xFF, 0) ,//Yellow
            Color.FromArgb(Alpha, 0xFF, 0, 0) ,//Red
            Color.FromArgb(Alpha, 0xFF, 0xFF, 0xFF) // White
        });
        }

        public override Color GetColor(double val, double minVal, double maxVal)
        {
            if (minVal == maxVal)
                return Color.Black;

            double valPerc = (val - minVal) / (maxVal - minVal);// value%
            double colorPerc = 1d / (ColorsOfMap.Count - 1);// % of each block of color. the last is the "100% Color"
            double blockOfColor = valPerc / colorPerc;// the integer part repersents how many block to skip
            int blockIdx = (int)Math.Truncate(blockOfColor);// Idx of 
            double valPercResidual = valPerc - blockIdx * colorPerc;//remove the part represented of block 
            double percOfColor = valPercResidual / colorPerc;// % of color of this block that will be filled

            Color cTarget = ColorsOfMap[blockIdx];
            Color cNext = ColorsOfMap[Math.Min(blockIdx + 1, ColorsOfMap.Count - 1)];

            var deltaR = cNext.R - cTarget.R;
            var deltaG = cNext.G - cTarget.G;
            var deltaB = cNext.B - cTarget.B;

            var R = cTarget.R + deltaR * percOfColor;
            var G = cTarget.G + deltaG * percOfColor;
            var B = cTarget.B + deltaB * percOfColor;

            return Color.FromArgb(Alpha, (byte)R, (byte)G, (byte)B);
        }
        public byte Alpha = 0xff;
        public List<Color> ColorsOfMap = new List<Color>();
    }
}