using System.ComponentModel.DataAnnotations;

namespace ticaretaspcore.Models
{
    public class Admin
    {
        [Key]
        public int admin_Id { get; set; }
        public string  users { get; set; }
        public string pass { get; set; }
        public int Auth { get; set; }
    }
}
