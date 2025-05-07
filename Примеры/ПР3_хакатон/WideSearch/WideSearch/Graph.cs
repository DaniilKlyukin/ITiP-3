namespace WideSearch
{
    public class Graph
    {
        public List<Vertex> Vertices { get; } = [];

        public Dictionary<Vertex, int> DijkstraAlgorithm(Vertex source, out Dictionary<Vertex, Vertex> path)
        {
            var distances = Vertices.ToDictionary(v => v, v => int.MaxValue);
            path = new Dictionary<Vertex, Vertex>();
            var notVisited = new HashSet<Vertex>(Vertices);

            distances[source] = 0;

            while (notVisited.Any())
            {
                var nearestVertex = notVisited.OrderBy(v => distances[v]).FirstOrDefault();
                notVisited.Remove(nearestVertex);

                foreach (var edge in nearestVertex.Edges)
                {
                    var neighbor = edge.To;
                    if (notVisited.Contains(neighbor))
                    {
                        var currentDistance = distances[nearestVertex] + edge.Weight;
                        if (currentDistance < distances[neighbor])
                        {
                            distances[neighbor] = currentDistance;
                            path[neighbor] = nearestVertex;
                        }
                    }
                }
            }

            return distances;
        }
    }

    public class Vertex
    {
        public string Name { get; }

        public IEnumerable<Edge> Edges => edges;
        private List<Edge> edges { get; }

        public Vertex(string name)
        {
            Name = name;
            edges = new List<Edge>();
        }

        public void AddEdgeTo(Vertex to, int weight)
        {
            edges.Add(new Edge(this, to, weight));
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    public class Edge
    {
        public Vertex From { get; }
        public Vertex To { get; }
        public int Weight { get; }

        public Edge(Vertex from, Vertex to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{From} {To}";
        }
    }
}
