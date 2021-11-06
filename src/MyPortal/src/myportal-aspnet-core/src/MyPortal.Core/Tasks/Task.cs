using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace MyPortal.Tasks
{
    [Table("Abp_Tasks")]
    public class Task : Entity,IHasCreationTime, IEntity<long>
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024;
        public DateTime CreationTime { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public TaskState State { get; set; }

        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public Task(string title,string description=null):this()
        {
            Title = title;
            Description = description;
        }
    }
}
