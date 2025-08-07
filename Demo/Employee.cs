namespace Demo
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Operator Overloading ==
        public static bool operator ==(Employee left, Employee right)
        {
            return left.Id == right.Id && left.Name == right.Name && left.Age == right.Age && left.Salary == right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return
            left.Id != right.Id || left.Name != right.Name || left.Age != right.Age || left.Salary != right.Salary;
        }

        public override bool Equals(object? obj)
        {
            Employee employee = (Employee)obj;
            //return Id == employee.Id && Name == employee.Name && Age == employee.Age && Salary == employee.Salary;
            return this == employee;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Age : {Age}, Salary : {Salary}";
        }

        //public int CompareTo(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return Age.CompareTo(E.Age);
        //}

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;

            return Age.CompareTo(other.Age);
        }
    }
}
