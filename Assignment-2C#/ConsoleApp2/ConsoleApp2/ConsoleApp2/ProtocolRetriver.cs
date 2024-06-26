namespace ConsoleApp2;

public class ProtocolRetriver
{
    public string[] SpiltPro(string input)
    {
        string[] parts = input.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length >= 1)
        {
            string part1 = parts[0].Trim();
            string part2 = string.Empty;
            if (parts.Length >= 2)
            {
                part2 = parts[1].Trim();
            }
            string part3 = string.Empty;
            if (parts.Length >= 3)
            {
                part3 = parts[2].Trim();
            }
            Console.WriteLine("Part 1: " + part1);
            Console.WriteLine("Part 2: " + part2);
            Console.WriteLine("Part 3: " + part3);
        }
        else
        {
            Console.WriteLine("Invalid input format");
        }

        return parts;
    }
}