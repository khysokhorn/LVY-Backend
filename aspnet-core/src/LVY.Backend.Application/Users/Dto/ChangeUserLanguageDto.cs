using System.ComponentModel.DataAnnotations;

namespace LVY.Backend.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}