using MetroFramework.Forms;
using System.Windows.Forms;
using test.BW;

namespace test
{
    public partial class Main : MetroForm
    {

        BW_Employees myemployees;
        BW_Events myevents;
        public Main()
        {
            InitializeComponent();
            testEntities context = new testEntities();


            myemployees = new BW_Employees(context);
            myevents = new BW_Events(context);

        }

        #region EMPLOYEES
        public void GetEmployees()
        {
            GridEmployees.DataSource = myemployees.Get();
            GridEmployees.Columns[0].HeaderText = "Workday ID";
            GridEmployees.Columns[1].HeaderText = "Employee Name";
            GridEmployees.Columns[2].HeaderText = "Team";
            GridEmployees.Columns[3].HeaderText = "Team Leader";
        }
        private void btnEmployeeSave_Click(object sender, System.EventArgs e)
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
                var result = myemployees.Post(isEmployee);
                if (result == true) MessageBox.Show("Employee Successfully Added."); else MessageBox.Show("Workday ID Already Exists.");
                btnRefresh_Click(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetEmployees();
            GetEvents();
        }

        #endregion

        #region EVENTS

        public void GetEvents()
        {
            var listEvents = myevents.Get();
            GridEvents.DataSource = listEvents;
            GridEmployees.Columns[0].Visible = false;
            GridEmployees.Columns[1].HeaderText = "Event";
            GridEmployees.Columns[2].HeaderText = "Event Date";
            GridEmployees.Columns[3].HeaderText = "Venue";
            cmbEvent.DataSource = listEvents;
            cmbEvent.DisplayMember = "EventName";
            cmbEvent.ValueMember = "EventID";
        }
        #endregion

        private void Main_Load(object sender, System.EventArgs e)
        {
            GetEmployees();
            GetEvents();
        }

        private void btnEventCheck_Click(object sender, System.EventArgs e)
        {
            var a = myevents.Get().Find(x => x.EventID.ToString() == cmbEvent.SelectedValue.ToString());
            txtDeetsEventDate.Text = a.EventDate;
            txtDeetsVenue.Text = a.EventLocation;
        }

        private void btnGoEventRegistration_Click(object sender, System.EventArgs e)
        {
            var a = myevents.Get().Find(x => x.EventID.ToString() == cmbEvent.SelectedValue.ToString());
            Registration r = new Registration(a.EventName);
            r.ShowDialog();
        }

        private void btnSaveEvent_Click(object sender, System.EventArgs e)
        {
            IS_Events isEvent = new IS_Events
            {
                EventDate = txtEventDate.Value.ToShortDateString(),
                EventLocation = txtVenue.Text,
                EventName = txtEventName.Text
            };

            if (isEvent.EventName.Trim().Equals(""))
            {
                MessageBox.Show("Event Name is Required.");
            }
            else if (isEvent.EventLocation.Trim().Equals(""))
            {
                MessageBox.Show("Venue is Required.");
            }
            else if (isEvent.EventDate.Trim().Equals(""))
            {
                MessageBox.Show("Event Date is Required.");
            }

            else
            {
                var result = myevents.Post(isEvent);
                if (result == true) MessageBox.Show("Event Successfully Added."); else MessageBox.Show("Workday ID Already Exists.");
                btnRefresh_Click(sender, e);
            }
        }
    }
}
