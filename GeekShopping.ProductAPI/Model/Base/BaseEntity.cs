using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        public long id;
    }
}
