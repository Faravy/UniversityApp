using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityCourseAndResultManagementSystem.BLL;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.UI
{
    public partial class EnterDepartmentUI : Form
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        public EnterDepartmentUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text == "")
            {
                MessageBox.Show("insert code value");
                return;
            }
            else if (nameTextBox.Text == "")
            {
                MessageBox.Show("insert name value");
                return;
            }
            string code = codeTextBox.Text;
            string name = nameTextBox.Text;

            Department aDepartment = new Department(code, name);
            string msg = aDepartmentManager.Save(aDepartment);

            MessageBox.Show(msg);
        }
    }
}
