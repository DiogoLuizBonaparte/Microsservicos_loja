using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Geek_Product.Data.ValueObjects
{
    public class ProductVO
    {
       public long Id { get; set; }

        public string Name { get; set; }
       
        public string Description { get; set; }
    }
}
