namespace LadosTrianguloi;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y: ");
        y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX= x.Area();
        double areaY= y.Area();

        Console.Clear();

        Console.WriteLine($"Área de X = {areaX:f4}", CultureInfo.InvariantCulture);
        Console.WriteLine($"Área de Y = {areaY:f4}", CultureInfo.InvariantCulture);

        if (areaX > areaY) Console.WriteLine("Maior área = X");
        if (areaY > areaX) Console.WriteLine("Maior área = Y");
        
        
    }
}







//*PROFESSOR
        // Console.Clear();
        // double xA, xB, xC, yA, yB, yC;

        // Console.WriteLine("Entre com as medidas do triângulo X: ");
        // xA= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // xB= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // xC= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Console.WriteLine("Entre com as medidas do triângulo Y: ");
        // yA= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // yB= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // yC= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // double pX = (xA+xB+xC) / 2.0;
        // double areaX= Math.Sqrt(pX * (pX-xA) * (pX-xB) * (pX-xC));

        // double pY = (yA+yB+yC) / 2.0;
        // double areaY= Math.Sqrt(pY * (pY-yA) * (pY-yB) * (pY-yC));

        // Console.WriteLine($"Área de X = {areaX:f4}", CultureInfo.InvariantCulture);
        // Console.WriteLine($"Área de Y = {areaY:f4}", CultureInfo.InvariantCulture);

        // if (areaX > areaY) Console.WriteLine("Maior área = X");
        // if (areaY > areaX) Console.WriteLine("Maior área = Y");
//*Meu Código

// Console.Clear();
        // Console.WriteLine("Medidas triângulo X: ");
        // double ax = double.Parse(Console.ReadLine());
        // double bx = double.Parse(Console.ReadLine());
        // double cx = double.Parse(Console.ReadLine());
        // // Console.WriteLine(ax);
        // // Console.WriteLine(bx);
        // // Console.WriteLine(cx);
        
        // double px = (ax+bx+cx) / 2;

        // Console.WriteLine("Medidas triângulo Y: ");
        // double ay = double.Parse(Console.ReadLine());
        // double by = double.Parse(Console.ReadLine());
        // double cy = double.Parse(Console.ReadLine());
        // // Console.WriteLine(ay);
        // // Console.WriteLine(by);
        // // Console.WriteLine(cy);
        
        // double py = (ay+by+cy) / 2;

        // Console.WriteLine($"Medida X: {px}\nMedida Y: {py}");

        // double[] array= {px,py};

        

        // Console.WriteLine($"Maior área é {array.Max()}");