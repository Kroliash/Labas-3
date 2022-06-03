using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labas_3
{
    class Block2
    {
        static StudentStruct.Student[] ReadInfo()
        {
            int length = System.IO.File.ReadAllLines("input.txt").Length;
            StudentStruct.Student[] studs = new StudentStruct.Student[length];
            StreamReader streamReader = new StreamReader("input.txt");
            for (int i = 0; i < length; i++)
            {
                studs[i] = new StudentStruct.Student(streamReader.ReadLine());
            }
            return studs;
        }

        static void runMenu(StudentStruct.Student[] studs)
        {
            Console.Clear();
            Console.WriteLine("Here is the whole list of students:");   
            Console.WriteLine("--------------------------------------------------------------");
            ToString(studs);
            Console.WriteLine("--------------------------------------------------------------");
            bool flag = false;
            Console.WriteLine("Students with a grade of 5 in physics:");
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].physicsMark == '5')
                {
                    double gpa = GradePointAverage(studs, i);
                    Console.WriteLine($"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic} {gpa} {studs[i].scholarship}");
                    flag = true;
                }               
            }
            if (!flag)  Console.WriteLine("There are no such students");                 
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Press Enter to return to the block selection.");
            Console.ReadKey();
        }
        static void ToString(StudentStruct.Student[] studs)
        {
            for (int i = 0; i < studs.Length; i++)
            {
                Console.WriteLine($"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic} {studs[i].sex} {studs[i].dateOfBirth} {studs[i].mathematicsMark} {studs[i].physicsMark} {studs[i].informaticsMark} {studs[i].scholarship}");
            }
        }
        
        static double GradePointAverage (StudentStruct.Student[] studs , int i)
        {
            double sum = 0, gpa;          
                char[] arr= { studs[i].mathematicsMark, studs[i].physicsMark , studs[i].informaticsMark};
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == '-')
                    {
                        arr[j] = '2';
                    }
                    sum += (int)Char.GetNumericValue(arr[j]);
                }
                gpa = sum / 3;
            return Math.Round(gpa,2);                  
        }

        public static void DoBlock()
        {
            StudentStruct.Student[] studs = ReadInfo();
            runMenu(studs);

        }
    }
}