for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

Parallel.For(0, 5, i =>
{
    Console.WriteLine(i);
});