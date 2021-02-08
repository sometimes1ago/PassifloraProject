using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PassifloraProject
{
    /// <summary>
    /// Класс для работы с базой данных
    /// </summary>
    class DB
    {
        private static string ConnStr = @"Data Source=localhost; Initial Catalog = Цветочный_Салон; Integrated Security=true";
        public static DataSet ds;
        public static string AuthorizedUser;
        private static SqlDataAdapter sqlad;
        private static SqlCommand comnd;

        /// <summary>
        /// Метод устанвливающий какой именно пользователь авторизовался
        /// </summary>
        /// <param name="UserLogin">Логин пользователя</param>
        public static void SetAuthorizedUser(string UserLogin)
        {
            AuthorizedUser = UserLogin;
        }

        /// <summary>
        /// Метод выполняющий запрос к базе данных
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        public static void Execute(string QueryString)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();
                sqlad = new SqlDataAdapter(QueryString, ConnStr);
                ds = new DataSet();
                comnd = new SqlCommand(QueryString, sqlconn);
                comnd.ExecuteNonQuery();
                sqlconn.Close();
            }
        }

        /// <summary>
        /// Модифицированный метод выполнения запроса к БД, возвращающий результат в виде таблицы
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        /// <returns>Результат выполнения запроса</returns>
        public static object SearchValuesQuery(string QueryString)
        {
            Execute(QueryString);
            sqlad.Fill(ds);
            return ds.Tables[0];
        }


    }
}
