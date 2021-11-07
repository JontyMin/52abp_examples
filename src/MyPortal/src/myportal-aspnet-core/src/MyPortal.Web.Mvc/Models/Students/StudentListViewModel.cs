using System.Collections.Generic;
using MyPortal.Students.Dtos;

namespace MyPortal.Web.Models.Students
{
    public class StudentListViewModel
    {
        public IReadOnlyList<StudentDto> Students { get; set; }
    }
}
