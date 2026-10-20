using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Repos.SubjectRepos
{
    public interface ISubjectRepo
    {
        void Add(Subject subject);
        int SaveChanges();
    }
}
