using Algorytmy2;

Sortowanie sort = new([5, 7, 2, 2, 1, 4, 5, 6]);
Console.WriteLine(sort.Sort());
int[] t = sort.FindLowestAndExchange();
foreach (var item in t)
{
    Console.Write($"{item}, ");
}
