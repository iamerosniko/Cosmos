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
            if (myEvent.EventEULA.Equals("") || myEvent.EventEULA == null)
            {
                chbWaive.Visible = false;
            }
            else
            {
                chbWaive.Visible = true;
            }
            //this.Text = "Registration for " + myEvent.EventName + " @ " + myEvent.EventLocation + "                  RESOLUTION : " + this.ClientSize.Width + "x" + this.ClientSize.Height;
            //this.lblRegistrationName.Text = Text;
            //this.lblRegistrationName.Text = "Registration for " + myEvent.EventName + " @ " + myEvent.EventLocation;
            //this.label1.Text = this.Text;


            try
            {

                //if (myEvent.EventIsDark.Value == 1)
                //{
                //    lblEmp.ForeColor = Color.White;
                //    lblTeam.ForeColor = Color.White;
                //    lblTL.ForeColor = Color.White;
                //    lblWDID.ForeColor = Color.White;
                //}
                //else
                //{
                //    lblEmp.ForeColor = Color.Black;
                //    lblTeam.ForeColor = Color.Black;
                //    lblTL.ForeColor = Color.Black;
                //    lblWDID.ForeColor = Color.Black;

                //}
                Image myimage = Image.FromFile(@".\Event Theme\" + myEvent.EventTheme);
                //Image myimage = new Bitmap(@".\Event Theme\" + myEvent.EventTheme);
                //BackgroundImage = myimage;
                //BackgroundImageLayout = ImageLayout.Stretch;
                pnlImage.BackgroundImageLayout = ImageLayout.Stretch;
                pnlImage.BackgroundImage = myimage;
            }
            catch
            {
                BackgroundImage = null;
            }

        }

        public void ClearAll()
        {
            txtFirstName.Clear();
            txtLeader.Clear();
            txtTeam.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtWorkdayID.Clear();
        }


        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            var myEvent = _bwEvents.Get().Find(x => x.EventID.ToString() == _eventID);

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
                            EmployeeFirstName = txtFirstName.Text,
                            EmployeeMiddleName = txtMiddleName.Text,
                            EmployeeLastName = txtLastName.Text,
                            WorkdayID = txtWorkdayID.Text,
                            EmployeeTeam = txtTeam.Text,
                            EmployeeTeamLeader = txtLeader.Text
                        };

                        _bwEmployees.Post(emp);

                        IS_EventRegistration registration = new IS_EventRegistration
                        {
                            EventID = long.Parse(_eventID),
                            WorkdayID = txtWorkdayID.Text.Trim(),
                            EventWaived = chbWaive.Visible ? (chbWaive.Checked ? "Yes" : "No") : "N/A"
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
                        WorkdayID = employee.WorkdayID,
                        EventWaived = chbWaive.Visible ? (chbWaive.Checked ? "Yes" : "No") : "N/A"
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
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                txtLeader.Clear();
                txtTeam.Clear();
                txtFirstName.Enabled = true;
                txtMiddleName.Enabled = true;
                txtLastName.Enabled = true;
                txtLeader.Enabled = true;
                txtTeam.Enabled = true;
            }
            else
            {
                txtFirstName.Text = employee.EmployeeFirstName;
                txtLastName.Text = employee.EmployeeLastName;
                txtMiddleName.Text = employee.EmployeeMiddleName;
                txtLeader.Text = employee.EmployeeTeamLeader;
                txtTeam.Text = employee.EmployeeTeam;
                txtFirstName.Enabled = false;
                txtMiddleName.Enabled = false;
                txtLastName.Enabled = false;
                txtLeader.Enabled = false;
                txtTeam.Enabled = false;

            }

            btnRegister.Enabled = true;
        }
    }
}
