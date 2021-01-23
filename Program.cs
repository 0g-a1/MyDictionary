using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStudents<int, string> Student = new MyStudents<int, string>();

            Student.Add(001, "Aa Bb");
            Student.Add(002, "Cc Dd");

            Console.WriteLine("Mevcut Öğrenci Sayısı : "+Student.Count+"\n");

            Student.AddedStudents();
        }
    }

    
}
