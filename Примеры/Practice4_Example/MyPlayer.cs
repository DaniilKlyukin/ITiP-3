using AirplaneGame;

namespace WinFormsApp1
{
    internal class MyPlayer : Player
    {
        public MyPlayer()
        {
            Name = "Игрок 1";
        }

        public override Direction Move(GameController controller)
        {
            var dict = controller.GetGameData().ToDictionary(v => v.Item1, v => v.Item2);

            var playerPoint = controller.GetPlayerLocationByName(Name);


            var path = controller.GetShortestPath(
                playerPoint,
                new AirplaneGame.Point(3, 3));

            if (path.Count < 2)
                return Direction.None;

            var next = path[1];

            var choise = rnd.Next(0, 2);

            if (choise == 0)
                return Direction.R;
            else
                return Direction.R;

            /*
            return controller.ConvertStepToDirection(
               new AirplaneGame.Point(next.X - playerPoint.X, next.Y - playerPoint.Y));
            
            if (dict.ContainsKey((playerX + 1, playerY)))
            {
                var choise = rnd.Next(0, 2);

                if (choise == 0)
                    return Direction.U;
                else
                    return Direction.D;
            }

            return Direction.None;*/
        }
    }
}
