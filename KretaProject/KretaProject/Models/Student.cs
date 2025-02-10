namespace KretaProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsWoman { get; set; }=false;
        public DateTime BirthDay { get; set; } =DateTime.MinValue;
        public int SchoolClassId { get; set; } = -1;
    }
}
