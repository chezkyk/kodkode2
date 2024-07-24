using Host;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuestsForShabbat
{
    internal class SqlShabbatManager
    {

        public static List<string> GetCategories()
        {
            string sql = "select * from Categories";
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql);

            List<string> categories = new List<string>();
 
            for (int i = 0; reader.Read(); i++)
            {

                categories.Add(reader.GetString(1));
            }
            reader.Close();
            return categories;
        }
        public static List<string> SearchByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return GetCategories();
            }
            string sql = "select * from Categories where CategoryName like '%' + @SearchCategory + '%'";

            string[] parameters = { "@SearchCategory" };
            string[] values = { name };
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql, parameters, values);


            List<string> categories = new List<string>();
            
            while(reader.Read())
            {
                categories.Add(reader.GetString(1));
                
            }
            reader.Close();
            return categories;
        }
        public static DataTable DisplayDishes(string category)
        {
            string sql = "select  count(Dishes.DishName) as Number_of_dishes, Dishes.DishName as Name_of_dishes\r\nfrom Dishes\r\njoin Categories on Categories.CategoriesCode = Dishes.CategoriesCode\r\nwhere @Category = CategoryName\r\ngroup by Dishes.DishName";
            string[] parameters = { "@Category" };
            string[] values = { category };
            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql, parameters, values);
            return dataTable;
        }

        public static void AddCategorey(string categoryName)
        {
            string aql = "if not exists(select CategoryName from Categories where @categoryName=CategoryName)\r\n\tbegin\r\n\t\tinsert into Categories values(@categoryName)\r\n\tend";
            string[] parameters = { "@categoryName" };
            string[] values = { categoryName };
            DBConnection.RunSqlNoReturn(aql, parameters, values);
        }
        public static void DeleteCategorey(string categoryName)
        {
            string aql = "DELETE FROM Categories WHERE CategoryName = @categoryName";
            string[] parameters = { "@categoryName" };
            string[] values = { categoryName };
            DBConnection.RunSqlNoReturn(aql, parameters, values);
        }




    }
}
