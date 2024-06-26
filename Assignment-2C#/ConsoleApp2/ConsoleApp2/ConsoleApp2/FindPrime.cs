namespace ConsoleApp2;

public class FindPrime
{
    public int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> list = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            bool isp = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isp = false;
                    break;
                }
            }

            if (isp)
            {
             list.Add(i);   
            }

        }
        int[] arr = list.ToArray();
        return arr;
    }
}

