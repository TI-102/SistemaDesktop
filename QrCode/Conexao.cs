using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace QrCode
{
    class Conexao
    {
        private static string conString = "Server=localhost;Port=3306;Database=dbrestaurant;Uid=root;Pwd=''";
        private static MySqlConnection con = null;
        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(conString);
            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                con = null;
            }
            return con;
        }

        public static void fecharConexao()
        {
            if(con != null)
            {
                con.Close();
            }
        }
    }
}
