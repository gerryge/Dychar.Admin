using System.ComponentModel.DataAnnotations;

namespace Dychar.Admin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}