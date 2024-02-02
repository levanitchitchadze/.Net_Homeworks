using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_FV1_
{
    internal static class DesighnClass
    {
        static DataGridView dataGrid;

        public static void DataGridViewDesighnes (DataGridView dgv, int desighnType) {

            dataGrid = dgv;
            switch(desighnType)
            {
                case 1: setDesighns1(); break;
            }

        }




        public static void setDesighns1()
        {
            
            dataGrid.BackgroundColor=Color.White;
            dataGrid.CellBorderStyle=DataGridViewCellBorderStyle.None;
            dataGrid.BorderStyle=BorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.Font= new Font("Sans serif", 12);
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            int width = dataGrid.Width;
            

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].Width = (width / dataGrid.Columns.Count)-10;

            }

        }

    }
}
