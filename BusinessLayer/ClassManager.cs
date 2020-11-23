using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClassManager : IClassManager
    {
        private readonly IStudentRepository studentRepository;

        public ClassManager(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public List<Student> GetClassRoomStudents(int classRoomId)
        {
            Console.WriteLine("GetClassRoomStudents is called");

            var student = studentRepository.GetStudent(10);
            return new List<Student>()
            {
                student
            };
        }
    }
}