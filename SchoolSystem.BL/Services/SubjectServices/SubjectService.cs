using SchoolSystem.BL.DTOs.SubjectDto;
using SchoolSystem.DAL.Data;
using SchoolSystem.DAL.Models;
using SchoolSystem.DAL.Repos.SubjectRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services.SubjectServices
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepo _subjectRepo;
        public SubjectService(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }
        public void Add(WriteSubjectDto writeSubjectDto)
        {
            var newSubject = new Subject
            {
                Description = writeSubjectDto.Description,
                Name = writeSubjectDto.Name
            };
            _subjectRepo.Add(newSubject);
            _subjectRepo.SaveChanges();
        }
    }
}
