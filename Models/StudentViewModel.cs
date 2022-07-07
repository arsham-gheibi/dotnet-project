using System.ComponentModel.DataAnnotations;
namespace app.Models
{
    public class StudentViewModel
    {
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "شماره دانشجویی")]
        [Range(1000, 9999, ErrorMessage = "شماره دانشجویی چهار رقمی است!")]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "نام خانوادگی")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "شهر محل تولد")]
        public string? City { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "معدل کل")]
        [Range(0, 20, ErrorMessage = "یک عدد بین صفر تا بیست وارد کنید")]
        public float GPA { get; set; }

        //[Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "دانشکده")]
        public byte? ClgID { get; set; }

        public string? ImageName { get; set; }

        [Display(Name = "تصویر")]
        public IFormFile? Image { get; set; }
    }
}
