using System.ComponentModel.DataAnnotations;

namespace DataAccesLayer.Models
{
    public class BaseEntity
    {
        [Key, Required]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
