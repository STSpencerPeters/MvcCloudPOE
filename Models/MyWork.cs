using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCloudPOE.Models
{
    public class MyWork
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Type { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public double Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
