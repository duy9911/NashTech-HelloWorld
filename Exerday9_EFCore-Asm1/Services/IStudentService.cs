using System.Collections.Generic;
using EF_ASPCORE.Models;
namespace EF_ASPCORE.Services
{
     public interface IStudentService
    {
        List<Student> GetList();
        Student Create(Student model);
        bool Delete(int id);
        Student Update(Student model);

    }
}