using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_MyCodeSnippet.Models.Excercise
{
    public class Student
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

    }

    public class ExampleDictionary {
        public ExampleDictionary()
        {
        }
        public void example()
        {
            Dictionary<int, Student> StudentDictionary = new Dictionary<int, Student>();

            Student s1 = new Student("Sugo", "0421121880");
            Student s2 = new Student("Dugo", "0403797901");

            StudentDictionary.Add(1, s1);
            StudentDictionary.Add(2, s2);

            Student result = new Student("", "");

            StudentDictionary.TryGetValue(1, out result);


        }

    }
}