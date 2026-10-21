using Microsoft.EntityFrameworkCore;
using SchoolSystem.DAL.Data;
using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Repos.StudentRepos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly Context _context;
        public StudentRepo(Context context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
        }

        public void Delete(int id)
        {
            _context.Students.Remove(GetById(id));
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.Include(x => x.Teachers)
                .ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);  
        }
    }
}
