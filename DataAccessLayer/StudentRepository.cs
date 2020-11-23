using System;

namespace DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
        public Student GetStudent(int studentId)
        {
            Console.WriteLine("GetStudent is called");
            return new Student()
            {
                age = 30,
                name = "Sébastien"
            };
        }
    }
}