namespace AirplaneGame
{
    public abstract class GameObject
    {

        public GameObject()
        {

        }

        public abstract Direction Move(GameController controller);
    }
}
