﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Required]
        [Column(Order =1)]
        public int ProductID { set; get; }
        [Key]
        [Required]
        [Column(TypeName ="varchar",Order =2)]
        public string TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategories { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }

    }
}
