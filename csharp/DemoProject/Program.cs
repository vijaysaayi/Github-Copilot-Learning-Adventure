var quadraticRoots = RetrieveQuadraticRoots(3, 4, 5);

Console.WriteLine($"Root 1: {quadraticRoots.Root1}");
Console.WriteLine($"Root 2: {quadraticRoots.Root2}");

QuadraticRoots RetrieveQuadraticRoots(double a, double b, double c)
{
    double discriminant = (Math.Pow(b, 2)) + (-4 * a * c);

    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

    return new QuadraticRoots
    {
        Root1 = root1,
        Root2 = root2
    };
}

class QuadraticRoots
{
    public double Root1 { get; set; }
    public double Root2 { get; set; }
}