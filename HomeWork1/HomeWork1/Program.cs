using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using System.Text.RegularExpressions;

namespace HomeWork1
{
    internal class Program
    {
        public static String dataSource = @"LENOVO-PC";
        public static String dataBase = "midle";

        static void Main(string[] args)
        {

            executeSqlQueries();
            

            
            
            Console.WriteLine("/End");

            Console.ReadKey();
        }



        public static void executeSqlQueries()
        {
            String method = getMethod();


            switch (method)
            {
                case "1": selectExecute(); break;
                case "2": insertExecute(); break;
                case "3": deleteExecute(); break;
                case "4": updateExecute(); break;
                case "5": procedureExecute(); break;
                default: Console.WriteLine("\nThere is not such method " + method + " , choose again "); executeSqlQueries(); break;
            }




        }


        public static void selectExecute()
        {
            using (SqlConnection conn = SC.sqlConn(dataSource, dataBase))
            {
                SqlParameter parameter = new SqlParameter();

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                using (SqlCommand com = new SqlCommand("Select *from BOOKS ", conn))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {

                        Console.WriteLine("{0}, {1}", reader["BOOK_ID"], reader["TITLE"]);

                    }
                }

            }
            Console.WriteLine("\n");
            executeSqlQueries();
        }

        public static void insertExecute()
        {
            using (SqlConnection conn = SC.sqlConn(dataSource, dataBase))
            {
                SqlParameter parameter = new SqlParameter();

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                using (SqlCommand com = new SqlCommand("insert into BOOKS (TITLE,DESCRIBTION,IMG_ID,YEAR,AUT_BOOK_ID,book_type) values('newBookFromeCode','some Shit',1,'2012-10-12',1,1)", conn))
                {
                    com.ExecuteNonQuery();
                }

                /*
                parameter.ParameterName = "ID";
                    parameter.Value = "";
                    //where BOOK_ID = 9
                    com.Parameters.Add(parameter);
                */
            }
            Console.WriteLine("\n");
            executeSqlQueries();
        }

        public static void deleteExecute()
        {
            using (SqlConnection conn = SC.sqlConn(dataSource, dataBase))
            {
                SqlParameter parameter = new SqlParameter();

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                using (SqlCommand com = new SqlCommand("  delete TOP(1)  from BOOKS ", conn))
                {
                    com.ExecuteNonQuery();
                }


            }
            Console.WriteLine("\n");
            executeSqlQueries();
        }


        public static void updateExecute()
        {
            using (SqlConnection conn = SC.sqlConn(dataSource, dataBase))
            {

                SqlParameter parameter = new SqlParameter();
                Console.WriteLine("\nWrite record Id: ");
                int DataId=int.Parse(Console.ReadLine());
                Console.WriteLine("\nWrite new title: ");
                String title=Console.ReadLine();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                using (SqlCommand com = new SqlCommand("update BOOKS set TITLE=@Title where BOOK_ID =@Id;", conn))
                {
                    com.Parameters.Add(new SqlParameter("@Id", DataId));
                    com.Parameters.Add(new SqlParameter("@Title", title));
                    com.ExecuteNonQuery();
                    Console.WriteLine("record Updated");
                }


            }
            Console.WriteLine("\n");
            executeSqlQueries();
        }
        public static void procedureExecute()
        {
            using (SqlConnection conn = SC.sqlConn(dataSource, dataBase))
            {
                SqlParameter parameter = new SqlParameter();

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                using (SqlCommand com = new SqlCommand("exec SelectAllBooks", conn))
                {
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {

                        Console.WriteLine("{0}, {1}", reader["BOOK_ID"], reader["TITLE"]);

                    }
                }

            }
            Console.WriteLine("\n");
            executeSqlQueries();
        }

        public static String getMethod()
        {
            Console.WriteLine("Select 1,insert 2,delete 3, update 4, procedure 5 ");
            Console.Write("Choose Method: ");
            
            return Console.ReadLine();
        }



    }
}
