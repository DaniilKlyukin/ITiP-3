namespace WideSearch
{
    public class Cell
    {
        public int X, Y;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            var cell = obj as Cell;

            if (cell == null)
            {
                return false;
            }

            return cell.X == X && cell.Y == Y;
        }
    }
}
