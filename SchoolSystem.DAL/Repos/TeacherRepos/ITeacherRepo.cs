using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Repos.TeacherRepos
{
    public interface ITeacherRepo
    {
        Teacher GetById(int id);
        void Add(Teacher teacher);
        int SaveChanges();
    }
}
