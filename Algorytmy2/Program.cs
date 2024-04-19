using Algorytmy2;

List<int> cyfry = new List<int>();
int[] t;

Console.WriteLine("Podaj cyfry do arrayu np. 1,2,3,4");
string[] cyfryString = Console.ReadLine().Split(",");
foreach (string cyfra in cyfryString)
    cyfry.Add(int.Parse(cyfra));

Sortowanie sort = new(cyfry.ToArray());

void menu()
{
    Console.WriteLine("1. Znajdz najmniejsza");
    Console.WriteLine("2. Znajdz najwieksza");
    Console.WriteLine("3. Najmniejsza i podmien");
    Console.WriteLine("4. Posortuj");
    string wybor = Console.ReadLine();
    switch (wybor)
    {
        case "1":
            Console.WriteLine(sort.FindLowest());
            break;
        case "2":
            Console.WriteLine(sort.FindHighest());
            break;
        case "3":
            t = sort.FindLowestAndExchange();
            foreach (int cyfra in t)
                Console.Write($"{cyfra}, ");
            break;
        case "4":
            t = sort.Sort(cyfry.ToArray());
            foreach (int cyfra in t)
                Console.Write($"{cyfra}, ");
            break;
    }
}
menu();
