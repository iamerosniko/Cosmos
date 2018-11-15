using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using test.BW;

namespace test
{
    public partial class Main : MetroForm
    {

        testEntities context;
        BW_Employees myemployees;
        BW_Events myevents;
        BW_EventRegistration myeventRegistration;
        public Main()
        {
            InitializeComponent();
            CheckFolders();
            context = new testEntities();
            myemployees = new BW_Employees(context);
            myevents = new BW_Events(context);
            myeventRegistration = new BW_EventRegistration(context);
        }

        public void CheckFolders()
        {
            string exportPath = ".\\Export"; // your code goes here
            string eventThemePath = ".\\Event Theme"; // your code goes here

            bool isExportExists = System.IO.Directory.Exists(exportPath);
            bool isEventThemePathExists = System.IO.Directory.Exists(eventThemePath);

            if (!isExportExists)
                System.IO.Directory.CreateDirectory(exportPath);
            if (!isEventThemePathExists)
                System.IO.Directory.CreateDirectory(eventThemePath);
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
                EmployeeFirstName = txtFname.Text.Trim(),
                EmployeeLastName = txtLname.Text.Trim(),
                EmployeeMiddleName = txtMname.Text.Trim(),
                EmployeeTeam = txtTeam.Text.Trim(),
                EmployeeTeamLeader = txtTeamLeader.Text.Trim(),
                WorkdayID = txtWorkdayID.Text.Trim()
            };

