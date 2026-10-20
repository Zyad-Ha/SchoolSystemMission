using SchoolSystem.BL.DTOs.StudentDto;
using SchoolSystem.DAL.Models;
using SchoolSystem.DAL.Repos.StudentRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;


        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public void Add(WriteStudentDto studentDto)
        {
            var newStudent = new Student
            {
                Email = studentDto.Email,
                LaptopId = studentDto.LaptopId,
                Name = studentDto.Name
            };

            _studentRepo.Add(newStudent);
            _studentRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            _studentRepo.Delete(id);
            _studentRepo.SaveChanges();
        }

        public IEnumerable<WriteStudentDto> GetAll()
        {
            return _studentRepo.GetAll().Select(x => new WriteStudentDto
            {
                Name = x.Name,
                Email = x.Email,
                LaptopId = x.LaptopId
            }).ToList();
        }

        public void Update(int id, WriteStudentDto studentDto)
        {
            var olStudent = _studentRepo.GetById(id);
            if (olStudent == null) throw new Exception($"Student with id {id} not found");
            olStudent.Name = studentDto.Name;
            olStudent.Email = studentDto.Email;
            olStudent.LaptopId = studentDto.LaptopId;

            _studentRepo.Update(olStudent);
            _studentRepo.SaveChanges();
        }
    }
}
