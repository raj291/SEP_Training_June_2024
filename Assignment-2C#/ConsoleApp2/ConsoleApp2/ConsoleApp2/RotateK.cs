namespace ConsoleApp2;

public class RotateK
{
    public int[] Rotate(int[] arr, int k)
    {
        int[] sum = new int[arr.Length];

        for (int r = 1; r <= k; r++)
        {
            int[] rot = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                // Calculate the new index for the rotated element
                int newIndex = (i + r) % arr.Length;
                // Place the element at its new index in the rotated array
                rot[newIndex] = arr[i];
            }
                
            // Sum the rotated array with the total sum
            for (int i = 0; i < arr.Length; i++)
            {
                sum[i] += rot[i];
            }
        }

        return sum;
    }
}