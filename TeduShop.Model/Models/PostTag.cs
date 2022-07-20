using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Required]
        [Column(Order =1)]
        public int PostID { set; get; }
        [Key]
        [Required]
        [Column(TypeName ="varchar", Order =2)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}
