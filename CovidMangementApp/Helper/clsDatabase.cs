using System.Data.SqlClient;

namespace CovidMangementApp.Helpers
{
    internal class clsDatabase
    {
        public static SqlConnection con;
        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=BORK; Database=VACCINATION; Integrated Security=True;");
                con.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
