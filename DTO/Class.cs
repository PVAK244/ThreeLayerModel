
namespace DTO
{
    public class Class
    {
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public int Year { get; set; }

        public Class(string classID, string className, int year)
        {
            ClassID = classID;
            ClassName = className;
            Year = year;
        }
    }
}
