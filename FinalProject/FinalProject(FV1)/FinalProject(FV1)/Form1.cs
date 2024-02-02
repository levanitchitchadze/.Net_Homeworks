using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject_FV1_
{
    public partial class Form1 : Form
    {
        string PageName = "Home";
        public Form1()
        {
            InitializeComponent();

            
            loadHomePage();
            LoadPage();
        }

        public void LoadPage()
        {
            PageNameL.Text = PageName;
            switch (PageName)
            {
                case "Projects": loadProjectPage(); break;
                case "TestCases": loadTestCasesPage(); break;
                case "Home": loadHomePage(); break;
                case "Reports": loadReportPage(); break;
            }
        }

        public void loadHomePage()
        {

            HomePanel.Visible = true;
            DataPanel.Visible = false;
            

            using (var context = new TCMSEntities()) { 

                var Projects = context.ProjectsQuantity(false).FirstOrDefault();
                    
                ProjectLabel.Text = Projects.ToString();
                    

                var Sections = context.Sections.Where(x => x.IsDeleted == false).Select(x => x.SectionId).Count().ToString();
                SectionLabel.Text = Sections;


                var Cases = context.TestCases.Where(x => x.IsDeleted == false).Select(x => x.CaseId).Count().ToString();
                TestCaseLabel.Text = Cases;
                fillTestCaseChart();
            }

        }


        public void fillTestCaseChart()
        {
            using (var context = new TCMSEntities())
                {
                    TestCaseChart.Series.Clear();
                    TestCaseChart.AxisX.Clear();
                    TestCaseChart.AxisY.Clear();


                    TestCaseChart.Visible = true;
                //var chartMonths = context.chartData(Convert.ToDateTime("2023-05-05"), Convert.ToDateTime("2024-01-01")).Select(x => x.CreateMonth).ToList();
                    var chartMonths=context.chartData(Convert.ToDateTime("2023-05-05"), Convert.ToDateTime("2024-01-01")).Select(x=> Convert.ToString(x.CreateMonth)).ToList();
                var chartCases = context.chartData(Convert.ToDateTime("2023-05-05"), Convert.ToDateTime("2024-01-01")).Select(x => new {cases=Convert.ToInt32(x.CreatedCases), month= Convert.ToInt32(x.CreateMonth) }).ToList();
                TestCaseChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Month",
                        Labels = chartMonths
                });

                    
                    TestCaseChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Quantity",
                        Labels = new[] {"1","10", "100", "1000", "10000" }
                    });

                if (chartCases != null)
                {

                    TestCaseChart.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values=new ChartValues<ObservablePoint>
                            {
                                new ObservablePoint(0,24),
                                new ObservablePoint(1,32),
                                new ObservablePoint(2,12),
                                new ObservablePoint(3,8)
                            }
                        }
                    };


                }
            }
        }



        public void fillChart()
        {
            /*
            TestCasesChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            
            TestCasesChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "შექმნილი ქეისები",
                Labels = new[] { "1", "10", "100", "1000", "10000" }
            });*/




        }

        public void loadProjectPage()
        {
            ShowDataPanel();
            using (var context = new TCMSEntities())
            {
                try
                {
                    var Projects = context.Projects.Where(x => x.IsDeleted == false)
                    .Select(x => new { ProjectId = x.ProjectId, Projects = x.ProjectName }).ToList();



                
                    DataView.Columns.Clear();
                    DataView.DataSource = Projects;

                    DataView.Columns.Add(GenerateDataGridViewButtonColumn("Delete", "Delete", "DeleteCell"));
                    DataView.Columns.Add(GenerateDataGridViewButtonColumn("Edit", "Edit", "EditCell"));

                    DesighnClass.DataGridViewDesighnes(DataView, 1);


                }
                catch (Exception Ex )
                {
                    Console.WriteLine(Ex.Message);
                }

            }
        }

        public DataGridViewButtonColumn GenerateDataGridViewButtonColumn(string HeaderText,string Text , string name)
        {
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();

            ButtonColumn.HeaderText = HeaderText;
            ButtonColumn.Text = Text;
            ButtonColumn.Name = name;
            ButtonColumn.UseColumnTextForButtonValue = true;

            return ButtonColumn; 
        }

        public void loadTestCasesPage()
        {


            ShowDataPanel();
            using (var context = new TCMSEntities())
            {
                try
                {
                    
                    var TestCases = (from tc in context.TestCases 
                                    from s in context.Sections where s.SectionId==tc.SectionId || tc.SectionId==null
                                    from su in context.Suits where tc.SuitId==su.SuitId
                                    where tc.IsDeleted==false  
                                    select new
                                {
                                    TestCaseId = tc.CaseId,
                                    Scenario = tc.Scenario,
                                    SuitId=su.SuitId,
                                    SuitName=su.SuitName,
                                    SectionId = s.SectionId,
                                    SectionName=s.SectionName,
                                    CreatedDate=tc.CreateDate,
                                    IsActive = tc.IsActive


                                }) .ToList();


                    DataView.Columns.Clear();
                    DataView.DataSource = TestCases;

                    DataView.Columns.Add(GenerateDataGridViewButtonColumn("Delete", "Delete", "DeleteCell"));
                    DataView.Columns.Add(GenerateDataGridViewButtonColumn("Edit", "Edit", "EditCell"));
                    DesighnClass.DataGridViewDesighnes(DataView, 1);

                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }

        public void ShowDataPanel()
        {
            HomePanel.Visible = false;
            DataPanel.Visible = true;
            DataPanel.Location = new Point(190, 62);
        }

        public void loadReportPage()
        {
            DataPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageName = "Home";
            LoadPage();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestCasesButton_Click(object sender, EventArgs e)
        {
            PageName = "TestCases";
            LoadPage();
        }

        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            PageName = "Projects";
            LoadPage();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            PageName = "Reports";
            LoadPage();
            
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(DataView.Columns[e.ColumnIndex].Name);
            if (DataView.Columns[e.ColumnIndex].Name == "DeleteCell")
            {
                
                    if (MessageBox.Show("Are you Sure Want to Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        deleteRecord(Convert.ToInt32(DataView.Rows[e.RowIndex].Cells[0].Value));
                    }
                

            }else if (DataView.Columns[e.ColumnIndex].Name == "EditCell")
            {
                EditRecord editRecord = new EditRecord(0, Convert.ToInt32(DataView.Rows[e.RowIndex].Cells[0].Value));
                editRecord.Show();
               

            }
        }

      
        public void deleteRecord(int Id)
        {
            using (var context = new TCMSEntities())
            {
                try
                {
                    if (PageName == "TestCases")
                    {
                        var tcase = context.TestCases.Find(Id);
                        context.TestCases.Remove(tcase);

                        loadTestCasesPage();
                    }else if (PageName == "Projects")
                    {

                        using (SqlConnection conn =new SqlConnection("Data Source=localhost; Initial Catalog=TCMS;;Integrated Security=True;")) {

                            conn.Open();
                            // Create a query that takes two parameters.
                            string esqlQuery = @"update Projects set IsDeleted=@isDeleted where ProjectId=@projectId";

                            
                            using (SqlCommand cmd = new SqlCommand(esqlQuery, conn))
                            {

                                cmd.Parameters.AddWithValue("isDeleted", 1);
                                cmd.Parameters.AddWithValue("projectId", Id);

                                cmd.ExecuteNonQuery();
                            }
                            loadProjectPage();
                        }

                    }


                    context.SaveChanges();



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }

        private void CreateTestCaseB_Click(object sender, EventArgs e)
        {
            CreateTestCase createTestCase=new CreateTestCase();
            createTestCase.Show();
        }
    }
}
