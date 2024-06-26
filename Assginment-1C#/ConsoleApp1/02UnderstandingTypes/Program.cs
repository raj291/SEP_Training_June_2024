// See https://aka.ms/new-console-template for more information

int sb= sizeof(sbyte);
int b = sizeof(sbyte);
int sh = sizeof(short);
int ush = sizeof(ushort);
int intsize = sizeof(int);
int units = sizeof(uint);
int l = sizeof(long);
int ul = sizeof(ulong);
int fl = sizeof(float);
int du = sizeof(double);
int dl = sizeof(decimal);
Console.WriteLine($"sbyte size: {sb}");
Console.WriteLine($"byte size: {b}");
Console.WriteLine($"short size: {sh}");
Console.WriteLine($"ushort size: {ush}");
Console.WriteLine($"int size {intsize}");
Console.WriteLine($"uint size {units}");
Console.WriteLine($"long size: {l}");
Console.WriteLine($"ulong size: {ul}");
Console.WriteLine($"float size: {fl}");
Console.WriteLine($"double size: {du}");
Console.WriteLine($"decimal size: {dl}");
