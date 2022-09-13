namespace ConsoleApp14;

class Run
{
    public void runFunc(Func del, string s) => del(s);
}


class MyClass
{
    public string S;
    public MyClass(string s)
    {
        S = s;
    }

    public void Space(string s)
    {
        Console.WriteLine($"\n{string.Join("_", s.ToCharArray())}\n");
    }
    public void Reverse(string s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
    }
}

delegate void Func(string str);



class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string");
        var str = Console.ReadLine()!;
        MyClass cls = new MyClass(str!);
        Func funcDell = new Func(cls.Reverse); 
        funcDell += cls.Space;
        Run run = new Run();
        run.runFunc(funcDell, str);
    }
}