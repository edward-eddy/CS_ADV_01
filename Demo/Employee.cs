namespace Demo
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Age : {Age}, Salary : {Salary}";
        }

    }
}
