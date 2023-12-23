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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        CreateForm createForm;
        public Form1()
        {
            InitializeComponent();
            loadDataFromModel("Orders");
            PageName.Text = "Sales History";
            AddRecordB.Text = "Add Order";
            DeleteRecordB.Text = "Delete Order";
        }


        public void loadDataFromModel(string tableName)
        {


            var context = new Model1Container();
            
                switch (tableName)
                {
                    case "Customers":
                        ShowDataGrid.DataSource = null; 
                        ShowDataGrid.DataSource = context.Customers.ToList();
                        break;

                    case "Orders":
                        ShowDataGrid.DataSource = null;
                        ShowDataGrid.DataSource = context.Orders.ToList();
                        break;

                    case "Products":
                            ShowDataGrid.DataSource = null;
                            ShowDataGrid.DataSource = context.Products.ToList();
                            break;
                }
                
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalesHistoryB_Click(object sender, EventArgs e)
        {
            elementVizualisation();
            AddRecordB.Text = "Add Order";
            DeleteRecordB.Text = "Delete Order";
            loadDataFromModel("Orders");
            PageName.Text = "Sales History";

        }

        private void ProductsB_Click(object sender, EventArgs e)
        {
            elementVizualisation();
            AddRecordB.Text = "Add Product";
            DeleteRecordB.Text = "Delete Product";
            loadDataFromModel("Products");
            PageName.Text = "Products";
        }


        private void CustomersB_Click(object sender, EventArgs e)
        {
            elementVizualisation();
            AddRecordB.Text = "Add Customer";
            DeleteRecordB.Text = "Delete Customer";
            loadDataFromModel("Customers");
            PageName.Text = "Customers";
        }


        public void elementVizualisation(bool FirstEl = true, bool SecondEl = true, bool ThirdEl = true)
        {
            if (FirstEl) SalesHistoryPageP.Visible = true; else SalesHistoryPageP.Visible = false;
            if (SecondEl) AddRecordB.Visible = true; else AddRecordB.Visible = false;
            if (ThirdEl) DeleteRecordB.Visible = true; else DeleteRecordB.Visible = false;
        }

        private void AddRecordB_Click(object sender, EventArgs e)
        {



            createForm = new CreateForm(AddRecordB.Text);

            createForm.Show();

            loadDataFromModel(PageName.Text);
        }

        private void DeleteRecordB_Click(object sender, EventArgs e)
        {

            int deletedRow=Convert.ToInt32(ShowDataGrid.SelectedRows[0].Cells[0].Value);
            Console.WriteLine(deletedRow);
            if (deletedRow != 0)
            {
                using(var context =new Model1Container())
                {
                    switch (DeleteRecordB.Text)
                    {
                        case "Delete Order":
                            
                            context.Orders.Remove(context.Orders.SingleOrDefault(x => x.Id == deletedRow));
                            context.SaveChanges();
                            break;

                        case "Delete Product":
                             
                            context.Products.Remove(context.Products.SingleOrDefault(x => x.Id == deletedRow));
                            context.SaveChanges();
                            break;

                        case "Delete Customer":
                             
                            context.Customers.Remove(context.Customers.SingleOrDefault(x => x.Id == deletedRow));
                            context.SaveChanges();
                            break;
                    }
                    
                }
            }
        }
    }
}
