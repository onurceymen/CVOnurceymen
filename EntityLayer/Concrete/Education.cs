using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Education
{
    [Key]
    public int EducationID { get; set; }
    public string EducationTitle { get; set; }
    public string EducationTitle1 { get; set; }
    public string EducationTitle2 { get; set; }
    public string EducationGPA { get; set; }
    public DateTime EducationDate { get; set; }
}