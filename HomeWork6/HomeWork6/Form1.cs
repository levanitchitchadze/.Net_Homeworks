using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();


            /*using (SpotifyEntities context = new SpotifyEntities())
            {
                List<String> list = new List<string>();

                User user = new User
                {
                    Name = "Levan",
                    LastName = "Tchitchadze",
                    Email = "chichadze123@gmail.com",
                    AccountId = 1,
                    UserType = 1,
                    SongsId = 1,
                };


                context.Users.Add(user);
                
                context.SaveChanges();


            }*/



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Registration registration = new Registration();
            

            registration.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SpotifyEntities context = new SpotifyEntities())
            {
                

                var user = context.Users.FirstOrDefault(u=> u.Name== LoginName.Text && u.Email==LoginEmail.Text);

                if (user != null) {
                    MainPage mainPage = new MainPage();
                    this.Hide();
                    mainPage.Show();
                    

                }
                else
                {
                    MessageBox.Show("UserName or Email is not correct");
                }

                LoginName.Clear();
                LoginEmail.Clear();


            }
        }
    }
}
