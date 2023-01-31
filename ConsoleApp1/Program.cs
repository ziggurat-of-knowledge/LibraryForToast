using LibraryForToast;

SquareFigure squareFigure = new SquareFigure();

float s = squareFigure.GetArea(5f);
float sd = squareFigure.GetArea(5, 3, 2);
string sd1 = squareFigure.IsTriangleRectangular(5, 3, 2);
string sd2 = squareFigure.IsTriangleRectangular(5, 5, 2);
string sd3 = squareFigure.IsTriangleRectangular(5, 3, 5);
string sd4 = squareFigure.IsTriangleRectangular(2, 5, 5);

Console.WriteLine(s);
Console.WriteLine(sd);
Console.WriteLine(sd1);
Console.WriteLine(sd2);
Console.WriteLine(sd3);
Console.WriteLine(sd4);
Console.Read();
