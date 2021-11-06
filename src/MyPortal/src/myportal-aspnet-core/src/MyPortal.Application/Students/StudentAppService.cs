using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MyPortal.Students.Dtos;

namespace MyPortal.Students
{
    public class StudentAppService: ApplicationService,IStudentAppService
    {
        private readonly IRepository<Student> _studentRepository;
        public StudentAppService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        /// <summary>
        /// 获取全部学生
        /// </summary>
        /// <returns></returns>
        public async Task<List<StudentListDto>> GetAllStudents()
        {
            var students = await _studentRepository.GetAll().ToListAsync();
            return ObjectMapper.Map<List<StudentListDto>>(students);
        }
    }
}
