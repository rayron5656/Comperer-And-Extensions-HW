using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperer_And_Extensions_HW
{
    class StudentCompByLastName : IComparer<Student> //Compare By last name 
    {
        public int Compare(Student x, Student y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
    class StudentCompByGrade : IComparer<Student> //Compare By Grade From the highest to lowest
    {
        public int Compare(Student x, Student y)
        {
            return x.Grade.CompareTo(y.Grade) * -1;
        }
    }
    class StudentCompByFullName : IComparer<Student> //Compare By last name => First Name
    {
        public int Compare(Student x, Student y)
        {
            if (x.LastName.CompareTo(y.LastName) == 0)
            {
                return x.FirstName.CompareTo(y.FirstName);
            }
            else
            {
                return x.LastName.CompareTo(y.LastName);
            }
        }
    }
    class Student : IComparable<Student>
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public int CompareTo(Student other) //Compare By last name => First Name => Grade(From Highest to lowest)
        {
            if (LastName.CompareTo(other.LastName) == 0)
            {
                if (FirstName.CompareTo(other.FirstName) == 0)
                {
                   return Grade.CompareTo(other.Grade) * -1;
                }
                else
                {
                    return FirstName.CompareTo(other.FirstName);
                }
            }
            else
            {
                return LastName.CompareTo(other.LastName);
            }
        }
    }
}
