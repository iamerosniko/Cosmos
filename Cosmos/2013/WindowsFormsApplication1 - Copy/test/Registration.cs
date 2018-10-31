using MetroFramework.Forms;

namespace test
{
    public partial class Registration : MetroForm
    {
        private string _eventName;
        public Registration(string EventName)
        {
            _eventName = EventName;
            InitializeComponent();
        }

        private void Registration_Load(object sender, System.EventArgs e)
        {
            this.Text = "Registration for " + _eventName;
        }
    }
}
