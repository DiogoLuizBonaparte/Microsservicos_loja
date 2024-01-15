
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base
{
    [Table("product")]
    public class BaseEntity
    {
        [Key]
        private long id;

        
    }
}
