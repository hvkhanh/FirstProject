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
        public int PostID { set; get; }
        [Key]
        [Required]
        public int TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}
