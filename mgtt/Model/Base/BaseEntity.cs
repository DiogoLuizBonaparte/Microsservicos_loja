using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mgtt.Model.Base
{
    [Table("product")]
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public long id {  get; set; }
    }
}
