using System.Data.SqlClient;
using System.Data;

namespace Games_Platform
{
    static class DataBase
    {
        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I69IR4N\SQLEXPRESS;Initial Catalog=Game_Platform;Integrated Security=True");

        private static void OpenConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        private static void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        private static SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

        public static DataTable SQLDataSelect(string queryString)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = new SqlCommand(queryString, GetSqlConnection());
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static void SQLDataInsert(string queryString, string inserted)
        {
            SqlCommand command = new SqlCommand(queryString, GetSqlConnection());

            OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show($"New {inserted} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseConnection();
            }
        }

        public static void SQLDataDelete(string queryString, string deleted)
        {
            SqlCommand command = new SqlCommand(queryString, GetSqlConnection());

            OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show($"{deleted} deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseConnection();
            }
        }
    }
}
