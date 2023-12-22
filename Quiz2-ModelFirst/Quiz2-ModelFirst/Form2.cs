using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


            GenerateElements();
        }


        public void GenerateElements()
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
        }
    }
}
