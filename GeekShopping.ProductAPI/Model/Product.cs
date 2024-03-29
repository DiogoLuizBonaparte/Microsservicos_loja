﻿
using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace GeekShopping.ProductAPI.Model
{
    public class Product : BaseEntity
    {
       
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set;}

        [Column("price")]
        [Required]
        [Range(1,10000)]
        public decimal price { get; set; }

        [Column("description")]
        [StringLength(150)]
        public string Description { get; set; }

        [Column("categoru_name")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public String ImageURL { get; set; }

    }
}
