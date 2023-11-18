using Mid_Term_Nov_18_23.contactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mid_Term_Nov_18_23
{
    public partial class MainForm : Form
    {
        contactClasses.contactClass ContactClass = new contactClasses.contactClass();
        
        public MainForm()
        {
            InitializeComponent();







            dataGridView.DataSource = ContactClass.Select();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ContactClass.FirstName=FirstNameTextBox.Text;
            ContactClass.LastName=LastNameTextBox.Text;
            ContactClass.ContactNo=ContactNoTextBox.Text;
            ContactClass.Address=AddressTextBox.Text;
            ContactClass.Gender=GenderComboBox.Text;


            bool success = ContactClass.Insert(ContactClass);

            if (success)
            {
                MessageBox.Show("New Contact Successfuly Inserted");
                clear();
                dataGridView.DataSource = ContactClass.Select();

            }
            else
            {
                MessageBox.Show("Failed to add New Contact. Try Again");

            }


            





        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear();
        }


        public void clear()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            ContactNoTextBox.Text = "";
            AddressTextBox.Text = "";
            GenderComboBox.Text = "";
            ContactIdTextBox.Text = "";
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            ContactIdTextBox.Text = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            FirstNameTextBox.Text = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            LastNameTextBox.Text = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            ContactNoTextBox.Text = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            AddressTextBox.Text = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            GenderComboBox.Text = dataGridView.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ContactClass.ContactID = int.Parse(ContactIdTextBox.Text);
            ContactClass.FirstName = FirstNameTextBox.Text;
            ContactClass.LastName = LastNameTextBox.Text;
            ContactClass.ContactNo = ContactNoTextBox.Text;
            ContactClass.Address = AddressTextBox.Text;
            ContactClass.Gender = GenderComboBox.Text;

            bool success = ContactClass.Update(ContactClass);

            if (success)
            {
                MessageBox.Show("Contact has been successfully Updated");
                clear();
                dataGridView.DataSource = ContactClass.Select();


            }
            else
            {
                MessageBox.Show("Failed to Update Contact. Try Again");

            }
            

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ContactClass.ContactID = Convert.ToInt32(ContactIdTextBox.Text);
            bool success = ContactClass.Delete(ContactClass);

            if (success)
            {
                MessageBox.Show("Contact successfully deleted");
                clear();
                dataGridView.DataSource = ContactClass.Select();


            }
            else
            {
                MessageBox.Show("Failed to delete Contact. Try Again");

            }

        }
    }
}
