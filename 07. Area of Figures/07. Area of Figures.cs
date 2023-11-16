namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string figure =  Console.ReadLine();
            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideA:F3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse((Console.ReadLine()));
                double sideB = double.Parse((Console.ReadLine()));
                Console.WriteLine($"{sideA * sideB:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radius * radius:F3}");
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double heightToSideA = double.Parse(Console.ReadLine());
                Console.WriteLine(0.5*sideA*heightToSideA);
            }
        }
    }
}