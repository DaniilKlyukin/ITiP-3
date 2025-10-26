var input = File.ReadAllLines("input.txt");

var N = int.Parse(input[0]);

var edges = input.Skip(1)
    .Select(edge =>
        edge.Split(' ')
        .Select(int.Parse)
        .ToArray())
    .ToArray();

var childsOnBranches = new Dictionary<long, long>();

foreach (var edge in edges)
{
    var from = edge[0];

    if (childsOnBranches.ContainsKey(from))
        childsOnBranches[from]++;
    else
        childsOnBranches.Add(from, 1);
}

var maxChildsCount = childsOnBranches.Max(c => c.Value);

var factorials = new long[maxChildsCount + 1];
factorials[0] = 1;

for (int i = 1; i < factorials.Length; i++)
{
    factorials[i] = i * factorials[i - 1];
}

var modM = 1_000_000_000L + 7L;

var sequencesCount = childsOnBranches
    .Values
    .Where(count => count > 1)
    .Aggregate((totalProd, count) => totalProd * factorials[count] % modM);

Console.WriteLine(sequencesCount);