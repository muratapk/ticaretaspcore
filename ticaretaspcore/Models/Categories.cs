using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ticaretaspcore.Models
{
    public class Categories
    {
        [Key]
        public int category_Id { get; set; }
        [Required(ErrorMessage ="Lütfen Bu Alanı Doldurun")]
        [Display(Name ="Kategori Adını Giriniz")]
        public string category_Name { get; set; }

        public ICollection<Products> Products { get; set; }

        //birden fazla ürün bu kategoriden değer alabilir
    }
}
