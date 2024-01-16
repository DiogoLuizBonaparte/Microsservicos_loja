﻿
using mgtt.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mgtt.Model
{
   
    public class Product : BaseEntity
    {
       [Column("name")]
       [Required]
       [StringLength(50)]
        public string Name { get; set; }

        [Column("descripion")]
        [Required]
        [StringLength(50)]
        public string Description { get; set; }



    }
}
