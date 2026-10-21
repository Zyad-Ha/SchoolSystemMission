using SchoolSystem.BL.DTOs.StudentDto;
using SchoolSystem.BL.DTOs.TeacherDto;
using SchoolSystem.DAL.Models;
using SchoolSystem.DAL.Repos.StudentRepos;
using SchoolSystem.DAL.Repos.TeacherRepos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;
        private readonly ITeacherRepo _teacherRepo;

        public StudentService(IStudentRepo studentRepo, ITeacherRepo teacherRepo)
        {
            _studentRepo = studentRepo;
            _teacherRepo = teacherRepo;
        }
        public void Add(WriteStudentDto studentDto)
        {
            var newListIds = new List<Teacher>();
            foreach (var item in studentDto.TeacherIds)
            {
                var existTeacher = _teacherRepo.GetById(item);
                if (existTeacher is null) throw new Exception("The Teacher you try do add is not found.");
                newListIds.Add(existTeacher);
            }
            var newStudent = new Student
            {
                Email = studentDto.Email,
                LaptopId = studentDto.LaptopId,
                Name = studentDto.Name,
                Teachers = newListIds
            };

            _studentRepo.Add(newStudent);
            _studentRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var exist = _studentRepo.GetById(id);
            if (exist is null)
                throw new Exception($"Student with id {id} not found");


            _studentRepo.Delete(id);
            _studentRepo.SaveChanges();
        }

        public IEnumerable<ReadStudentDto> GetAll()
        {
            return _studentRepo.GetAll()
                .Select(x => new ReadStudentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email,
                    LaptopId = x.LaptopId,
                    Teachers = x.Teachers.Select(t => new ReadTeacherDto
                    {
                        Id = t.Id,
                        Name = t.Name,
                        Email = t.Email,
                        Phone = t.Phone,
                        SubjectId = t.SubjectId,
                    }).ToList()
                }).ToList();
        }

        public void Update(int id, UpdateStudentDto studentDto)
        {
            var oldStudent = _studentRepo.GetById(id);
            if (oldStudent == null) throw new Exception($"Student with id {id} not found");
            oldStudent.Name = studentDto.Name;
            oldStudent.Email = studentDto.Email;
            oldStudent.LaptopId = studentDto.LaptopId;

            _studentRepo.Update(oldStudent);
            _studentRepo.SaveChanges();
        }
    }
}
