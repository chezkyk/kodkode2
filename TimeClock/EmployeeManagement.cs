using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    internal class EmployeeManagement
    {
        private static string _loginSQL = "declare \r\n@fullName varchar(40) = '',\r\n@code int,\r\n@answer varchar(250);\r\n\r\n\r\nif exists (select * from Employees where IdNumber=@id )\r\n\tbegin\r\n\t\t\t\t\t\r\n\t\tselect @code = (select EmployeesId from Employees where IdNumber=@id);\r\n\tend\r\nelse\r\n\tbegin\r\n\t\t--insert the variables into Employees--\r\n\t\tinsert into Employees values(@fullName,@id);\r\n\t\tselect @code = @@IDENTITY;\r\n\tend\r\n--\r\n\r\nif exists (select * from Passwords where UserNamePasswords=@code )\r\n\tbegin\r\n\t\tif exists (select PasswordNumber from Passwords where UserNamePasswords=@code \r\n\t\t\t\t\t\tAND PasswordNumber=@password \r\n\t\t\t\t\t\tAND IsActive = 1)\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tif exists (select PasswordNumber from Passwords where UserNamePasswords=@code \r\n\t\t\t\t\t\t\t\t\t\tAND PasswordNumber=@password \r\n\t\t\t\t\t\t\t\t\t\tAND IsActive = 1 AND ExpirationDate >= getdate())\r\n\t\t\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\t\t\t\tif  exists (select * from TimeClock where UserNameTimeClock = @code\r\n\t\t\t\t\t\t\t\t\t\t\tAND ExitTime is  null)\r\n\t\t\t\t\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tupdate TimeClock set ExitTime = GETDATE()\r\n\t\t\t\t\t\t\t\t\t\t\t\t\twhere UserNameTimeClock = @code\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tAND ExitTime is  null\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tselect @answer = 'Exit time: ' + CONVERT(nvarchar, GETDATE(),121) +' tnx for exit';\r\n\t\t\t\t\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tinsert into TimeClock values (GETDATE(),null, @code)\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tselect @answer = 'Entry time: ' + CONVERT(nvarchar, GETDATE(),121)+' tnx for rntry';\r\n\t\t\t\t\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\t\tupdate Passwords set IsActive=0\r\n\t\t\t\t\t\t\t\t\twhere UserNamePasswords=@Code and PasswordNumber = @password;\r\n\t\t\t\t\t\t\t\t\tselect @answer = 'password is expired. its time to update it'\r\n\t\t\t\t\t\t\t\t\tinsert into Passwords  values(@password, dateadd(day, 180, getdate()), @Code, 1)\r\n\t\t\t\t\t\t\t\t\tselect @answer = 'password is expired. its time to update it'\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\tend\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @answer = 'Incorrect password, please enter a correct password.';\r\n\t\t\tend\t\t\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tinsert into Passwords values (@password , DATEADD(day,180,getdate()),@code,1)\r\n\t\tselect @answer = 'you have created a new password!\r\n\r\n';\r\n\tend\r\nselect @answer";
        private static string _changePasswordSQL = "declare\r\n@code int,\r\n@answer varchar(250);\r\n\r\nif exists (select * from Employees where IdNumber=@id )\r\n\tbegin\r\n\t\tselect @code = (select EmployeesId from Employees where IdNumber=@id);\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect @answer = 'id do not exists'\r\n\tend\r\n\t\t\t\t\t\r\nif exists (select * from Employees where IdNumber=@id )\r\n\tbegin\r\n\t\tif exists (select PasswordNumber from Passwords where PasswordNumber=@oldPass AND UserNamePasswords=@code  and IsActive=1)\r\n\t\t\tbegin\r\n\t\t\t\tif not exists(select PasswordNumber from Passwords where PasswordNumber=@newPass AND UserNamePasswords=@code)\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tif(@newPass=@confPass)\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tupdate Passwords \r\n\t\t\t\t\t\t\t\tset IsActive=0\r\n\t\t\t\t\t\t\t\twhere UserNamePasswords=@code and PasswordNumber=@oldPass\r\n\t\t\t\t\t\t\t\tinsert into Passwords values(@newPass , DATEADD(day,180,getdate()),@code,1)\r\n\t\t\t\t\t\t\t\tselect @answer = 'password was updatet'\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tselect @answer = 'The passwords are not equal'\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\tend\r\n\t\t\t\t\telse\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tselect @answer = 'you already used this password'\r\n\t\t\t\t\t\tend\r\n\t\t\tend\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @answer = 'password incorrect'\r\n\t\t\tend\r\n\t\t\t\r\n\tend\r\n\r\nselect @answer";
        private static string _ShowWorkingHoursSQL = "";
        public static string Login(string id, string password)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@password" };
            string[] values = { id, password };
            string answer = DBConnection.runSQL(_loginSQL, parameters, values);
            // 3. Return response
            return answer;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id","@oldPass", "@newPass", "@confPass"};
            string[] values = { id, oldPass, newPass, confirmPass };
            string answer = DBConnection.runSQL(_changePasswordSQL, parameters, values);
            // 3. Return response
            return answer;
        }
        public static string ShowWorkingHours(string id, string password)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@password" };
            string[] values = { id, password };
            string answer = DBConnection.runSQL(_loginSQL, parameters, values);
            // 3. Return response
            return answer;
        }



















    }
}
