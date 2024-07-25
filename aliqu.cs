using System;
using System.Collections.Generic;

public class Student
{
    private List<int> ALL_MARKS;

    public Student()
    {
        ALL_MARKS = new List<int> { 90, 85, 78, 92 };
    }

    public List<int> GetAllMarks()
    {
        return ALL_MARKS;
    }
}

public class Program
{
    public static void Main()
    {
        Student student = new Student();
        List<int> marks = student.GetAllMarks();
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }
    }
}
