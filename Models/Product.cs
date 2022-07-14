using System.ComponentModel.DataAnnotations;
namespace app.Models
{
    public class Product
    {
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "کد محصول")]
        [Range(10000, 99999, ErrorMessage = "کد محصول پنج رقمی است!")]
        public int ProductCode { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "نام محصول")]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "قیمت محصول")]
        public float Price { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Display(Name = "توضیحات محصول")]
        public string? Description { get; set; }

        public string? ImageName { get; set; }
    }
}
