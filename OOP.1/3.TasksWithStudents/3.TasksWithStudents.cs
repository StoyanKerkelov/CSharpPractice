using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3. First before last

//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

//Problem 4. Age range

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//Problem 5. Order students

//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

class TasksWithStudents
{
    static void Main()
    {
        Student student1 = new Student { FirstName = "Ivan", LastName = "Ivanov", Age = 18 };
        Student student2 = new Student { FirstName = "Asen", LastName = "Ivanov", Age = 30 };
        Student student3 = new Student { FirstName = "Petar", LastName = "Todorov", Age = 23 };
        Student student4 = new Student { FirstName = "Kristian", LastName = "Ivanov", Age = 27 };
        Student student5 = new Student { FirstName = "Petar", LastName = "Yasenov", Age = 20 };
        Student student6 = new Student { FirstName = "Dimitar", LastName = "Dimitarov", Age = 22 };

        List<Student> students = new List<Student>();

        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
        students.Add(student5);
        students.Add(student6);

        #region Task 3: First before last

        Console.WriteLine(new String('=', 20) + "Task 3" + new String('=', 30));

        var firstBeforeLast =
            from stud in students
            where stud.FirstName.CompareTo(stud.LastName) < 0
            select stud;

        foreach (var student in firstBeforeLast)
        {
            Console.WriteLine(student);
        }

        #endregion

        #region Task 4: Age between 18 and 24

        Console.WriteLine(new String('=', 20) + "Task 4" + new String('=', 30));

        var ageBetween18And24 =
            from stud in students
            where stud.Age < 24 && stud.Age > 18
            select stud;

        foreach (var student in ageBetween18And24)
        {
            Console.WriteLine(student);
        }
        #endregion

        #region Task 5: Order student names

        Console.WriteLine(new String('=', 20) + "Task 5 - Extension Metods" + new String('=', 30));

        var sortedByNameExtension = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName);//order

        foreach (var student in sortedByNameExtension)
        {
            Console.WriteLine(student);//print
        }

        Console.WriteLine(new String('=', 20) + "Task 5 - LINQ" + new String('=', 30));// order by LINQ

        var sortedByNameLinq =
            from stud in students
            orderby stud.FirstName descending
            orderby stud.LastName descending
            select stud;

        foreach (var student in sortedByNameLinq)
        {
            Console.WriteLine(student);
        }

        #endregion
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
