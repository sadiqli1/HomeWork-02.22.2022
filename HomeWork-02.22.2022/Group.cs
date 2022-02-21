using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_02._22._2022
{
    public class Group
    {
        public string No;
        private static int _limit = 10;
        private int index = 0;
        private Student[] Students ;

        public Group(string no)
        {
            No = no;
            Students = new Student[_limit];
        }


        public void AddStudent(Student student)
        {
            if (index>=_limit)
            {
                return;
            }
            else
            {
                Students[index] = student;
                index = ++index;
            }
        }

        public Student[] GetStudents()
        {
            return Students;
        }
        public int CheckIndex()
        {
            return index;
        }
    }
}
