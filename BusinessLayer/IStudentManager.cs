using System.Collections.Generic;
using System.Text;
using DataAccessLayer;

namespace BusinessLayer
{
    public interface IStudentManager
    {
        Student GetStudent(int studentId);
    }
}
