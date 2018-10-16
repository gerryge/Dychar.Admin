using System.ComponentModel.DataAnnotations;

namespace Dacnsoft.Admin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}