using System.ComponentModel.DataAnnotations;

namespace TopSpeedWeb.Models
{
    public class BrandModel
    {
        [Key]
       
        public Guid Id { get; set; }

        public string Name { get; set; } 

        public int EstablishedYear { get; set; }

        public String BrandLogo { get; set; }
    }
}
