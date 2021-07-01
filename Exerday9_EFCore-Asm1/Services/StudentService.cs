using System.Collections.Generic;
using System.Linq;
using EF_ASPCORE.Models;

namespace EF_ASPCORE.Services
{
    public class StudentService : IStudentService
    {
        public StudentContext _context;
        public StudentService(StudentContext context)
        {
            _context = context;
        }

        public Student GetSelected(int id)
        {
            return _context.Student.FirstOrDefault(s => s.StudentId == id);
        }

        public Student Create(Student model)
        {
  
                var id = _context.Student.Max(a => a.StudentId);
                id += 1;
                model.StudentId = id;
                _context.Student.Add(model);
                _context.SaveChanges();
                return GetSelected(model.StudentId);
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetList()
        {
            throw new System.NotImplementedException();
        }

        public Student Update(Student model)
        {
            throw new System.NotImplementedException();
        }
    }
}