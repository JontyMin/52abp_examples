using System.Collections.Generic;
using MyPortal.Students.Dtos;

namespace MyPortal.Web.Models.Students
{
    public class EditStudentModalViewModel
    {
        public StudentDto Student { get; set; }

        public IReadOnlyList<StudentDto> Students { get; set; }

    }
}
