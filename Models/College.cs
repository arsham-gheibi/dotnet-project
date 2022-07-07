namespace app.Models
{
    public class College
    {
        public byte ClgID { get; set; }
        public string? Clgname { get; set; }
        public string? City { get; set; }
        public string? Pname { get; set; }

        //Navigation Property
        public ICollection<Student>? Students { get; set; }
    }
}
