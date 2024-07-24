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

        public static List<string> GetGuestes()
        {
            string sql = "select * from Guestes";
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql);

            List<string> guestes = new List<string>();
 
            for (int i = 0; reader.Read(); i++)
            {

                guestes.Add(reader.GetString(1));
            }
            reader.Close();
            return guestes;
        }
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
                return GetGuestes();
            }
            string sql = "select * from Guestes where GuestName like '%' + @guestCategory + '%'";

            string[] parameters = { "@guestCategory" };
            string[] values = { name };
            SqlDataReader reader = DBConnection.RunSQLAllResults(sql, parameters, values);


            List<string> guestes = new List<string>();
            
            while(reader.Read())
            {
                guestes.Add(reader.GetString(1));
                
            }
            reader.Close();
            return guestes;
        }

        public static void AddName(string guestName)
        {
            string sql = "if not exists(select GuestName from Guestes where @guestName=GuestName)\r\nbegin\r\ninsert into Guestes values(@guestName)\r\nend";
            string[] parameters = { "@guestName" };
            string[] values = { guestName };
            DBConnection.RunSqlNoReturn(sql, parameters, values);
        }
        public static void DeleteName(string guestName)
        {
            string aql = "DELETE FROM Guestes WHERE guestName = @guestName";
            string[] parameters = { "@guestName" };
            string[] values = { guestName };
            DBConnection.RunSqlNoReturn(aql, parameters, values);
        }
        public static DataTable DisplayMyDishes(string guestes, string category)
        {
            string sql = "select  count(Dishes.DishName) as Number_of_dishes, Dishes.DishName AS Name_of_dishes\r\nfrom Dishes\r\njoin Categories on Categories.CategoriesCode = Dishes.CategoriesCode\r\njoin Guestes on Guestes.GuestesCode = Dishes.GuestesCode\r\nwhere @Category = Categories.CategoryName and @guestes = Guestes.GuestName\r\ngroup by Dishes.DishName;";
            string[] parameters = { "@Category", "@guestes" };
            string[] values = { category , guestes };
            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql, parameters, values);
            return dataTable;
        }
        public static DataTable DisplayDishes(string guestes, string category)
        {
            string sql = "select  count(Dishes.DishName) as Number_of_dishes, Dishes.DishName AS Name_of_dishes\r\nfrom Dishes\r\njoin Categories on Categories.CategoriesCode = Dishes.CategoriesCode\r\njoin Guestes on Guestes.GuestesCode = Dishes.GuestesCode\r\nwhere @Category = Categories.CategoryName and @guestes != Guestes.GuestName \r\ngroup by Dishes.DishName;";
            string[] parameters = { "@Category", "@guestes" };
            string[] values = { category, guestes };
            DataTable dataTable = DBConnection.RunSQLAllTableResult(sql, parameters, values);
            return dataTable;
        }
        public static void AddDish(string category, string guesteName , string dishName)
        {
            string sql = "declare @categoriesCode int, @guestesCode int\r\n\r\nselect @categoriesCode = (select CategoriesCode from Categories where @Category = CategoryName)\r\nselect @guestesCode = (select GuestesCode from Guestes where @guestes = GuestName)\r\n\r\nif(@categoriesCode is not null and @guestesCode is not null)\r\n\tbegin\r\n\t\tinsert into Dishes values(@dishName, @categoriesCode,@guestesCode)\r\n\tend";
            string[] parameters = { "@Category", "@guestes", "@dishName"};
            string[] values = { category, guesteName, dishName };
            DBConnection.RunSqlNoReturn(sql, parameters, values);


        }
    }
}




