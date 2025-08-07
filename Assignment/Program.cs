namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01.
            /*
                1. create a generic Range<T> class that represents a range of values from a minimum value to a maximum
            value. The range should support basic operations such as checking if a value is within the range and 
            determining the length of the range.
            */
            //Range<int> intRange = new Range<int>(7, 10);
            //Console.WriteLine(intRange.IsInRange(8));
            //Console.WriteLine(intRange.IsInRange(100));

            //Console.WriteLine();

            //Console.WriteLine($"Length : {intRange.GetLength()}");

            //Console.WriteLine("\n ================== \n");

            //Range<string> stringRange = new Range<string>("7", "10");
            //Console.WriteLine(stringRange.IsInRange("8"));
            //Console.WriteLine(stringRange.IsInRange("100"));

            //Console.WriteLine();

            //Console.WriteLine($"Length : {stringRange.GetLength()}"); 
            #endregion

            #region Q02.
            /*
                2. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements 
            in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement 
            a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            */

            //Employee[] employees =
            //{
            //    new Employee() {Id = 1, Name = "Ahmed"},
            //    new Employee() {Id = 2, Name = "Ali"},
            //    new Employee() {Id = 3, Name = "Yassmin"},
            //    new Employee() {Id = 4, Name = "Edward"},
            //    new Employee() {Id = 5, Name = "Alaa"}
            //};

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //Helpers.Reverse(employees);
            //Console.WriteLine("\n After Reverse \n");

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion

            #region Q03.
            /*
             3. You are given a list of integers. Your task is to find and return a new list containing only 
            the even numbers from the given list.
             */

            //int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int[] even = Helpers.GetEven(list);

            //foreach (int i in list)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("\n");

            //foreach (int i in even)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

        }
    }
}
