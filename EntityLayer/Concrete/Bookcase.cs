using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Bookcase
{
    [Key]
    public int BookID { get; set; }
    public string BookNane { get; set; }
    public string Bookauthor { get; set; }
    public string BookTour { get; set; }
    public string BookPublishingHouse { get; set; }
    
}