namespace Propertys;

class Propertys
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Prop = 5;
            Console.WriteLine(d.Prop);
        }
    }
}

class Demo
{
    public int Prop { get; set; }
}