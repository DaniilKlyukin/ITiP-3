using WideSearch;


var vertexA = new Vertex("A");
var vertexB = new Vertex("B");
var vertexC = new Vertex("C");
var vertexD = new Vertex("D");
// Добавление остальных вершин...

var graph = new Graph();
graph.Vertices.AddRange(new[] { vertexA, vertexB, vertexC, vertexD });

vertexA.AddEdgeTo(vertexB, 1);
vertexB.AddEdgeTo(vertexC, 3);
vertexA.AddEdgeTo(vertexD, 1);
vertexD.AddEdgeTo(vertexC, 1);
// Добавление остальных ребер...

var shortestPaths = graph.DijkstraAlgorithm(vertexA, out Dictionary<Vertex, Vertex> pathPrevious);

foreach (var p in shortestPaths)
{
    Console.WriteLine($"Кратчайший путь до {p.Key.Name}: {p.Value}");
    Console.Write($"Предыдущие узлы: ");
    Vertex? current = p.Key;

    while (true)
    {
        if (!pathPrevious.ContainsKey(current))
            break;

        current = pathPrevious[current];

        Console.Write($"{current.Name} ");
    }
    Console.WriteLine();
}