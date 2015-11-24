using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityCourseAndResultManagementSystem.UI;

namespace UniversityCourseAndResultManagementSystem
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void enterDepartmentButton_Click(object sender, EventArgs e)
        {
            EnterDepartmentUI aDepartmentEntryUi = new EnterDepartmentUI();
            aDepartmentEntryUi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewDepartmentUI viewDepartmentUi=new ViewDepartmentUI();
            viewDepartmentUi.Show();
        }

        private void courseEntryButton_Click(object sender, EventArgs e)
        {
            EnterCourseUI enterCourseUi=new EnterCourseUI();
            enterCourseUi.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            TeacherEntryUI teacherEntryUi=new TeacherEntryUI();
            teacherEntryUi.Show();
        }

        private void courseAssignButton_Click(object sender, EventArgs e)
        {
            CourseAssignToTeacherUI courseAssignToTeacherUi=new CourseAssignToTeacherUI();
            courseAssignToTeacherUi.Show();
        }

        private void viewCourseButton_Click(object sender, EventArgs e)
        {
            ViewCourseStaticsUI viewCourseStaticsUi=new ViewCourseStaticsUI();
            viewCourseStaticsUi.Show();
        }

        private void registerStudentButton_Click(object sender, EventArgs e)
        {
            StudentRegistrationUI studentRegistrationUi=new StudentRegistrationUI();
            studentRegistrationUi.Show();
        }

        private void roomAllocatebutton_Click(object sender, EventArgs e)
        {
            RoomAllocationUI roomAllocationUi=new RoomAllocationUI();
            roomAllocationUi.Show();
        }
    }
}
