using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Dynamic_List_of_Students_in_a_Classroom
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Classroom
    {
        public event Action<string, string> StudentChanged;

        public List<Student> ListStudents = new List<Student>();

        public void AddStudent(Student student)
        {
            ListStudents.Add(student);
            StudentChanged?.Invoke($"Add {student.Name}", student.Name);
        }

        public void RemoveStudent(Student student)
        {
            if(ListStudents.Remove(student))
                StudentChanged?.Invoke($"Remove {student.Name}", student.Name);
        }

        public void ReplaceStudent(Student oldStudent, Student newStudent)
        {
            int index = ListStudents.IndexOf(oldStudent);
            if(index != -1)
            {
                ListStudents[index] = newStudent;
                StudentChanged?.Invoke($"Replace {oldStudent.Name} with {newStudent.Name}", newStudent.Name);
            }
        }

        public void PrintStudents()
        {
            foreach (var student in ListStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //solve with event
/*
            Classroom classroom = new Classroom();
            classroom.StudentChanged += (message, studentName) => Console.WriteLine($"Change UI: {message} + {studentName}");

            Student student1 = new Student { Name = "Alice", Age = 20 };
            Student student2 = new Student { Name = "Bob", Age = 22 };

            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            classroom.PrintStudents();
            classroom.RemoveStudent(student1);
            classroom.PrintStudents();
             Student student3 = new Student { Name = "Charlie", Age = 21 };
            classroom.ReplaceStudent(student2, student3);
            classroom.PrintStudents();
*/

            Console.WriteLine("=========================");
            //teacher solution
            ObservableCollection<string> students = new ObservableCollection<string>();

            students.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"New Student Added: {e.NewItems[0]}");

                if(e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Student Removed: {e.OldItems[0]}");

                if(e.Action == NotifyCollectionChangedAction.Replace)
                    Console.WriteLine($"Student Replaced: {e.OldItems[0]} with {e.NewItems[0]}");
            };

            students.Add("Alice");
            students.Add("Bob");
            students.Remove("Alice");
            students[0] = "Charlie";
        }
    }
}
