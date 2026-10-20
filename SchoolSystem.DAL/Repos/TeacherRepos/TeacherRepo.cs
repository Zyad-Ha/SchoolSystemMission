using SchoolSystem.DAL.Data;
using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Repos.TeacherRepos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly Context _context;
        public TeacherRepo(Context context)
        {
            _context = context;
        }
        public void Add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }

        public Teacher GetById(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.Id == id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
