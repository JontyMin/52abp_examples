using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MyPortal.Students.Dtos
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto:EntityDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(Student.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(Student.MaxAddressLength)]
        public string Address { get; set; }

    }
}
