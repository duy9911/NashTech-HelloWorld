using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CoreAPI_ASM2.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI_ASM2.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentContext _context;
        public StudentService(StudentContext context)
        {
            _context = context;
        }
        public List<Student> GetList()
        {
            return _context.Student.ToList(); ;
        }

        public List<Student> Create(Student model)
        {
            _context.Student.Add(model);
            _context.SaveChanges();    
            return GetList();     
        }

        public bool Delete(int id)
        {
          _context.Student.Remove(GetSelected(id));
          _context.SaveChanges();
          return true;
        }

        public void Update(Student model)
        {
            _context.Student.Update(model);
            _context.SaveChanges();
        }

        public Student GetSelected(int id)
        {
            return _context.Student.FirstOrDefault(s => s.StudentId == id);
        }
    }
}