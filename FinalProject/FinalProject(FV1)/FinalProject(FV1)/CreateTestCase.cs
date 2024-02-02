using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FinalProject_FV1_
{
    public partial class CreateTestCase : Form
    {
        public CreateTestCase()
        {
            InitializeComponent();
            fillData();
        }

        public void fillData()
        {
            using (var context = new TCMSEntities())
            {
                try
                {
                    SuitC.DataSource = context.Suits.Select(x => new { name = x.SuitName, index = x.SuitId }).ToList();
                    SuitC.ValueMember = "index";
                    SuitC.DisplayMember = "name";
                }catch(Exception ex)
                {
                    
                    MessageBox.Show("Suit: "+ex.Message);
                }
                    
                int selectedsSuit = Convert.ToInt32(SuitC.SelectedValue);

                try { 

                    var SectionDataSource = (from s in context.Sections
                                             where s.SuitId == selectedsSuit
                                             select new
                                             {
                                                 SectionName = s.SectionName,
                                                 SectionId = s.SectionId
                                             }
                                         ).ToList();

                    SectionC.DataSource = SectionDataSource;


                    SectionC.ValueMember = "SectionId";
                    SectionC.DisplayMember = "SectionName";
                }catch(Exception ex)
                {

                    MessageBox.Show("Sections: " + ex.Message);
                }

                try {
                    

                    StepsC.DataSource = context.Steps.Select(x => new { name = x.Description1.ToString(), index = x.StepId }).ToList();
                    StepsC.ValueMember = "index";
                    StepsC.DisplayMember = "name";

                }catch(Exception ex)
                {

                    MessageBox.Show("Steps: "+ex.Message);
                }


                try { 

                    ValidationsC.DataSource = context.Validations.Select(x => new { name = x.Description, index = x.ValidationId }).ToList();
                    ValidationsC.ValueMember = "index";
                    ValidationsC.DisplayMember = "name";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Validations: " + ex.Message);
                }

        }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var context = new TCMSEntities())
            {
                
                if ( (SuitC.SelectedValue is String || SuitC.SelectedValue is int) && SuitC.SelectedValue!=null)
                {

                     int selectedsSuit = Convert.ToInt32(SuitC.SelectedValue);



                    var SectionDataSource = (from s in context.Sections
                                             where s.SuitId == selectedsSuit
                                             select new
                                             {
                                                 SectionName = s.SectionName,
                                                 SectionId = s.SectionId
                                             }
                                         ).ToList();

                    SectionC.DataSource = SectionDataSource;


                    SectionC.ValueMember = "SectionId";
                    SectionC.DisplayMember = "SectionName";

                }




            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            using (var context = new TCMSEntities())
            {
                var testCase = context.TestCases.Add(new TestCas
                {

                    Scenario = scenarioTB.Text,
                    SuitId = Convert.ToInt32(SuitC.SelectedValue),
                    SectionId = Convert.ToInt32(SectionC.SelectedValue),
                    IsActive = true,
                    IsDeleted = false,
                    CreateDate = Convert.ToDateTime("2024-01-01")
                });


                context.SaveChanges();

                using (var Transaction  = context.Database.BeginTransaction() )
                {
                    //int savedCaseId=0;
                    try
                    {

                        Console.WriteLine(testCase.CaseId);
                        //Convert.ToInt32(testCase.CaseId)
                        //Convert.ToInt32(StepsC.SelectedValue)
                        context.CasesToSteps.Add(new CasesToStep()
                        {
                            CaseId = testCase.CaseId,
                            StepId = Convert.ToInt32(StepsC.SelectedValue),
                            IsActive = true,
                            
                        });

                        context.CasesToValidations.Add(new CasesToValidation()
                        {
                            CaseId = testCase.CaseId,
                            ValidationId = Convert.ToInt32(ValidationsC.SelectedValue),
                            IsActive = true,

                        });


                        context.SaveChanges();
                        Transaction.Commit();
                        
                        MessageBox.Show("Test case created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Transaction.Rollback();
                        MessageBox.Show("Create Test Case : " + ex.Message);
                        Console.WriteLine(ex);
                    }
                    
                }
            }

        }
    }
}
