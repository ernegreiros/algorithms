static int? GetItemPositionInList(List<int> listOfItems, int item)
{
    int min = 0;
    int max = listOfItems.Count -1;
    var countOfIterations = 0;

    while (min <= max)
    {
        int middle = (max + min) / 2;
        var possibleValue = listOfItems[middle];
        countOfIterations++;

        if (possibleValue == item)
        {
            Console.WriteLine($"Count of iterations: {countOfIterations}");
            return middle;
        }

        if (item > possibleValue)
            min = middle + 1;
        else
            max = middle - 1;

    }

    Console.WriteLine($"Count of iterations: {countOfIterations}");
    return null;
}

//Lista precisa ser ordenada para funcionar, a busca do algoritmo é log n (log é log2)

var list = Enumerable.Range(1, 1000000).ToList();
//var item = Convert.ToInt32(Console.ReadLine());
var item = 1000000;

var itemPosition = GetItemPositionInList(list, item);

if (itemPosition is null)
{
    Console.WriteLine("Not found.");
}
else
{
    Console.WriteLine($"Item position is: {itemPosition}.");
}
