// See https://aka.ms/new-console-template for more information
int l = int.Parse(Console.ReadLine());
int[] ar = { 1, 2, 46, 7, 8, 8, 3, 9, 5, 3 };
int[] jr = new int[l];
for (int i = 0; i < ar.Length; i++)
{
    jr[i] = ar[i];
}
Console.WriteLine("The new Array : "+string.Join(", ", jr));
Console.WriteLine(" The old Array:  " + string.Join(", ",ar));