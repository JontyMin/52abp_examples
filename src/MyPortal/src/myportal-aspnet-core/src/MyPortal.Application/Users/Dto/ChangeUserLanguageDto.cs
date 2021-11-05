using System.ComponentModel.DataAnnotations;

namespace MyPortal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}