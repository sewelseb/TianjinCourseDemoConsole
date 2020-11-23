using System.Linq;
using BusinessLayer;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;


namespace TianjinDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IClassManager, ClassManager>()
                .AddSingleton<IStudentManager, StudentManager>()
                .AddSingleton<IStudentRepository, StudentRepository>()
                .BuildServiceProvider();

            var myClassRoom = serviceProvider.GetService<IClassManager>();
            var students = myClassRoom.GetClassRoomStudents(1);
            students.First().Study();
        }
    }
}
