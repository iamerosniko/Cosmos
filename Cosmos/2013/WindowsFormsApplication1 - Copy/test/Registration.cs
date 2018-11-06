using System.Drawing;
using System.Windows.Forms;
using test.BW;

namespace test
{
    public partial class Registration : Form
    {
        IS_Employees employee;
        private string _eventID;
        private BW_Employees _bwEmployees;
        private BW_Events _bwEvents;
        private BW_EventRegistration _bwEventRegistration;
        Main _main;
        public Registration(string eventID, testEntities context, Main main)
        {
            _main = main;
            _eventID = eventID;
            _bwEmployees = new BW_Employees(context);
            _bwEventRegistration = new BW_EventRegistration(context);
            _bwEvents = new BW_Events(context);
            InitializeComponent();
        }

        private void Registration_Load(object sender, System.EventArgs e)
        {
            var myEvent = _bwEvents.Get().Find(x => x.EventID.ToString() == _eventID);

            this.Text = "Registration for " + myEvent.EventName + " @ " + myEvent.EventLocation + "                  RESOLUTION : " + this.ClientSize.Width + "x" + this.ClientSize.Height;
            //this.lblRegistrationName.Text = Text;
            this.lblRegistrationName.Text = "Registration for " + myEvent.EventName + " @ " + myEvent.EventLocation;
            //this.label1.Text = this.Text;
            PnlMain.Location = new Point(
                this.ClientSize.Width / 2 - PnlMain.Size.Width / 2,
                this.ClientSize.Height / 2 - PnlMain.Size.Height / 2);
            PnlMain.Anchor = AnchorStyles.None;

            try
            {
                Image myimage = Image.FromFile(@".\Event Theme\" + myEvent.EventTheme);
                //Image myimage = new Bitmap(@".\Event Theme\" + myEvent.EventTheme);
                BackgroundImage = myimage;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                BackgroundImage = null;
            }
        }

        public void ClearAll()
        {
            txtEmployee.Clear();
            txtLeader.Clear();
            txtTeam.Clear();
            txtWorkdayID.Clear();
        }


        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            if (txtWorkdayID.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please provide Workday ID first");
            }
            else
            {
                if (employee == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to add this as new Employee?", "Employee Not Found", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        IS_Employees emp = new IS_Employees
                        {
                            EmployeeName = txtEmployee.Text,
                            WorkdayID = txtWorkdayID.Text,
                            EmployeeTeam = txtTeam.Text,
                            EmployeeTeamLeader = txtLeader.Text
                        };

                        _bwEmployees.Post(emp);

                        IS_EventRegistration registration = new IS_EventRegistration
                        {
                            EventID = long.Parse(_eventID),
                            WorkdayID = txtWorkdayID.Text.Trim()
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
                        _main.btnRefresh_Click(sender, e);

                    }
                }
                else
                {
                    IS_EventRegistration registration = new IS_EventRegistration
                    {
                        EventID = long.Parse(_eventID),
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
                    _main.btnRefresh_Click(sender, e);
                }
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
                txtEmployee.Enabled = true;
                txtLeader.Enabled = true;
                txtTeam.Enabled = true;
            }
            else
            {
                txtEmployee.Text = employee.EmployeeName;
                txtLeader.Text = employee.EmployeeTeamLeader;
                txtTeam.Text = employee.EmployeeTeam;
                txtEmployee.Enabled = false;
                txtLeader.Enabled = false;
                txtTeam.Enabled = false;

            }

            btnRegister.Enabled = true;
        }
    }
}
