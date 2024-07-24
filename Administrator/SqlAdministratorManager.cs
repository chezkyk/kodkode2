using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator
{
    internal class SqlAdministratorManager
    {
        
        public static void AddCourse(string courseName, string startDate, int daysInWeek, string studyHours, float price)
        {
            string aql = "if (@courseName is not null and @startDate is not null and @daysInWeek is not null and @studyHours is not null and @price is not null)\r\n\tbegin\r\n\t\tinsert into Course values(@courseName,@startDate,@daysInWeek,@studyHours,@price)\r\n\tend";
            string[] parameters = { "@courseName", "@startDate", "@daysInWeek", "@studyHours", "@price" };
            string[] values = { courseName, startDate , daysInWeek.ToString(), studyHours , price.ToString()};
            DBConnection.RunSqlNoReturn(aql, parameters, values);
        }
        public static DataTable ShowInterested()
        {
            string sql = "select * from Interested";

            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql);
            return dataTable;
        }
        public static DataTable DisplayAllCourses()
        {
            string sql = "select Student.StudentCode,Student.StudentName,Course.CourseCode,Course.CourseName\r\nfrom CourseAndStudent\r\njoin Course ON CourseAndStudent.CourseCode = Course.CourseCode\r\njoin Student ON CourseAndStudent.StudentCode = Student.StudentCode";

            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql);
            return dataTable;
        }
    }
}
