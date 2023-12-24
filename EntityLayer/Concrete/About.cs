using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Surname { get; set; }
        [StringLength(1000)]
        public string Content1 { get; set; }
        [StringLength(1000)]
        public string Content2 { get; set; }
        [StringLength(200)]
        public string Image1 { get; set; }
        [StringLength(200)]
        public string Image2 { get; set; }
    }
}
