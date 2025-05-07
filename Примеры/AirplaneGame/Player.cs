namespace AirplaneGame
{
    public class Player : GameObject
    {
        protected static Random rnd = new();

        public string Name { get; set; } = "unknown";

        public Player() : base()
        {

        }

        public override Direction Move(GameController controller)
        {
            var act = new Direction[] { Direction.U, Direction.D };

            return act[rnd.Next(0, 2)];
        }
    }
}
