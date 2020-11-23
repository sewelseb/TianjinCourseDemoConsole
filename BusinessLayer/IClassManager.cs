using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLayer
{
    public interface IClassManager
    {
        List<Student> GetClassRoomStudents(int classRoomId);
    }
}