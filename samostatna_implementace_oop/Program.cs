using samostatna_implementace_oop;

int min = 0;
int max = 10;

Random random = new Random();
int[] areas = new int[3];
Console.WriteLine("obvody:");
for (int i = 0; i < 3; i++)
{
    Triangle Abc = new Triangle(random.Next(min, max), random.Next(min, max), random.Next(min, max));
    Console.WriteLine(Abc.GetPerimeter());
    areas[i] = Abc.GetArea();
}
Console.WriteLine("součet obsahů:");
Console.WriteLine(areas.Sum());
Console.ReadKey();
Environment.Exit(0);

namespace samostatna_implementace_oop
{
    class Triangle
    {
        public int a, b, c;

        public Triangle(int _a, int _b, int _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public int GetArea()
        {
            return (a * b) / 2;
        }

        public int GetPerimeter()
        {
            return a + b + c;
        }
    }
}