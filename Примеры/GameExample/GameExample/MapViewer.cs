namespace GameExample
{
    public class MapViewer
    {
        public MapViewer(int cellSize = 40)
        {
            CellSize = cellSize;
        }

        public int CellSize { get; }

        public Bitmap Visualize(Map map)
        {
            var bmp = new Bitmap(map.W * CellSize, map.H * CellSize);
            using Graphics g = Graphics.FromImage(bmp);

            for (int i = 0; i < map.H; i++)
            {
                for (int j = 0; j < map.W; j++)
                {
                    g.DrawImage(Resource.grass,
                        new Point(j * CellSize, i * CellSize));

                    if (map[i,j] is ObjectType.Player)
                    {
                        g.DrawImage(Resource.player,
                            new Point(j * CellSize, i * CellSize));
                    }
                    else if (map[i, j] is ObjectType.Enemy)
                    {
                        g.DrawImage(Resource.enemy,
                            new Point(j * CellSize, i * CellSize));
                    }
                }
            }

            return bmp;
        }
    }
}
