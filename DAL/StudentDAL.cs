using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL:DatabaseConnection
    {
        public List<Student> SelectAllStudent()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("select * from student", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string studentName = reader.GetString(1);
                string classID = reader.GetString(2);
                students.Add(new Student(studentID, studentName, classID));
            }
            reader.Close();
            CloseConnection();
            return students;
        }
        public bool InsertStudent(Student st)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into Student values ('{st.StudentID}','{st.Name}','{st.ClassID}')";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool UpdateStudent(Student st)
        {
            try
            {
                OpenConnection();
                string sql = $"update student set name='{st.Name}',classID='{st.ClassID}' " +
                    $"where studentID='{st.StudentID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool DeleteStudent(string studentID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from student where studentID='{studentID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
