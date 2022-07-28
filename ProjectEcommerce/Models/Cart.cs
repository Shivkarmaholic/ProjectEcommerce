using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.Models
{
    [Table("Cart_Table")]
    public class Cart
    {
        [Key]        
        public int c_id { get; set; }
        [Required]
        public string p_id { get; set; }
        [Required]
        public string u_id { get; set; }
        
        public static string ConnectionString = "Server=DESKTOP-SQKJ3UE\\SQLEXPRESS;Database=Sample;Integrated Security=True;";

    }



}
