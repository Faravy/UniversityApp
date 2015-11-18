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
    public partial class EnterCourseUI : Form
    {
        CourseManager aCourseManager=new CourseManager();
        public EnterCourseUI()
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
            
            else if (creditTextBox.Text=="")
            {
                MessageBox.Show("insert credit value");
                return;
            }
            string code = codeTextBox.Text;
            string name = nameTextBox.Text;
            decimal credit = Convert.ToDecimal(creditTextBox.Text);

            string description = descriptionRichTextBox.Text;
            int deptId = (int)departmentComboBox.SelectedValue;
            int semesterId = (int) semesterComboBox.SelectedValue;

            Course aCourse = new Course(code, name, credit,description, deptId,semesterId);

            string msg = aCourseManager.Save(aCourse);
            MessageBox.Show(msg);
        }

        private void EnterCourseUI_Load(object sender, EventArgs e)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            departmentComboBox.DataSource = null;
            departmentComboBox.DataSource = aDepartmentManager.GetAllDepartments();
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
            SemesterManager aSemesterManager = new SemesterManager();
            semesterComboBox.DataSource = null;
            semesterComboBox.DataSource = aSemesterManager.GetAllSemesters();
            semesterComboBox.DisplayMember = "Name";
            semesterComboBox.ValueMember = "Id";
        }

        private void creditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
