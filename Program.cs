using System;

namespace OOP2
{
    class Circle //Объект круг,  с параметрами данными по условию
    {
        public string circleColor;
        public string circleName = "Circle Pit";
        public double circleRadius;
        public double circleArea;
        public double circlePerim;

        public void getCircleRadius() // Метод получения радиуса
        {
            Console.WriteLine("enter circle radius: ");  
            circleRadius = Convert.ToDouble(Console.ReadLine());
        }
        public void getCircleArea() // Метод получения площади
        {
            circleArea = Math.PI * (circleRadius * circleRadius);
        }
        public void getCirclePerim() // Метод получения периметра
        {
            circlePerim = 2 * Math.PI * circleRadius;
        }

        public string getCircleColour() // Метод получения рандомного цвета объекта
        {
            string[] ccolor = { "blue", "red", "yellow", "white", "black", "brown", "green", "purple", "orange", "grey" };
            Random s = new Random();
            int x = s.Next(0, ccolor.Length);
            circleColor = ccolor[x];
            return circleColor;
        }
        public void getCircleInfo() // Метод дающий инфо об объекте круг
        {
            Console.WriteLine(" Circle name: " + circleName + "\n" + " Circle color: " + circleColor + "\n" + " Circle area: " + circleArea + "\n" + " Circle perimetr: " + circlePerim + "\n");
        }

    }
    class Square //Создаем объект квадрат,  с параметрами данными по условию
    {
        public string squareColor;
        public string squareName = "Kazimir";
        public double squareSide;
        public double squareArea;
        public double squarePerim;

        public void getSquareSide() // Метод получения стороны квадрата
        {
            Console.WriteLine(" enter square side: ");
            squareSide = Convert.ToDouble(Console.ReadLine());
        }
        public void getSquareArea()// Метод получения площади квадрата
        {
            squareArea = squareSide * squareSide;
        }
        public void getSquarePerim()// Метод получения периметра квадрата
        {
            squarePerim = 4 * squareSide;
        }

        public string getSquareColour() // Метод получения рандомного цвета объекта
        {
            string[] scolor = { "blue", "red", "yellow", "white", "black", "brown", "green", "purple","orange","grey"};
            Random s = new Random();
            int x = s.Next(0, scolor.Length);
            squareColor = scolor[x];
            return squareColor;
        }
        public void getSquareInfo() // Метод дающий инфо об объекте квадрат
        {
            Console.WriteLine(" Square name: " + squareName + "\n" + " Square color: " + squareColor + "\n" + " Square area: " + squareArea + "\n" + " Square perimetr: " + squarePerim + "\n");
            
        }

    } 
    class Traingle //Объект треугольник, с параметрами данными по условию
    {
        public string triangleColor;
        public string triangleName = "Bermud";
        public double triangleSide1;
        public double triangleSide2;
        public double triangleSide3;
        public double triangleArea;
        public double trianglePerim;

        public void getTriangleSide() // Метод получения сторон треугольника
        {
            Console.WriteLine(" enter side A: ");
            triangleSide1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" enter side B: ");
            triangleSide2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" enter side C: ");
            triangleSide3 = Convert.ToDouble(Console.ReadLine());
        }
        public void getTriangleArea() // Метод получения площади треугольника
        {
            double p = 0.5 * (triangleSide1 + triangleSide2 + triangleSide3);
            triangleArea = Math.Sqrt(p) * (p - triangleSide1) * (p - triangleSide2) * (p - triangleSide3);
             
        }
        public void getTrianglePerim() // Метод получения периметра треугольника
        {

            trianglePerim = triangleSide1 + triangleSide2 + triangleSide3;
        }

        public string getTriangleColour() // Метод получения рандомного цвета объекта
        {
            string[] tcolor = { "blue", "red", "yellow", "white", "black", "brown", "green", "purple", "orange", "grey" };
            Random s = new Random();
            int x = s.Next(0, tcolor.Length); 
            triangleColor = tcolor[x];
            return triangleColor;
        }
        public void getTriangleInfo() // Метод получения рандомного цвета объекта
        {
            Console.WriteLine(" Triangle name: " + triangleName + "\n" + " Triangle color: " + triangleColor + "\n" + " Tringle area: " + triangleArea + "\n" + " Tringle perimetr: " + trianglePerim + "\n");
        }

    } 
    class Program
    {
        static void Main(string[] args)
        {
            
                while (true) //постоянный цикл позволяющий завершать программу, только по вводу определенного ключа. 
                {
                    Console.WriteLine(" You can choose three items or exit: \n" + "  1 - circle\n " + " 2 - square\n " + " 3 - triangle\n " + " 0 - exit\n"); // окно преветствия
                    Console.WriteLine(" Enter num");
                    string selection = Console.ReadLine();

                    switch (selection) // цикл с кейсами предметов 
                    {


                        case "1": // вызов объекта круг с применением методов

                            Console.WriteLine();
                            Console.WriteLine(" You have chosen a circle! ");
                            Console.WriteLine();
                            Circle circle = new Circle();
                            circle.getCircleRadius();
                            Console.WriteLine();
                            circle.getCirclePerim();
                            circle.getCircleArea();
                            circle.getCircleColour();
                            circle.getCircleInfo();
                        break;



                        case "2": // вызов объекта круг с применением методов

                        Console.WriteLine();
                            Console.WriteLine(" You have chosen a square! ");
                            Console.WriteLine();
                            Square square = new Square();
                            square.getSquareSide();
                            Console.WriteLine();
                            square.getSquarePerim();
                            square.getSquareArea();
                            square.getSquareColour();
                            square.getSquareInfo();
                            break;


                        case "3": // вызов объекта круг с применением методов



                        Console.WriteLine();
                            Console.WriteLine(" You have chosen a triangle! ");
                            Console.WriteLine();
                            Traingle triangle = new Traingle();
                            triangle.getTriangleSide();
                            Console.WriteLine();
                            triangle.getTrianglePerim();
                            triangle.getTriangleArea();
                            triangle.getTriangleColour();
                            triangle.getTriangleInfo();
                            break;

                        case "0": // кейс отвечающий за выход


                        Console.WriteLine(" ");
                        Console.WriteLine(" Thank you and goodbye");
                        return;


                    }
                }

        }
    }
}


