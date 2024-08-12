using PatikaPolymorphism;

public class Program
{
    public static void Main()
    {
        Square square = new Square(); //Kare nesnesi oluşturma
        square.Width = 10;
        square.Heigth = 10;
        Console.WriteLine($"Karenin alanı: {square.AreaCalculation()}");

        Rectangle rectangle = new Rectangle(); //Dikdörtgen nesnesi oluşturma
        rectangle.Width = 21;
        rectangle.Heigth = 5;
        Console.WriteLine($"Dikdörtgenin alanı: {rectangle.AreaCalculation()}");

        RightTriangle rightTriangle = new RightTriangle(); //Üçgen nesnesi oluşturma
        rightTriangle.Width = 10;
        rightTriangle.Heigth = 8;
        Console.WriteLine($"Üçgenin alanı: {rightTriangle.AreaCalculation()}");
    }
}