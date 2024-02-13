Console.WriteLine("Впишите N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впишите X");
int X = Convert.ToInt32(Console.ReadLine());
double res = -Math.PI / 2;
for (
    int i = 0; i <= N; i++
    )
{
    res = res + ((Math.Pow((-1), (i + 1))) / (((2 * i + 1) * (Math.Pow(X, (2 * i + 1))))));
}
Console.WriteLine(res);

