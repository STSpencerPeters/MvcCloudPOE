using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCloudPOE.Models
{
    public class ContactUs
    {
        public string? Name { get; set; }

        public int Number {  get; set; }
        public string? Address { get; set; }

        [Column(TypeName = "decimal(18, 2)")]

        public string ImageUrl { get; set; }

    }
}
