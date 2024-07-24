using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    internal class SqlStudentManager
    {
        public static List<string> GetStudents()
        {
            string sql = "select * from Student";
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql);

            List<string> names = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {

                names.Add(reader.GetString(1));
            }
            reader.Close();
            return names;
        }
        public static List<string> SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return GetStudents();
            }
            string sql = "select * from Student where StudentName like '%' +  @StudentName + '%'";

            string[] parameters = { "@StudentName" };
            string[] values = { name };
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql, parameters, values);


            List<string> names = new List<string>();

            while (reader.Read())
            {
                names.Add(reader.GetString(1));

            }
            reader.Close();
            return names;
        }
        public static DataTable DisplayCourses()
        {
            string sql = "select Course.CourseCode,Course.CourseName,Course.StartDate,Course.DaysInWeek,Course.StudyHours,Course.Price,\r\nSubjects.NumberOfHours,Lecturer.LecturerName\r\nfrom Course\r\njoin Subjects ON Subjects.subjectsCode = Course.CourseCode\r\njoin Lecturer ON Lecturer.LecturerCode = Subjects.subjectsCode";

            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql);
            return dataTable;
        }
        //
        public static List<string> GetCoureseNames()
        {
            string sql = "select CourseCode,CourseName from Course";
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql);

            List<string> names = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {

                names.Add(reader.GetString(1));
            }
            reader.Close();
            return names;
        }
        public static List<string> SearchByCoureseName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return GetCoureseNames();
            }
            string sql = "select CourseName from Course where CourseName like '%' +  @CourseName + '%'";

            string[] parameters = { "@CourseName" };
            string[] values = { name };
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql, parameters, values);


            List<string> names = new List<string>();

            while (reader.Read())
            {
                names.Add(reader.GetString(0));

            }
            reader.Close();
            return names;
        }
        public static void AddStudent(string studentName, int debt)
        {
            string aql = "if not exists(select StudentName from Student where @StudentName=StudentName)\r\n\tbegin\r\n\t\tinsert into Student values(@StudentName,@debt)\r\n\tend";
            string[] parameters = { "@StudentName", "@debt" };
            string[] values = { studentName, debt.ToString() };
            DBConnection.RunSqlNoReturn(aql, parameters, values);
        }

        public static DataTable DisplayMyCourses(string studentName)
        {
            string sql = "select Student.StudentName,Course.CourseCode,Course.CourseName\r\nfrom CourseAndStudent\r\njoin Course ON CourseAndStudent.CourseCode = Course.CourseCode\r\njoin Student ON CourseAndStudent.StudentCode = Student.StudentCode\r\nwhere Student.StudentName = @StudentName";
            string[] parameters = { "@StudentName" };
            string[] values = { studentName};
            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql, parameters, values);
            return dataTable;
        }

        public static string GetDebt(string studentName)
        {
            string aql = "select Debt from Student where @StudentName=StudentName";
            string[] parameters = { "@StudentName" };
            string[] values = { studentName, };
            return DBConnection.RunSQLOneResults(aql, parameters, values);
        }

        public static void UpdateDebt(string studentName, float updateDebt)
        {
            string aql = "UPDATE Student\r\nSET Debt -= @updateDebt\r\nWHERE StudentName = @StudentName\r\n";
            string[] parameters = { "@StudentName", "@updateDebt" };
            string[] values = { studentName, updateDebt.ToString() };
            DBConnection.RunSqlNoReturn(aql, parameters, values);
        }
    }
}
