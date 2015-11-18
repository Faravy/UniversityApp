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
    public partial class TeacherEntryUI : Form
    {
        TeacherManager teacherManager=new TeacherManager();
        public TeacherEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("insert name value");
                return;
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("insert address value");
                return;
            }

            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("insert email value");
                return;
            }
            else if (contactTextBox.Text == "")
            {
                MessageBox.Show("insert contact value");
                return;
            }
            else if (creditTextBox.Text == "")
            {
                MessageBox.Show("insert credit value");
                return;
            }
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string email = emailTextBox.Text;
            string contactNo = contactTextBox.Text;
            double credit = Convert.ToDouble(creditTextBox.Text);
           
            int deptId = (int)deptComboBox.SelectedValue;
            int designationId = (int)designationComboBox.SelectedValue;
            Teacher teacher = new Teacher(name,address,email,contactNo,designationId,deptId,credit);
            string msg = teacherManager.Save(teacher);
            MessageBox.Show(msg);

        }

        private void creditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherEntryUI_Load(object sender, EventArgs e)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            deptComboBox.DataSource = null;
            deptComboBox.DataSource = aDepartmentManager.GetAllDepartments();
            deptComboBox.DisplayMember = "Name";
            deptComboBox.ValueMember = "Id";

            DesignationManager designationManager = new DesignationManager();
            designationComboBox.DataSource = null;
            designationComboBox.DataSource = designationManager.GetAllDesignation();
            designationComboBox.DisplayMember = "Name";
            designationComboBox.ValueMember = "Id";
        }
    }
}
