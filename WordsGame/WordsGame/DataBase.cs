using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsGame
{
    internal class DataBase
    {
        static SqlConnection Con;
        public static String getRandomWord(int WordType)
        {

            using(SqlConnection Con = sqlConn("localhost", "Lordle"))
            {
                try{

                    Con.Open();
                    string Command="";

                    switch (WordType) {
                        case 1: Command = "exec GetEasyWord";
                                break;
                        case 2: Command = "exec GetMediumWord";
                            break;
                        case 3: Command = "exec GetHardWord";
                            break;
                    }

                    SqlCommand cmd=new SqlCommand(Command,Con);

                    return Convert.ToString( cmd.ExecuteScalar());

                    
                }catch(Exception Ex)
                {
                    MessageBox.Show("Connection is not ! ");
                    System.Diagnostics.Debug.WriteLine(Ex);

                }
                

                return null;
            }
        }


        private static SqlConnection sqlConn(string dataSource, string dataBase)
        {


            String connString = "Data Source=" + dataSource + "; Initial Catalog=" + dataBase + "; Integrated Security=True;";


            return new SqlConnection(connString);

        }



        public static SqlDataReader SendSqlCommand(string command, List<string> parameters=null ,string connectionUser= "localhost",string connectionDataBase= "Lordle")
        {
             Con = sqlConn(connectionUser, connectionDataBase);
            
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand(command, Con);


                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Count-1 ; i++)
                        {

                            cmd.Parameters.AddWithValue(parameters[i], parameters[i + 1]) ;
                            

                            i++;
                        }
                    }

                    
                    

                    SqlDataReader executedResult= cmd.ExecuteReader();

                   


                    return executedResult;

                }
                catch (SqlException SE)
                {
                    Console.WriteLine("sendSqlCommand  :" +SE.ToString());
  
                }
                


                return null;


            

        }

        public static void CloseConnection()
        {
            Con.Close();
        }

    }
}
