namespace TestApp;

public class ItemNotFoundException : Exception
{
    public ItemNotFoundException(int item) : base($"Item {item} was not found in the list.")
    {

    }
}