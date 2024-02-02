using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_FV1_
{
    public partial class EditRecord : Form
    {
        int type;
        int rowNumber;
        public EditRecord(int type,int rowNumber)
        {
            this.type = type;
            this.rowNumber = rowNumber;

            InitializeComponent();

            fillData();
        }

        public void fillData()
        {
            if (type==0)
            {
                using (var context = new TCMSEntities()) {
                    var row=context.TestCases.Find(rowNumber);

                    IdL.Text = row.CaseId.ToString();
                    ScenarTB.Text = row.Scenario.ToString();
                    IsActiveCB.Checked = row.IsActive;
                    IsDeletedCB.Checked = row.IsDeleted;

                    try
                    {
                        SuitC.DataSource = context.Suits.Select(x => new { name = x.SuitName, index = x.SuitId }).ToList();
                        SuitC.ValueMember = "index";
                        SuitC.DisplayMember = "name";
                        SuitC.SelectedValue = row.SuitId;

                        
                        
                        
                        var SectionDataSource = (from s in context.Sections where s.SuitId == row.SuitId
                                     select new
                                     {
                                         SectionName = s.SectionName,
                                         SectionId = s.SectionId
                                     }
                                     ).ToList();

                        SectionC.DataSource = SectionDataSource;


                        SectionC.ValueMember = "SectionId";
                        SectionC.DisplayMember = "SectionName";
                        SectionC.SelectedValue = row.SectionId;



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());

                    }
                }
            }else if (type==1)
            {

            }

        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            
            if (type == 0)
            {
                using (var context = new TCMSEntities())
                {
                    var testCase = context.TestCases.Find(rowNumber);
                    int suitId =Convert.ToInt32( SuitC.SelectedValue);
                    int sectionId =Convert.ToInt32( SectionC.SelectedValue);

                    testCase.Scenario=ScenarTB.Text;
                    testCase.SuitId = suitId;
                    testCase.SectionId = sectionId;
                    testCase.IsActive = IsActiveCB.Checked;
                    testCase.IsDeleted = IsDeletedCB.Checked;

                    context.SaveChanges();

                }

                this.Close();

            }else if (type == 1)
            {

            }

        }

        private void SuitC_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new TCMSEntities())
            {
                try
                {
                    int suitId = Convert.ToInt32(SuitC.SelectedValue);
                    var SectionDataSource = (from s in context.Sections
                                             where s.SuitId == suitId
                                             select new
                                             {
                                                 SectionName = s.SectionName,
                                                 SectionId = s.SectionId
                                             }
                                     ).ToList();


                    SectionC.DataSource = SectionDataSource;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
