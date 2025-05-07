using AirplaneGame.DijkstraAlg;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace AirplaneGame
{
    public class Point
    {
        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            var p = (Point)obj;

            return p.X == X && p.Y == Y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }

    public class GameController
    {
        /// <summary>
        /// Кол-во строк
        /// </summary>
        public int Rows { get; }

        /// <summary>
        /// Кол-во столбцов
        /// </summary>
        public int Columns { get; }

        internal delegate void GameObjectHandleer(Point p, GameObject go);
        internal delegate void UpdateHandleer();

        internal event GameObjectHandleer? GameObjectsAdd;
        internal event GameObjectHandleer? GameObjectsRemove;
        internal event UpdateHandleer? Updated;

        internal Dictionary<string, int> Scores = new();

        private Timer gameTimer = new() { Interval = 500 };

        private Dictionary<Point, GameObject> gameObjects = new();

        private static Random rnd = new();

        public int Iteration = 0;

        public GameController(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;

            gameTimer.Tick += (s, a) => Update();
        }

        private GameObject AddGameObject<T>(Point p) where T : GameObject, new()
        {
            if (gameObjects.ContainsKey(p))
            {
                RemoveGameObject(p);
            }

            var go = new T();

            gameObjects.Add(p, go);
            GameObjectsAdd?.Invoke(p, go);

            return go;
        }

        private void RemoveGameObject(Point p)
        {
            if (gameObjects.ContainsKey(p))
            {
                GameObjectsRemove?.Invoke(p, gameObjects[p]);
                gameObjects.Remove(p);
            }
        }

        private void RemoveGameObjects(List<Point> points)
        {
            foreach (var p in points)
            {
                RemoveGameObject(p);
            }
        }

        public void Start<T>() where T : Player, new()
        {
            foreach (var (p, go) in gameObjects)
            {
                GameObjectsRemove?.Invoke(p, go);
            }
            gameObjects.Clear();

            var player = (T)AddGameObject<T>(new Point(0, rnd.Next(0, Rows)));

            Scores.Add(player.Name, 0);

            gameTimer.Start();
        }

        private void Update()
        {
            var sw = new Stopwatch();
            sw.Start();

            var newLocationGameObjects = new Dictionary<Point, Dictionary<Point, GameObject>>();

            //Удаляем всех за игровым полем
            RemoveGameObjects(gameObjects
                .Where(g => !IsOnBoard(g.Key))
                .Select(g => g.Key)
                .ToList());

            var movesMap = new Dictionary<Point, Point>();

            foreach (var (p, go) in gameObjects)
            {
                var step = ConvertDirectionToStep(go.Move(this));

                var newP = GetMovedGameObjectPoint(go, p, step);

                movesMap.Add(p, newP);

                if (!newLocationGameObjects.ContainsKey(newP))
                    newLocationGameObjects.Add(newP, new Dictionary<Point, GameObject> { { p, go } });
                else
                    newLocationGameObjects[newP].Add(p, go);
            }

            var cyclicRemove = new List<Point>();

            foreach (var (newP, dict) in newLocationGameObjects)
            {
                if (gameObjects.Keys.Contains(newP)
                    && dict.ContainsKey(movesMap[newP])
                    && !newP.Equals(movesMap[newP]))
                {
                    cyclicRemove.Add(newP);
                    cyclicRemove.Add(movesMap[newP]);
                }
            }

            RemoveGameObjects(cyclicRemove);

            foreach (var (newP, objects) in newLocationGameObjects.Where(pair => pair.Value.Count > 1))
            {
                RemoveGameObjects(objects.Keys.ToList());
            }

            gameObjects = gameObjects.ToDictionary(v => movesMap[v.Key], v => v.Value);

            AddEnemy(Math.Min(1 + Iteration / 20, (int)(Rows * 0.5)));
            Iteration++;

            AddScores();

            Updated?.Invoke();

            sw.Stop();
        }

        private void AddScores()
        {
            foreach (var (_, go) in gameObjects)
            {
                if (go is Player player && Scores.ContainsKey(player.Name))
                {
                    Scores[player.Name]++;
                }
            }
        }

        private void AddEnemy(int count = 1)
        {
            var ys = Enumerable.Range(0, Rows).ToList();

            ys.Shuffle();

            foreach (var y in ys.Take(Math.Min(count, Rows)))
            {
                AddGameObject<EnemyAirplane>(new Point(Columns - 1, y));
            }
        }

        /// <summary>
        /// Лежит ли точка внутри игрового поля?
        /// </summary>
        /// <param name="x">X координата ячейки</param>
        /// <param name="y">Y координата ячейки</param>
        /// <returns></returns>
        public bool IsOnBoard(Point p)
        {
            return p.X < Columns && p.X >= 0 && p.Y < Rows && p.Y >= 0;
        }

        private Point GetMovedGameObjectPoint(GameObject go, Point p, Point step)
        {
            var newP = new Point(p.X + step.X, p.Y + step.Y);

            if (go is not Player)
            {
                return newP;
            }

            if (IsOnBoard(newP))
            {
                return newP;
            }

            return p;
        }

        /// <summary>
        /// Преобразовать направление в кортеж сдвига по X Y
        /// </summary>
        /// <param name="direction">Направление движения</param>
        /// <returns>кортеж сдвига по X Y</returns>
        public Point ConvertDirectionToStep(Direction direction)
        {
            return direction switch
            {
                Direction.None => new(0, 0),
                Direction.L => new(-1, 0),
                Direction.R => new(1, 0),
                Direction.U => new(0, -1),
                Direction.D => new(0, 1),
                Direction.LU => new(-1, -1),
                Direction.RU => new(1, -1),
                Direction.LD => new(-1, 1),
                Direction.RD => new(1, 1),
                _ => new(0, 0)
            };
        }

        /// <summary>
        /// Преобразовать кортеж сдвига по X Y в направление
        /// </summary>
        /// <param name="dx">Перемещение по X</param>
        /// <param name="dy">Перемещение по Y</param>
        /// <returns>Направление</returns>
        public Direction ConvertStepToDirection(Point step)
        {
            return (step.X, step.Y) switch
            {
                (0, 0) => Direction.None,
                (-1, 0) => Direction.L,
                (1, 0) => Direction.R,
                (0, -1) => Direction.U,
                (0, 1) => Direction.D,
                (-1, -1) => Direction.LU,
                (1, -1) => Direction.RU,
                (-1, 1) => Direction.LD,
                (1, 1) => Direction.RD,
                _ => Direction.None
            };
        }

        /// <summary>
        /// Запросить данные карты игры
        /// </summary>
        /// <returns>Коллекция вида: координата X, координата Y, тип объекта</returns>
        public IEnumerable<(Point, GameObjectType)> GetGameData()
        {
            foreach (var (p, go) in gameObjects)
            {
                var type = go switch
                {
                    Player => GameObjectType.Player,
                    EnemyAirplane => GameObjectType.Enemy
                };

                yield return (p, type);
            }
        }

        /// <summary>
        /// Получить координаты X Y игрока по его имени
        /// </summary>
        /// <param name="name">Имя игрока</param>
        /// <returns>координаты X Y</returns>
        public Point GetPlayerLocationByName(string name)
        {
            var players = gameObjects.Where(v => v.Value is Player player && player.Name == name);

            if (!players.Any())
                return new(-1, -1);

            return players.First().Key;
        }

        /// <summary>
        /// Получить кратчайший путь до точки, если пути нет, то будет возвращена конечная точка
        /// </summary>
        /// <param name="from">От какой точки</param>
        /// <param name="to">До какой точки</param>
        /// <returns>Путь в виде списка кортежей (x,y)</returns>
        public List<Point> GetShortestPath(Point from, Point to)
        {
            var graph = new Graph();

            for (var y = 0; y < Rows; y++)
            {
                for (var x = 0; x < Columns; x++)
                {
                    graph.AddVertex($"{x} {y}");
                }
            }

            foreach (var (fromV, toV, weight) in GetEdges())
                graph.AddOrientedEdge(fromV, toV, weight);

            var dijkstra = new Dijkstra(graph);

            var path = dijkstra.FindShortestPath($"{from.X} {from.Y}", $"{to.X} {to.Y}");

            return path.Select(v =>
            {
                var vertex = v.Split(" ");

                var x = int.Parse(vertex[0]);
                var y = int.Parse(vertex[1]);

                return new Point(x, y);
            }).ToList();
        }

        private List<(string, string, int)> GetEdges()
        {
            var badVertices = new HashSet<Point>();

            foreach (var (p, go) in gameObjects)
            {
                if (go is Player)
                    continue;

                var step = ConvertDirectionToStep(go.Move(this));

                badVertices.Add(new(p.X + step.X, p.Y + step.Y));
            }

            var edges = new List<(string, string, int)>();

            for (var y = 0; y < Rows; y++)
            {
                for (var x = 0; x < Columns; x++)
                {
                    if (x + 1 < Columns)
                        TryAddEdge(new(x, y), new(x + 1, y), badVertices, edges);

                    if (y + 1 < Rows)
                    {
                        TryAddEdge(new(x, y), new(x, y + 1), badVertices, edges);

                        if (x > 0)
                            TryAddEdge(new(x, y), new(x - 1, y + 1), badVertices, edges);
                    }

                    if (y + 1 < Rows && x + 1 < Columns)
                        TryAddEdge(new(x, y), new(x + 1, y + 1), badVertices, edges);
                }
            }

            return edges;
        }

        private void TryAddEdge(Point from, Point to, HashSet<Point> badVertices, List<(string, string, int)> edges)
        {
            if (badVertices.Contains(from) && badVertices.Contains(to))
                return;

            if (badVertices.Contains(from))
            {
                edges.Add(($"{from.X} {from.Y}", $"{to.X} {to.Y}", 1));
                return;
            }

            if (badVertices.Contains(to))
            {
                edges.Add(($"{to.X} {to.Y}", $"{from.X} {from.Y}", 1));
                return;
            }

            edges.Add(($"{from.X} {from.Y}", $"{to.X} {to.Y}", 1));
            edges.Add(($"{to.X} {to.Y}", $"{from.X} {from.Y}", 1));

        }
    }
}
