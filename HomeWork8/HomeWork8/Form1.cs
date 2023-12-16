using HomeWork8.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog() { Filter="JPEJ|*.jpg"})
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                    {
                        obj.ImageUrl = ofd.FileName;
                    }
                }


            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db=new ModelContext())
            {
                employeeBindingSource.DataSource=db.EmpList.ToList();

            }
            metroPanel.Enabled= false;
            Employee obj = employeeBindingSource.Current as Employee;
            if (obj != null) {
                pictureBox1.Image = Image.FromFile(obj.ImageUrl);
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            metroPanel.Enabled = true;
       
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();
            NameTB.Focus();

        }

        private void EditB_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            NameTB.Focus();
            Employee obj=employeeBindingSource.Current as Employee;

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = false;
            employeeBindingSource.ResetBindings(false);
            MainForm_Load(sender, e);

        }

        private void MetroGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee obj = employeeBindingSource.Current as Employee;
            if (obj != null)
            {
                pictureBox1.Image = Image.FromFile(obj.ImageUrl);
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this,"Are you sure want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using(ModelContext db=new ModelContext())
                {
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                    {
                        if (db.Entry<Employee>(obj).State == EntityState.Detached)
                        {
                            db.Set<Employee>().Attach(obj);
                            db.Entry<Employee>(obj).State = EntityState.Detached;
                            db.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully");
                            employeeBindingSource.RemoveCurrent();
                            metroPanel.Enabled= false;
                            pictureBox1.Image = null;
                        }
                    }
                }
            }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            using (ModelContext db=new ModelContext())
            {
                Employee obj = employeeBindingSource.Current as Employee;
                if (obj != null)
                {
                    if (db.Entry<Employee>(obj).State == EntityState.Detached)
                        db.Set<Employee>().Attach(obj);
                    if (obj.EmpID == 0)
                        db.Entry<Employee>(obj).State=EntityState.Added;
                    else
                        db.Entry<Employee>(obj).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
                    MetroGridView.Refresh();
                    metroPanel.Enabled = false;
                }
            }
        }
    }
}
