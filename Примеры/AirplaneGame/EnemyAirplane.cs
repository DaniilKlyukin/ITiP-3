namespace AirplaneGame
{
    public class EnemyAirplane : GameObject
    {
        protected static Random rnd = new();

        public EnemyAirplane() : base()
        {

        }


        public override Direction Move(GameController controller)
        {
            return Direction.L;
        }
    }
}
