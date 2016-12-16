using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using MIS_Project.Pages.Entities;

namespace MIS_Project.Pages.Handlers
{
    public class DatabaseHandler
    {
        private static DatabaseHandler _instance;
        public static DatabaseHandler Instance => _instance ?? (_instance = new DatabaseHandler());
        public DataContext Con;
        public void InitConnection()
        {
            var connString = Resources.LocalizedText.DBConnection;
            var sqlCon= new SqlConnection(connString);
            Con = new DataContext(sqlCon);
        }
        private DatabaseHandler()
        {
            if (Con == null) InitConnection();
        }
    }
}