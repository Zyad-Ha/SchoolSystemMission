using SchoolSystem.DAL.Data;
using SchoolSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.DAL.Repos.SubjectRepos
{
    public class SubjectRepo : ISubjectRepo
    {
        private readonly Context _context;
        public SubjectRepo(Context context)
        {
            _context = context;
        }
        public void Add(Subject subject)
        {
            _context.Subjects.Add(subject);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
