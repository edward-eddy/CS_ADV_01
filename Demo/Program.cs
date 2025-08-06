namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics :
            // C# Feature 2005 C# 2.0
            // Before 2005 Class Object

            #region Generic Ex01 : SWAP
            // SWAP

            //int A = 4, B = 5;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine(" ********* After SWAP ********* ");

            //Helper.SWAP(ref A, ref B); // Passing By ref

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //double L = 1.5, K = 2.6;

            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");
            //Console.WriteLine(" ********* After SWAP ********* ");

            //Helper.SWAP(ref L, ref K);

            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");

            // Point : X, Y

            //Point P01 = new Point(1,1);
            //Point P02 = new Point(2,2);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");

            //Console.WriteLine(" ********* After SWAP ********* ")

            //Helper.SWAP(ref P01, ref P02);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");

            // ==================================================================

            //int A = 4, B = 5;
            //double X = 1.5;

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //Console.WriteLine(" ********* After SWAP ********* ");

            //Helper.SWAP/*<int>*/(ref A, ref B); // Passing By ref

            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //double L = 1.5, K = 2.6;

            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");
            //Console.WriteLine(" ********* After SWAP ********* ");

            //Helper.SWAP(ref L, ref K);

            //Console.WriteLine($"L: {L}");
            //Console.WriteLine($"K: {K}");

            //Point: X, Y

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}");

            //Console.WriteLine(" ********* After SWAP ********* ");

            //Helper/*<Point>*/.SWAP(ref P01, ref P02);

            //Console.WriteLine($"P01: {P01}");
            //Console.WriteLine($"P02: {P02}"); 
            #endregion

            // Linear Search

            // 4 7 8 9 10 1 2 3 5 12 -1 - 13 11
            // Index


            //int[] Numbers = {8,7, 6, 1, 2, 3, 4, 5, 6, 12, -1, 13, 9 };

            //int Index = Helper.LinearSearch(Numbers, 4); // 6
            //int Index = Helper.LinearSearch(Numbers, 12); // 9

            //Console.WriteLine($"Index: {Index}");


            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 31 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 11000, Age = 34 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 13000, Age = 32 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mona", Salary = 19000, Age = 29 };


            //Employee[] employees = { E01, E02, E03, E04 };

            //int Index = Helper.LinearSearch(employees, E01);

            //Console.WriteLine($"Index : {Index}");

            //if (E01.Equals(E02))
            //    Console.WriteLine("E01 == E02");



        }
    }
}
