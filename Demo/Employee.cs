using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    class EmployeeEqualityComparerName : IEqualityComparer<Employee>
    {

        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
    internal class Employee : IComparable<Employee>, IEquatable<Employee>
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




        public override bool Equals(object? obj)
        {
            Employee employee = (Employee)obj;
            //return Id == employee.Id && Name == employee.Name && Age == employee.Age && Salary == employee.Salary;
            return this == employee;
        }

        public bool Equals(Employee? other)
        {
            if (other is null) return false;

            return this == other;
        }



        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Age : {Age}, Salary : {Salary}";
        }
    }
}
