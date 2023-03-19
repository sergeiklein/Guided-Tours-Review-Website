using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Review_Site.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ReviewerName { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string StarRating { get; set; }
        public virtual DestinationModel? Destinations { get; set; }
        [NotMapped]
        public string? NewDestination { get; set; }
        [ForeignKey(nameof(DestinationModel))]
        public int DestinationsId { get; set; }

        [NotMapped] //Publisher won't be mapped in the database
        public string Destination
        {
            get
            {
                if (Destinations is not null)
                {
                    return Destinations.Name;
                }
                else
                {
                    return string.Empty; //or ""
                }
            }
        }

        [NotMapped]
        public List<SelectListItem>? DestinationList { get; set; }

        //public string GetReviewAverage
        //{
        //    get
        //    {
        //        var arr = new double[] { };
        //        foreach (char r in StarRating)
        //        {
        //            arr.Append(Convert.ToDouble(r));
        //        }
        //        return Convert.ToInt32(Queryable.Average(arr.AsQueryable())).ToString();
        //    }
        //}
    }
}
