using System;

namespace HomeWork_02._22._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("P127");
            Student student = new Student("isa", "sadiqli");
            group.AddStudent(student);
             
            
         

            var array = group.GetStudents();
            Console.WriteLine(array);
            for(int i = 0; i < group.CheckIndex();i++)
            {
                Console.WriteLine(array[i].Name + array[i].Surname);
            }

            
             


        }
    }
}
