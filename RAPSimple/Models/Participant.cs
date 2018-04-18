using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RAPSimple.Models
{
    public class Participant
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("LastName")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
  
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "Имя")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
 //       [Required]
 //       [StringLength(50)]
        [Display(Name = "Подробнее")]
        [Column("Details")]
        [DataType(DataType.MultilineText)]
        public string Details { get; set; }

  //      [Required]
        [StringLength(50)]
        [Column("MobilePhone")]
        [Display(Name = "Мобильный телефон")]
        public string MobilePhone { get; set; }

   //     [Required]
        [StringLength(50)]
        [Column("Email")]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        public ICollection<File> Files { get; set; }
        //public virtual ICollection<File> Files { get; set; }
        //        public virtual ICollection<FilePath> FilePaths { get; set; }

    }
}