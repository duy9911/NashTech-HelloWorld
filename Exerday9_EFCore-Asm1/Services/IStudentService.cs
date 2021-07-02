using System.Collections.Generic;
using CoreAPI_ASM2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI_ASM2.Services
{
    public interface IStudentService
    {
        List<Student> GetList();
        List<Student> Create(Student model);
        bool Delete(int id);
        Student GetSelected(int id);
        void Update(Student model);

    }
}