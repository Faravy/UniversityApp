using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityCourseAndResultManagementSystem.BLL;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.UI
{
    public partial class StudentRegistrationUI : Form
    {
        StudentManager studentManager=new StudentManager();
        public StudentRegistrationUI()
        {
            InitializeComponent();
        }

        private void StudentRegistrationUI_Load(object sender, EventArgs e)
        {
            LoadDepartmentComboBox();

        }
        private void LoadDepartmentComboBox()
        {
            DepartmentManager departmentManager=new DepartmentManager();
            deptComboBox.DataSource = null;
            deptComboBox.DataSource = departmentManager.GetAllDepartments();
            deptComboBox.DisplayMember = "Code";
            deptComboBox.ValueMember = "Id";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                        
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string contactNo = contactNoTextBox.Text;
            DateTime date = dateTimePicker.Value;
            string address = addressTextBox.Text;
            int deptId = (int) deptComboBox.SelectedValue;
            string regNo = deptComboBox.Text + "-" + date.Year + "-" +
            studentManager.CounterStudentByYearAndDept(date.Year, deptId);

            Student student = new Student(name, email, contactNo, date, address, deptId,regNo);
            try
            {
                string pattern = null;
                pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                if (Regex.IsMatch(email, pattern))
                {
                    if (studentManager.Save(student))
                    {
                        
                        MessageBox.Show("Successfully Registered");
                    }
                    else
                    {
                        MessageBox.Show("Registation Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email Format");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }
    }
}
