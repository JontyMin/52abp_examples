using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MyPortal.Students
{
    /// <summary>
    /// 学生表
    /// </summary>
    [Table("Abp_Student")]
    public class Student : Entity
    {
        /// <summary>
        /// 名称最大长度
        /// </summary>
        public const int MaxNameLength = 50;

        /// <summary>
        /// 地址最大长度
        /// </summary>
        public const int MaxAddressLength = 200;

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(MaxAddressLength)]
        public string Address { get; set; }

    }
}
