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
    public partial class CourseAssignToTeacherUI : Form
    {
        public CourseAssignToTeacherUI()
        {
            InitializeComponent();
        }

        private void CourseAssignToTeacherUI_Load(object sender, EventArgs e)
        {
            LoadDepartmentComboBox();
            
        }

        private void LoadCourseComboBoxByDeptId(int deptId)
        {
            CourseManager courseManager = new CourseManager();
            List<Course> courses = courseManager.GetAllCourse();
            if (courses!=null && courses.Any())
            {
                courses = courses.Where(c => c.Dept_id == deptId).ToList();
                if (courses.Any())
                {
                    courseComboBox.DataSource = null;
                    courseComboBox.DataSource = courses;
                    courseComboBox.DisplayMember = "Code";
                    courseComboBox.ValueMember = "Id";
                }
            }


           
        }

        private void LoadTeacherComboBoxByDepartmentId(int deparmentId)
        {
            TeacherManager teacherManager = new TeacherManager();
            List<Teacher> teachers = teacherManager.GetAllTeachers();
            if (teachers != null && teachers.Any())
            {
                teachers = teachers.Where(c => c.Department_id == deparmentId).ToList();
                if (teachers.Any())
                {
                    teacherComboBox.DataSource = null;
                    teacherComboBox.DataSource = teachers;
                    teacherComboBox.DisplayMember = "Name";
                    teacherComboBox.ValueMember = "Id";
                }
            }
           
        }

        private void LoadDepartmentComboBox()
        {
            DepartmentManager departmentManager = new DepartmentManager();
            deptComboBox.DataSource = null;
            deptComboBox.DataSource = departmentManager.GetAllDepartments();
            deptComboBox.DisplayMember = "Name";
            deptComboBox.ValueMember = "Id";
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = courseComboBox.SelectedItem as Course;
            if (course != null)
            {
                nameTextBox.Text = course.Name;
                creditTextBox.Text = course.Credit.ToString();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department department=deptComboBox.SelectedItem as Department;
            if (department!=null)
            {
                LoadTeacherComboBoxByDepartmentId(department.Id);
                LoadCourseComboBoxByDeptId(department.Id);

            }
            else
            {
                MessageBox.Show("Please select a department first");
                return;
            }
        }

       

        private void teacherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher teacher=teacherComboBox.SelectedItem as Teacher;
            if (teacher != null)
            {
                creditTakenTextBox.Text = teacher.Credit_Taken.ToString();
            }

        }
        
    }
}
