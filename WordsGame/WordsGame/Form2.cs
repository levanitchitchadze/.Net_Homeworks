using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsGame
{
    public partial class LoginForm : Form
    {
        string userName;
        string email;
        public Form GameForm = null;
        public int UserId = 0;


        public LoginForm()
        {
            InitializeComponent();

        }

       

        private void LoginButton_Click(object sender, EventArgs e)
        {
            GameForm.Close();
            userName = UserNameTB.Text;
            email = EmailTB.Text;

            if (userName.Length>5 && email.Length>8 && email.Contains("@"))
            {

                // Check if Exist 
                string sqlQuery = "select *from Users where UserName= @userName and Email= @email ";
                List<string> queryParameters = new List<string>() { "userName", userName , "email", email };
                
                

                SqlDataReader dataReader = DataBase.SendSqlCommand(sqlQuery, queryParameters);

                //true: login
                if (dataReader.HasRows){
                    dataReader.Read();
                    UserId= Convert.ToInt32( dataReader[0]);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                    
                }
                //false: create Account
                else
                {
                    Console.WriteLine("User Not Exist ");
                }


                


            }

        }
    }
}
