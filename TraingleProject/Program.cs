using TraingleProject;


Traingle taringle = new Traingle();

Console.WriteLine("SideA: ");
taringle.SideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("SideB: ");
taringle.SideB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("SideC: ");
taringle.SideC = Convert.ToDouble(Console.ReadLine());

if (!taringle.Equals(new Traingle()))
{
    Console.WriteLine("There's no traingle exist , /n please enter 3 sides of traingle");
}
else
{
    if (taringle.getTraingleType())
    {
        Console.WriteLine("Right Traingle");
    }
    else
    {
        Console.WriteLine($"Traingle has Side A:{taringle.SideA}, Side B: {taringle.SideB}, Side C : {taringle.SideC}");
    };

}
