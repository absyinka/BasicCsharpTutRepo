namespace TestApp;

public class Search
{
    List<int> items;

    public Search(List<int> initialItems)
    {
        items = new List<int>(initialItems);
        items.Sort();
    }

    public int BinarySearch(int target)
    {
        int left = 0;
        int right = items.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (items[mid] == target)
                return mid;

            if (items[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        throw new ItemNotFoundException(target);
    }

    public void ShowNumbers()
    {
        Console.WriteLine("Display numbers:");

        foreach (int item in items)
        {
            Console.WriteLine($"{item}");
        }
    }

    public static void SearchEngine()
    {
        var search = new Search([30, 24, 44, 10, -11]);

        search.ShowNumbers();

        bool flag = true;

        while (flag)
        {
            try
            {
                Console.Write("Enter a number to search: ");
                int number = int.Parse(Console.ReadLine()!);

                int index = search.BinarySearch(number);
                Console.WriteLine($"item {number} found at index {index}");
            }
            catch (ItemNotFoundException ex)
            {
                //Log here
                Console.WriteLine($"{ex.Message}");
            }
            catch (FormatException ex)
            {
                //log here
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                //log here
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }
    }
}