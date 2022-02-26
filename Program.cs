using System;
using System.Data.SqlClient;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=XC-AZ-CTX048\SQLEXPRESS;Initial Catalog=Ecom;Integrated Security=True;Pooling=False";
            SqlConnection con = new SqlConnection(ConString);
            string querystring1 = "Select * from Cart";
            string querystring2 = "Select * from Customer";
            string querystring3 = "Select * from Order";
            string querystring4 = "Select * from Payment";
            string querystring5 = "Select * from Product";
            string querystring6 = "Select * from Seller";

            con.Open();
            SqlCommand cmd1 = new SqlCommand(querystring1, con);
            SqlCommand cmd2 = new SqlCommand(querystring2, con);
            SqlCommand cmd3 = new SqlCommand(querystring3, con);
            SqlCommand cmd4 = new SqlCommand(querystring4, con);
            SqlCommand cmd5 = new SqlCommand(querystring5, con);
            SqlCommand cmd6 = new SqlCommand(querystring6, con);
            SqlDataReader reader = cmd1.ExecuteReader();
            SqlDataReader reader = cmd2.ExecuteReader();
            SqlDataReader reader = cmd3.ExecuteReader();
            SqlDataReader reader = cmd4.ExecuteReader();
            SqlDataReader reader = cmd5.ExecuteReader();
            SqlDataReader reader = cmd6.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            Console.ReadLine();
        }
    }
}
