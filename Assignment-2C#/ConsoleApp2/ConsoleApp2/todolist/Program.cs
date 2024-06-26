// See https://aka.ms/new-console-template for more information
List<string> items = new List<string>();
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    
    string item = Console.ReadLine();
    if (item.IndexOf("+") == 0)
    {
        string itemtoadd = item.Substring(1);
        items.Add(itemtoadd);
    }

    //Console.WriteLine(items);
    else if (item.IndexOf("-") == 0)
    {
        string itemtore = item.Substring(1);
        items.Remove(itemtore);
    }
    else if (item.IndexOf("_") == 0)
    {
        items.Clear();
    }
    else if (item == "exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Input or Try Again");
    }
    Console.WriteLine("To-do List");
    if (items.Count == 0)
    {
        Console.WriteLine(":");
    }
    else
    {
        for(int i = 0 ; i < items.Count ; i++)
        {
            Console.WriteLine($"{items[i]}");
            
        }
        Console.WriteLine("##############");
    }
}