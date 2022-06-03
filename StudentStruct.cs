using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labas_3
{
    class StudentStruct
    {
        public struct Student
        {
            public string surName;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;

            public Student(string DataLines)
            {
                string[] array = DataLines.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                surName = array[0];
                firstName = array[1];
                patronymic = array[2];
                sex = char.Parse(array[3]);
                dateOfBirth = array[4];
                mathematicsMark = char.Parse(array[5]);
                physicsMark = char.Parse(array[6]);
                informaticsMark = char.Parse(array[7]);
                scholarship = int.Parse(array[8]);
            }
        }
    }
}