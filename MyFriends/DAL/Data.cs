namespace MyFriends.DAL
{
    public class Data
    {
        string ConnectionString = "server = YECHEZKEL-KOFMA\\SQLSERVER;initial catalog=MyFriends; user id=sa; password=1234;TrustServerCertificate=Yes";
        private static Data _data;
        private DBContext _layer;

        private Data()
        {
            _layer = new DBContext(ConnectionString);
        }
        public static DBContext Get
        {
            get
            {
                if (_data == null)
                {
                    _data = new Data();
                }
                return _data._layer;

            }
        }
    }
}
