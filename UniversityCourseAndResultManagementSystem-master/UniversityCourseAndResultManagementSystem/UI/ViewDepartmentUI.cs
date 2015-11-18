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
    public partial class ViewDepartmentUI : Form
    {
        DepartmentManager manager = new DepartmentManager();
        public ViewDepartmentUI()
        {
            InitializeComponent();
        }

        private void viewDepartmentListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewDepartmentUI_Load(object sender, EventArgs e)
        {
            List<Department> departments = manager.GetAllDepartments();

            foreach (Department department in departments)
            {
                ListViewItem item = new ListViewItem();

                item.Text = department.Code;
                item.SubItems.Add(department.Name);

                viewDepartmentListView.Items.Add(item);
            }
        }
    }
}
