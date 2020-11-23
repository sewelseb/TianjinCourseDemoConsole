using System;
using DataAccessLayer;

namespace BusinessLayer
{
    public class StudentManager : IStudentManager
    {
        private IStudentRepository StudentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public Student GetStudent(int studentId)
        {
            return StudentRepository.GetStudent(studentId);
        }
    }
}