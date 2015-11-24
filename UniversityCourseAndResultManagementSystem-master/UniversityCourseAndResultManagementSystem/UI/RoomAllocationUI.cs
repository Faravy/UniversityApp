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
    public partial class RoomAllocationUI : Form
    {
        public RoomAllocationUI()
        {
            InitializeComponent();
            toDateTimePicker.CustomFormat = "hh:mm tt";
            toDateTimePicker.ShowUpDown = true;
            fromDateTimePicker.CustomFormat = "hh:mm tt";
            fromDateTimePicker.ShowUpDown = true;

        }

        private void RoomAllocationUI_Load(object sender, EventArgs e)
        {
            LoadDepartmentComboBox();
            LoadRoomCombobox();

        }

        private void allocateButton_Click(object sender, EventArgs e)
        {
            int deptId = (int)deptComboBox.SelectedValue;
            int courseId = (int) courseComboBox.SelectedValue;
            int roomId = (int)roomComboBox.SelectedValue;
            string day = dayComboBox.Text;
            DateTime fromTime = fromDateTimePicker.Value;
            DateTime toTime = toDateTimePicker.Value;
            RoomAllocation roomAllocation=new RoomAllocation(deptId,courseId,roomId,day,fromTime,toTime);
            RoomAllocationManager manager=new RoomAllocationManager();
            try
            {
                if (manager.IsRoomAvailable(roomId, day, fromTime, toTime))
                {


                    if (manager.Save(roomAllocation))
                    {
                        MessageBox.Show("Room Allocated");

                    }
                    else
                    {
                        MessageBox.Show("Room Allocation Failed");
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
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

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department department = deptComboBox.SelectedItem as Department;
            if (department != null)
            {
                LoadCourseComboBoxByDeptId(department.Id);

            }
            else
            {
                MessageBox.Show("Please select a department first");
                return;
            }
        }
        private void LoadCourseComboBoxByDeptId(int deptId)
        {
            CourseManager courseManager = new CourseManager();
            List<Course> courses = courseManager.GetAllCourse();
            if (courses != null && courses.Any())
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

        private void LoadRoomCombobox()
        {
            RoomAllocationManager roomAllocationManager = new RoomAllocationManager();
            roomComboBox.DataSource = null;
            roomComboBox.DataSource = roomAllocationManager.GetAllRoom();
            roomComboBox.DisplayMember = "Name";
            roomComboBox.ValueMember = "Id";
        }

       

       
    }
}
