using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IdentityModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class TCMS : Form
    {
        string pageName = "Projects";

        public TCMS()
        {
            InitializeComponent();

            LoadPage();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadPage()
        {
            pageNameL.Text = pageName;
            switch(pageName)
            {
                case "Projects": LoadProjectPage();  break;
                case "TestCases": LoadTestCasesPage(); break; 
                case "Interface": LoadInterfacePage(); break;
                case "Suits": LoadSuitsPage(); break;
                case "Sections": LoadSectionsPage(); break;
            }
        }

        public void LoadProjectPage()
        {
            //ProjectPanel.Visible = true;
            using (var context = new TCMSEntities())
            {

                var Projects = context.Projects.Where(x=> x.IsDeleted==false)
                    .Select(x=> new {ProjectId=x.ProjectId, Projects=x.ProjectName }).ToList();

                
                DataGrid.DataSource=Projects;

            }
        }

        public void LoadTestCasesPage()
        {
            using (var context = new TCMSEntities())
            {

                var TestCases = context.TestCases.Where(x => x.IsDeleted == false)
                    .Select(x => new { CaseId = x.CaseId, Scenario = x.Scenario }).ToList();


                DataGrid.DataSource = TestCases;

            }
        }


        public void LoadInterfacePage()
        {
            using (var context = new TCMSEntities())
            {

                var Interfaces = context.Interfaces.Where(x => x.IsDeleted == false)
                    .Select(x => new { InterfaceType = x.InterfaceType, InterfaceName = x.InterfaceName }).ToList();


                DataGrid.DataSource = Interfaces;

            }
        }


        public void LoadSuitsPage()
        {
            using (var context = new TCMSEntities())
            {

                var Suits = context.Suits.Where(x => x.IsDeleted == false)
                    .Select(x => new { SuitId = x.SuitId, SuitName = x.SuitName }).ToList();


                DataGrid.DataSource = Suits;

            }
        }



        public void LoadSectionsPage()
        {
            using (var context = new TCMSEntities())
            {

                var Sections = context.Sections.Where(x => x.IsDeleted == false)
                    .Select(x => new { SectionId = x.SectionId, SectionName = x.SectionName }).ToList();


                DataGrid.DataSource = Sections;

            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            pageName = "TestCases";
            LoadPage();
            
        }

        private void ProjectButton_Click(object sender, EventArgs e)
        {
            pageName = "Projects";
            LoadPage();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            pageName = "Interface";
            LoadPage();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            pageName = "Suits";
            LoadPage();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            pageName = "Sections";
            LoadPage();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MenuPanel.Visible == true)
            {
                MenuPanel.Visible = false;
            }
            else
            {
                MenuPanel.Visible = true;
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            switch (pageName)
            {
                case "Projects": AddProject(); break;
                case "TestCases": AddTestCase(); break;
                case "Interface": //AddInterface();
                                  break;
                case "Suits": //AddSuit();
                              break;
                case "Sections": //AddSection();
                                 break;
            }
        }

        public void AddProject()
        {
            //using (var txscope = new TransactionScope(TransactionScopeOption.RequiresNew))
            //{

                try
                {
                    using (var context = new TCMSEntities())
                    {
                        var proj = new Project()
                        {
                        
                            
                            ProjectName = "Name",
                            BaseUrl="",
                            Description="hhj",
                            IsActive=true,
                            IsDeleted=false
                        };

                        
                    
                        context.Projects.Add(proj);
                        context.SaveChanges();

                    }
                    //LoadPage();

                }catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine(@"ვერ შესრულდა");
                    // Log error
                    //txscope.Dispose();
                }
            //}
        }


        public void AddTestCase()
        {

        }

    }
}
