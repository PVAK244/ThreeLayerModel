using DTO;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL stdDAL = new StudentDAL();
        public List<Student> SelectAllStudent()
        {
            
            return stdDAL.SelectAllStudent();
        }
        public bool InsertStudent(Student st)
        {
            return stdDAL.InsertStudent(st);
        }
        public bool UpdateStudent(Student st)
        {
            return stdDAL.UpdateStudent(st);
        }
        public bool DeleteStudent(string studentID)
        {
            return stdDAL.DeleteStudent(studentID);
        }
    }
}
