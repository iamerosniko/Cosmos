﻿using MetroFramework.Forms;
using System;
using System.IO;
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
            context = new testEntities();
            myemployees = new BW_Employees(context);
            myevents = new BW_Events(context);
            myeventRegistration = new BW_EventRegistration(context);
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

        public void btnRefresh_Click(object sender, System.EventArgs e)
        {
            GetEmployees();
            GetEvents();
            GetRegisteredEmployees();
        }

        #endregion

        #region EVENTS

        public void GetEvents()
        {
            var listEvents = myevents.Get();
            GridEvents.DataSource = listEvents;
            GridEvents.Columns[0].Visible = false;
            GridEvents.Columns[1].HeaderText = "Event";
            GridEvents.Columns[2].HeaderText = "Event Date";
            GridEvents.Columns[3].HeaderText = "Venue";
            cmbEvent.DataSource = listEvents;
            cmbEvent.DisplayMember = "EventName";
            cmbEvent.ValueMember = "EventID";
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
            Registration r = new Registration(a.EventID.ToString(), context, this);
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

        #endregion

        #region EVENTREGISTRATION
        public void GetRegisteredEmployees()
        {
            GridEventRegistered.DataSource = myeventRegistration.Get();
            GridEventRegistered.Columns[0].HeaderText = "Event";
            GridEventRegistered.Columns[1].HeaderText = "Workday ID";
            GridEventRegistered.Columns[2].HeaderText = "Employee";
            GridEventRegistered.Columns[3].HeaderText = "Date Registered";
        }
        #endregion
        private void Main_Load(object sender, System.EventArgs e)
        {
            GetEmployees();
            GetEvents();
            GetRegisteredEmployees();
        }


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
    }
}
