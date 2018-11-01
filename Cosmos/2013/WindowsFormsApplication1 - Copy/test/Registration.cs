using MetroFramework.Forms;
using test.BW;

namespace test
{
    public partial class Registration : MetroForm
    {
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
        }
    }
}
