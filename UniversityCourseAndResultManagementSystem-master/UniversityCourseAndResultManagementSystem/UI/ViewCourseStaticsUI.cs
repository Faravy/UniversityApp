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
using UniversityCourseAndResultManagementSystem.DAL.DAO.ViewModel;

namespace UniversityCourseAndResultManagementSystem.UI
{
    public partial class ViewCourseStaticsUI : Form
    {
        private DepartmentManager departmentManager = new DepartmentManager();

        public ViewCourseStaticsUI()
        {
            InitializeComponent();
        }

        private void ViewCourseStaticsUI_Load(object sender, EventArgs e)
        {
            LoadDepartmentComboBox();
        }

        private void LoadDepartmentComboBox()
        {

            deptComboBox.DataSource = null;
            deptComboBox.DataSource = departmentManager.GetAllDepartments();
            deptComboBox.DisplayMember = "Name";
            deptComboBox.ValueMember = "Id";
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department department = deptComboBox.SelectedItem as Department;
            //int deptId = (int) deptComboBox.SelectedValue;
            //LoadListViewByDeptId(deptId);
            if (department != null)
            {
                LoadListViewByDeptId(department.Id);
            }
        }

        private void LoadListViewByDeptId(int deptId)
        {
            CourseManager courseManager = new CourseManager();
            List<ViewCourseStatics> courses = courseManager.GetAssignCourses();
            courseInfoListView.Items.Clear();
            if (courses != null && courses.Any())
            {
                courses = courses.Where(c => c.DeptId == deptId).ToList();
                if (courses.Any())
                {

                    foreach (ViewCourseStatics course in courses)
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = course.CourseCode;
                        item.SubItems.Add(course.CourseName);
                        item.SubItems.Add(course.SemesterName);
                        if (course.TeacherName == "")
                        {
                            item.SubItems.Add("Not Assigned Yet");
                        }
                        else
                        {
                            item.SubItems.Add(course.TeacherName);
                        }
                        

                        courseInfoListView.Items.Add(item);
                    }
                }
            }
        }
    }
}