            if (isEmployee.WorkdayID.Equals(""))
            {
                MessageBox.Show("Workday ID is Required.");
            }
            else if (isEmployee.EmployeeFirstName.Equals(""))
            {
                MessageBox.Show("First Name is Required.");
            }
            else if (isEmployee.EmployeeLastName.Equals(""))
            {
                MessageBox.Show("Last Name is Required.");
            }
            else if (isEmployee.EmployeeTeam.Equals(""))
            {
                MessageBox.Show("Team is Required.");
            }
            else if (isEmployee.EmployeeTeamLeader.Equals(""))
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
        private void btnBulk_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json File(*.json)|*.json";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                using (StreamReader r = new StreamReader(file))
                {
                    var json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<IS_Employees>>(json);
                    //bulk insert
                    txtBulkEmployees.Clear();
                    MessageBox.Show("Total of Items : " + items.Count + "\nThis will take a few moment.");

                    foreach (var item in items)
                    {
                        var a = myemployees.Post(item);
                        if (!a)
                        {
                            txtBulkEmployees.Text += "Existing Employee Item. Will Replaced with new data : " + item.WorkdayID + " " + item.EmployeeFirstName + " " + item.EmployeeLastName + Environment.NewLine;
                        }
                        else
                        {
                            txtBulkEmployees.Text += "New Employee Item : " + item.WorkdayID + Environment.NewLine;

                        }
                    }
                }
            }
            MessageBox.Show("Bulk Insertion Completed");
            btnRefresh_Click(sender, e);
        }

        public void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetEmployees();
            GetEvents();
            GetRegisteredEvents();
            GetRegisteredEmployees();
        }

        #endregion

        #region EVENTS
        private void cmbEvent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnEventCheck_Click(sender, e);
            }
            catch
            {

            }
        }

        public void GetRegisteredEvents()
        {
            List<IS_Events> events = new List<IS_Events>();
            var eventsTemp = myevents.Get();

            events.Add(new IS_Events { EventID = 0, EventName = "All" });

            foreach (var a in eventsTemp)
            {
                events.Add(a);
            }
            cmbEventFilter.DataSource = events;
            cmbEventFilter.DisplayMember = "EventName";
            cmbEventFilter.ValueMember = "EventID";
        }

        public void GetEvents()
        {
            var listEvents = myevents.Get();
            GridEvents.DataSource = listEvents;
            GridEvents.Columns[0].Visible = false;
            GridEvents.Columns[1].HeaderText = "Event";
            GridEvents.Columns[2].HeaderText = "Event Date";
            GridEvents.Columns[3].HeaderText = "Venue";
            GridEvents.Columns[4].HeaderText = "Image Theme";
            GridEvents.Columns[5].Visible = false;
            GridEvents.Columns[6].HeaderText = "Waiver";

            cmbEvent.DataSource = listEvents;
            cmbEvent.DisplayMember = "EventName";
            cmbEvent.ValueMember = "EventID";
        }
        private void btnEventThemeFIleSearcher_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg";
            int size = -1;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    txtEventThemePath.Text = openFileDialog.SafeFileName;
                    string text = File.ReadAllText(file);
                    size = text.Length;

                    string targetPath = @".\Event Theme";
                    File.Copy(openFileDialog.FileName, targetPath + @"\" + openFileDialog.SafeFileName, true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void btnWaiver_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Document Files (*.docx)|*.docx";
            int size = -1;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    txtWaiver.Text = openFileDialog.SafeFileName;
                    string text = File.ReadAllText(file);
                    size = text.Length;

                    string targetPath = @".\Event Theme";
                    File.Copy(openFileDialog.FileName, targetPath + @"\" + openFileDialog.SafeFileName, true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEventCheck_Click(object sender, System.EventArgs e)
        {
            try
            {
                var a = myevents.Get().Find(x => x.EventID.ToString() == cmbEvent.SelectedValue.ToString());
                txtDeetsEventDate.Text = a.EventDate;
                txtDeetsVenue.Text = a.EventLocation;
                btnGoEventRegistration.Enabled = !txtDeetsEventDate.Text.Equals("");
            }
            catch
            {
                btnGoEventRegistration.Enabled = !txtDeetsEventDate.Text.Equals("");
            }
        }

        private void btnGoEventRegistration_Click(object sender, System.EventArgs e)
        {
            var a = myevents.Get().Find(x => x.EventID.ToString() == cmbEvent.SelectedValue.ToString());
            Registration r = new Registration(a.EventID.ToString(), context, this);
            r.ShowDialog();
        }

        private void btnSaveEvent_Click(object sender, System.EventArgs e)
        {
            IS_Events isEvent = new IS_Events
            {
                EventDate = txtEventDate.Value.ToShortDateString(),
                EventLocation = txtVenue.Text.Trim(),
                EventName = txtEventName.Text.Trim(),
                EventTheme = txtEventThemePath.Text.Trim(),
                EventIsDark = chkbIsWhiteFont.Checked ? long.Parse("1") : long.Parse("0"),
                EventEULA = txtWaiver.Text.Trim()
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
            //else if ()
            else
            {
                var result = myevents.Post(isEvent);
                if (result == true) MessageBox.Show("Event Successfully Added."); else MessageBox.Show("Workday ID Already Exists.");
                txtEventDate.Value = DateTime.Now;
                txtVenue.Clear();
                txtEventName.Clear();
                txtEventThemePath.Clear();
                txtWaiver.Clear();
                btnRefresh_Click(sender, e);
            }
        }

        #endregion

        #region EVENTREGISTRATION
        public void GetRegisteredEmployees()
        {
            if (cmbEventFilter.SelectedValue.ToString() != "0")
            {
                var a = myeventRegistration.Get();
                a = a.Where(x => x.EventID == cmbEventFilter.SelectedValue.ToString()).ToList();
                GridEventRegistered.DataSource = a;
            }
            else
            {
                GridEventRegistered.DataSource = myeventRegistration.Get();
            }
            try
            {

                GridEventRegistered.Columns[0].HeaderText = "Event";
                GridEventRegistered.Columns[1].HeaderText = "Workday ID";
                GridEventRegistered.Columns[2].HeaderText = "Employee";
                GridEventRegistered.Columns[3].HeaderText = "Team Name";
                GridEventRegistered.Columns[4].HeaderText = "Team Leader";
                GridEventRegistered.Columns[5].HeaderText = "Date Registered";
                GridEventRegistered.Columns[7].Visible = false;

            }
            catch
            {

            }
        }
        #endregion

        #region REPORTS
        private void TileRptEmp_Click(object sender, EventArgs e)
        {
            try
            {
                GridEmployees.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                // Select all the cells
                GridEmployees.SelectAll();
                DataObject dataObject = GridEmployees.GetClipboardContent();
                // Copy selected cells to DataObject
                var filename = "Employees_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + ".csv";
                // Get the text of the DataObject, and serialize it to a file
                File.WriteAllText(".\\Export\\" + filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                System.Diagnostics.Process.Start("explorer.exe", @".\Export");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TileRptEvent_Click(object sender, EventArgs e)
        {
            try
            {
                GridEvents.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                // Select all the cells
                GridEvents.SelectAll();
                // Copy selected cells to DataObject
                DataObject dataObject = GridEvents.GetClipboardContent();
                var filename = "Events_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + ".csv";
                // Get the text of the DataObject, and serialize it to a file
                File.WriteAllText(".\\Export\\" + filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                System.Diagnostics.Process.Start("explorer.exe", @".\Export");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TileRptEventRegistration_Click(object sender, EventArgs e)
        {
            try
            {

                GridEventRegistered.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                // Select all the cells
                GridEventRegistered.SelectAll();
                // Copy selected cells to DataObject
                DataObject dataObject = GridEventRegistered.GetClipboardContent();
                var filename = "EventsRegistered_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + ".csv";
                // Get the text of the DataObject, and serialize it to a file
                File.WriteAllText(".\\Export\\" + filename, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                System.Diagnostics.Process.Start("explorer.exe", @".\Export");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        private void Main_Load(object sender, System.EventArgs e)
        {
            cmbEvent.Text = "";
            GetEmployees();
            GetEvents();
            GetRegisteredEvents();
            GetRegisteredEmployees();
            btnEventCheck_Click(sender, e);
        }


        private void cmbEventFilter_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbEventFilter.SelectedValue.ToString());
            GetRegisteredEmployees();
        }
    }
}
