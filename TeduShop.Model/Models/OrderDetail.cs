﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order =1)]
        public int OrderID { set; get; }
        [Key]
        [Column(Order =2)]
        public int ProductID { set; get; }
        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }
        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategories { set; get; }
        public int Quantity { set; get; }
    }
}
