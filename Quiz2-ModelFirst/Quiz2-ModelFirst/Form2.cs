using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2_ModelFirst
{
    public partial class CreateForm : MetroFramework.Forms.MetroForm
    {
        string targetTable;
        List<string> customerTableNames=new List<string> { };
        List<string> productTableNames;
        List<string> orderTableNames;
        public CreateForm(string tableName)
        {
            targetTable = tableName;
            InitializeComponent();


            //GenerateElements();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName= FirstNameTB.Text,
                LastName= LastNameTB.Text,
                City= CityTB.Text,
                Country= CountryTB.Text,
                Phone= PhoneTB.Text,
            };


            try
            {

                using (var context = new Model1Container())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();

                }

                this.Close();
            }
            catch (Exception ecxeption)
            {
                //MetroMessageBox.Show(1,"Cant create new Record");
            }
        }


        /*public void GenerateElements()
        {
            switch (targetTable)
            {
                case "Customer": GenerateTextBoxes(); break;
                case "Product": GenerateTextBoxes(); break;
                case "Order": GenerateTextBoxes(); break;
            }
        } 

        public List<TextBox> GenerateTextBoxes(List<string> TextBoxNames ,int verticalDifference=50,int horizontalDifference=0)
        {
            List<TextBox> textBoxObjects = new List<TextBox>();

            int formWidth = this.Width;
            int formHeight = this.Height;

            formWidth -= 50;

            foreach (var textBoxName in TextBoxNames)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(formWidth+horizontalDifference,formHeight-verticalDifference );
                
                textBox.Name = textBoxName;
                textBoxObjects.Add(textBox);
                this.Controls.Add(textBox);
            }


            return textBoxObjects;
        }*/
    }
}
