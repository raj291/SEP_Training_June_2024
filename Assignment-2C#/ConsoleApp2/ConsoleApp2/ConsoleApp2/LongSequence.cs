namespace ConsoleApp2;

public class LongSequence
{
 public int FindLong(int[] arr)
 {
  int l = 0;
  for (int i = 1; i < arr.Length; i++)
  {
   int target = arr[i];
   if (arr[i] == arr[i - 1])
   {
    l += 1;
   }
   else
   {
    l = l;
    target = arr[i];
   }
  }

  return l;
 }
}