using System;

namespace OOP2
{
    class Circle
    {
        public string circleColor;
        public string circleName = "Circle Pit";
        public double circleRadius;
        public double circleArea;
        public double circlePerim;

        public void getCircleRadius()
        {
            circleRadius = Convert.ToDouble(Console.ReadLine());
        }
        public void getCircleArea()
        {
            circleArea = Math.PI * (circleRadius * circleRadius);
        }
        public void getCirclePerim()
        {
            circlePerim = 2 * Math.PI * circleRadius;
        }

        public string getCircleColour()
        {
            string[] ccolor = { "blue", "red", "yellow", "white", "black", "brown", "green", "purple", "orange", "grey" };
            Random s = new Random();
            int x = s.Next(0, ccolor.Length);
            circleColor = ccolor[x];
            return circleColor;
        }
        public void getCircleInfo()
        {
            Console.WriteLine("Circle name: " + circleName + "\n" + "Circle color: " + circleColor + "\n" + "Circle area: " + circleArea + "\n" + "Circle perimetr: " + circlePerim + "\n");
        }

    }
    class Square
    {
        public string squareColor;
        public string squareName = "Kazimir";
        public double squareSide;
        public double squareArea;
        public double squarePerim;

        public void getSquareSide()
        {
            squareSide = Convert.ToDouble(Console.ReadLine());
        }
        public void getSquareArea()
        {
            squareArea = squareSide * squareSide;
        }
        public void getSquarePerim()
        {
            squarePerim = 4 * squareSide;
        }

        public string getSquareColour()
        {
            string[] scolor = { "blue", "red", "yellow", "white", "black", "brown", "green", "purple","orange","grey"};
            Random s = new Random();
            int x = s.Next(0, scolor.Length);
            squareColor = scolor[x];
            return squareColor;
        }
        public void getSquareInfo()
        {
            Console.WriteLine("Square name: " + squareName + "\n" + "Square color: " + squareColor + "\n" + "Square area: " + squareArea + "\n" + "Square perimetr: " + squarePerim + "\n");
        }

    }
    class Traingle
    {
        public string triangleColor;
        public string triangleName = "Bermud";
        public double triangleSide1;
        public double triangleSide2;
        public double triangleSide3;
        public double triangleArea;
        public double trianglePerim;

        public void getTriangleSide()
        {
            triangleSide1 = Convert.ToDouble(Console.ReadLine());
            triangleSide2 = Convert.ToDouble(Console.ReadLine());
            triangleSide3 = Convert.ToDouble(Console.ReadLine());
        }
        public void getTriangleArea()
        {
            triangleArea=23;
        }
        public void getTrianglePerim()
        {
            double p = 0.5 * (triangleSide1 + triangleSide2 + triangleSide3);
            trianglePerim = Math.Sqrt(p) * (p - triangleSide1) * (p - triangleSide2) * (p - triangleSide3);
        }

        public string getTriangleColour()
        {
            string[] tcolor = { "blue", "red", "yellow", "white", "black", "brown", "green", "purple", "orange", "grey" };
            Random s = new Random();
            int x = s.Next(0, tcolor.Length);
            triangleColor = tcolor[x];
            return triangleColor;
        }
        public void getTriangleInfo()
        {
            Console.WriteLine("Triangle name: " + triangleName + "\n" + "Triangle color: " + triangleColor + "\n" + "Tringle area: " + triangleArea + "\n" + "Tringle perimetr: " + trianglePerim + "\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
                while (true)
                {
                    Console.WriteLine("Hello guest!\n" + "You can choose three items or exit: \n" + " 1 - circle\n " + "2 - square\n " + "3 - triangle\n " + "0 - exit\n");
                    string selection = Console.ReadLine();

                    switch (selection)
                    {


                        case "1":

                            Console.WriteLine();
                            Console.WriteLine("You have chosen a circle! ");
                            Console.WriteLine();
                            Circle circle = new Circle();
                            circle.getCircleRadius();
                            Console.WriteLine();
                            circle.getCirclePerim();
                            circle.getCircleArea();
                            circle.getCircleColour();
                            circle.getCircleInfo();
                        break;



                        case "2":

                            Console.WriteLine();
                            Console.WriteLine("You have chosen a square! ");
                            Console.WriteLine();
                            Square square = new Square();
                            square.getSquareSide();
                            Console.WriteLine();
                            square.getSquarePerim();
                            square.getSquareArea();
                            square.getSquareColour();
                            square.getSquareInfo();
                            break;


                        case "3":



                            Console.WriteLine();
                            Console.WriteLine("You have chosen a triangle! ");
                            Console.WriteLine();
                            Traingle triangle = new Traingle();
                            triangle.getTriangleSide();
                            Console.WriteLine();
                            triangle.getTrianglePerim();
                            triangle.getTriangleArea();
                            triangle.getTriangleColour();
                            triangle.getTriangleInfo();
                            break;

                        case "0":



                            Console.WriteLine("Goodbye");
                        return;


                    }
                }

        }
    }
}


