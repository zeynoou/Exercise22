namespace Exercise22
{
    class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please write somthing:");
        string a = Console.ReadLine();
        var result = ReverseCase(a);
        Console.WriteLine(result);
    }

    public static string ReverseCase(string a)
    {
        return string.Concat(a.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
    }
}

}