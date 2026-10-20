
using Microsoft.EntityFrameworkCore;
using SchoolSystem.BL.Services.StudentServices;
using SchoolSystem.BL.Services.SubjectServices;
using SchoolSystem.BL.Services.TeacherServices;
using SchoolSystem.DAL.Data;
using SchoolSystem.DAL.Repos.StudentRepos;
using SchoolSystem.DAL.Repos.SubjectRepos;
using SchoolSystem.DAL.Repos.TeacherRepos;

namespace SchoolSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>(x => 
            x.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

            builder.Services.AddScoped<IStudentRepo, StudentRepo>();
            builder.Services.AddScoped<IStudentService, StudentService>();

            builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();
            builder.Services.AddScoped<ISubjectService, SubjectService>();

            builder.Services.AddScoped<ITeacherRepo,TeacherRepo>();
            builder.Services.AddScoped<ITeacherService, TeacherService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
