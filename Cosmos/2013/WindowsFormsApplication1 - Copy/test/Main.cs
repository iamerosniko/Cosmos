using MetroFramework.Forms;
using System.Windows.Forms;
using test.BW;

namespace test
{
    public partial class Main : MetroForm
    {

        BW_Employees employees;
        public Main()
        {
            InitializeComponent();
            testEntities context = new testEntities();


            employees = new BW_Employees(context);
            //testEntities test = new testEntities();
            //test.Database.Connection = ".\test.db3";
            //var a = test.testtable1.Where(x => x.name == "eros").FirstOrDefault();
            //MessageBox.Show(test.Database.Connection.ConnectionString.ToString());
            //MessageBox.Show(a.name);
        }

        #region EMPLOYEES
        public void GetEmployees()
        {
            GridEmployees.DataSource = employees.Get();
            GridEmployees.Columns[0].HeaderText = "Workday ID";
            GridEmployees.Columns[1].HeaderText = "Employee Name";
            GridEmployees.Columns[2].HeaderText = "Team";
            GridEmployees.Columns[3].HeaderText = "Team Leader";
        }
        #endregion

        private void Main_Load(object sender, System.EventArgs e)
        {

            GetEmployees();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetEmployees();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            IS_Employees isEmployee = new IS_Employees
            {
                EmployeeName = txtFullName.Text,
                EmployeeTeam = txtTeam.Text,
                EmployeeTeamLeader = txtTeamLeader.Text,
                WorkdayID = txtWorkdayID.Text
            };

            if (isEmployee.WorkdayID.Trim().Equals(""))
            {
                MessageBox.Show("Workday ID is Required.");
            }
            else if (isEmployee.EmployeeName.Trim().Equals(""))
            {
                MessageBox.Show("Employee Name is Required.");
            }
            else if (isEmployee.EmployeeTeam.Trim().Equals(""))
            {
                MessageBox.Show("Team is Required.");
            }
            else if (isEmployee.EmployeeTeamLeader.Trim().Equals(""))
            {
                MessageBox.Show("Team Leader is Required.");
            }
            else
            {
                employees.Post(isEmployee);
                MessageBox.Show("Employee Successfully Added.");
                btnRefresh_Click(sender, e);
            }
        }
    }
}
