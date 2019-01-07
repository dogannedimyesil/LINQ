using LINQ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
    {
        List<Staff> list = new List<Staff>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_newStaff_Click(object sender, EventArgs e)
        {
            list.Add(new Staff());
            string staffNumber = list.Count.ToString();
            lbl_Staff.Text = Resources.template1.Replace("0", staffNumber);

            string avrg = list.Average(x => x.Salary).ToString("C");
            lbl_Salary.Text = Resources.template2.Replace("0", avrg);

            string lastAge = list.Last().Age.ToString();
            lbl_StaffAge.Text = Resources.template3.Replace("0", lastAge);

            string lastSalary = list.Last().Salary.ToString();
            lbl_StaffSalary.Text = Resources.template4.Replace("0", lastSalary);
        }
    }
}
