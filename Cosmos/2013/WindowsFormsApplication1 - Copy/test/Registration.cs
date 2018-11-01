using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using test.BW;

namespace test
{
    public partial class Registration : MetroForm
    {
        IS_Employees employee;
        private string _eventID;
        private BW_Employees _bwEmployees;
        private BW_Events _bwEvents;
        private BW_EventRegistration _bwEventRegistration;
        public Registration(string eventID, testEntities context)
        {
            _eventID = eventID;
            _bwEmployees = new BW_Employees(context);
            _bwEventRegistration = new BW_EventRegistration(context);
            _bwEvents = new BW_Events(context);
            InitializeComponent();
        }

        private void Registration_Load(object sender, System.EventArgs e)
        {
            var myEvent = _bwEvents.Get().Find(x => x.EventID.ToString() == _eventID);

            this.Text = "Registration for " + myEvent.EventName + " @ " + myEvent.EventLocation;

            PnlMain.Location = new Point(
                this.ClientSize.Width / 2 - PnlMain.Size.Width / 2,
                this.ClientSize.Height / 2 - PnlMain.Size.Height / 2);
            PnlMain.Anchor = AnchorStyles.None;
        }

        public void ClearAll()
        {
            txtEmployee.Clear();
            txtLeader.Clear();
            txtTeam.Clear();
            txtWorkdayID.Clear();
        }

        private void txtWorkdayID_Leave(object sender, System.EventArgs e)
        {
            employee = _bwEmployees.Get().Find(x => x.WorkdayID == txtWorkdayID.Text);

            if (employee == null)
            {
                txtEmployee.Clear();
                txtLeader.Clear();
                txtTeam.Clear();
            }
            else
            {
                txtEmployee.Text = employee.EmployeeName;
                txtLeader.Text = employee.EmployeeTeamLeader;
                txtTeam.Text = employee.EmployeeTeam;

            }

            btnRegister.Enabled = true;
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            if (employee == null)
            {
                MessageBox.Show("No Employee Found.");
            }
            else
            {
                IS_EventRegistration registration = new IS_EventRegistration
                {
                    EventID = long.Parse(_eventID),
                    EventRegistrationSignedDate = DateTime.Now.ToShortDateString(),
                    WorkdayID = employee.WorkdayID
                };

                var result = _bwEventRegistration.Post(registration);

                if (result)
                {
                    MessageBox.Show("Successfully Registered.");
                }
                else
                {
                    MessageBox.Show("Already Registered");
                }
                ClearAll();
            }
        }

        private void txtWorkdayID_KeyUp(object sender, KeyEventArgs e)
        {
            employee = _bwEmployees.Get().Find(x => x.WorkdayID == txtWorkdayID.Text);

            if (employee == null)
            {
                txtEmployee.Clear();
                txtLeader.Clear();
                txtTeam.Clear();
            }
            else
            {
                txtEmployee.Text = employee.EmployeeName;
                txtLeader.Text = employee.EmployeeTeamLeader;
                txtTeam.Text = employee.EmployeeTeam;

            }

            btnRegister.Enabled = true;
        }
    }
}
