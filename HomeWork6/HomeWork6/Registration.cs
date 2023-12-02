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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            using (SpotifyEntities context = new SpotifyEntities())
            {
                List<String> list = new List<string>();

                User user = new User
                {
                    Name = FirstName.Text,
                    LastName = LastName.Text,
                    Email = Email.Text,
                    AccountId = 1,
                    UserType = 1,
                    SongsId = 1,
                };

                try
                {
                    context.Users.Add(user);

                    context.SaveChanges();
                    MessageBox.Show("User Create successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("can't create User");
                }
                this.Close();
            }
        }
    }
}
