
namespace DTO
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string ClassID { get; set; }

        public Student(string studentID, string name, string classID)
        {
            StudentID = studentID;
            Name = name;
            ClassID = classID;
        }
    }
}
