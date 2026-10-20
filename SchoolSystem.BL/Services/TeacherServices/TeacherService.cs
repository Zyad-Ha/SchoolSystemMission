using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolSystem.BL.DTOs.TeacherDto;
using SchoolSystem.DAL.Models;
using SchoolSystem.DAL.Repos.TeacherRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.BL.Services.TeacherServices
{
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherRepo _teacherRepo;
        public TeacherService(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        public void Add(WriteTeacherDto writeTeacherDto)
        {
            var newTeacher = new Teacher
            {
                Name = writeTeacherDto.Name,
                Email = writeTeacherDto.Email,
                Phone = writeTeacherDto.Phone,
                SubjectId = writeTeacherDto.SubjectId
            };
            _teacherRepo.Add(newTeacher);
            _teacherRepo.SaveChanges();
        }

        public WriteTeacherDto GetById(int id)
        {
            var idExisting = _teacherRepo.GetById(id);
            if (idExisting == null) throw new Exception($"Teacher with id {id} not found");

            return new WriteTeacherDto
            {
                Name = idExisting.Name,
                Email = idExisting.Email,
                Phone = idExisting.Phone,
                SubjectId = idExisting.SubjectId
            };
        }
    }
}
