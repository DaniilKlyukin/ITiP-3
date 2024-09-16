using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    public enum ObjectType
    {
        None, Player, Enemy, Wall
    }

    public class Map
    {
        private ObjectType[,] gameField;

        public Map(int w, int h)
        {
            gameField = new ObjectType[h, w];
            W = w;
            H = h;
        }

        public ObjectType this[int i, int j]
        {
            get
            { return gameField[i, j]; }
            set { gameField[i, j] = value; }
        }

        public int W { get; }
        public int H { get; }
    }
}
