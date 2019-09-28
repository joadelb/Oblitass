
namespace Matthew.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum Wishes
    {
        Jarana,
        Jugar,
        Jengibre

    }
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }

        [Required]
        [Display(Description ="Nombre Completo")]
        public string NickName { get; set; }
        [Required]
        public Wishes Wish { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Display(Description ="Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

    }
}