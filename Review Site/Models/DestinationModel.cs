using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Review_Site.Models
{
    public class DestinationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int TourDuration { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageList { get; set; }
        public virtual IEnumerable<ReviewModel>? Reviews { get; set; }
    }
}




