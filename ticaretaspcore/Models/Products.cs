using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticaretaspcore.Models
{
    public class Products
    {
        [Key]
        public int product_Id { get; set; }
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurun")]
        [Display(Name = "Ürün  Adını ")]
        public string product_Name { get; set; }
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurun")]
        [Display(Name = "Ürün Fiyatı")]
        public int product_Price { get; set; }
        [Display(Name = "Resim ")]
        public string product_Picture { get; set; }
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurun")]
        [Display(Name = "Stok ")]
        public int product_Stock { get; set; }
        [Display(Name = "Kategori ")]
        public int category_Id { get; set; }

        [NotMapped]
        public IFormFile MyImage { get; set; }

       public virtual Categories Categories { get; set; }

    }
}
