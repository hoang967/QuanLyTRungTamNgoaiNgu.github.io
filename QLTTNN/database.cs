using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTNN
{
    internal class database
    {
        private static string strConnection = @"Data Source=TTGH\TTGH967;Initial Catalog=QLTTNN;Integrated Security=True";

        public static void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            SqlConnection sqlCon = new SqlConnection(strConnection);

            sqlCon.Open();

            SqlCommand command = new SqlCommand(query, sqlCon);

            foreach (string key in parameters.Keys)
            {
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            }

            command.ExecuteNonQuery();
            sqlCon.Close();
        }

        public static DataTable ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            SqlConnection sqlCon = new SqlConnection(strConnection);

            sqlCon.Open();

            SqlCommand Command = new SqlCommand(query, sqlCon);

            foreach (string key in parameters.Keys)
            {
                Command.Parameters.Add(new SqlParameter(key, parameters[key]));
            }
            //Tạo ra 1 bộ nạp dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            //Bước 4: Tạo ra 1 bảng dữ liệu và đổ dữ liệu vào
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
}
