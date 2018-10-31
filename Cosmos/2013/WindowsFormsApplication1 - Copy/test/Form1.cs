using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            testEntities test = new testEntities();
            var a = test.testtable1.Where(x => x.name == "eros").FirstOrDefault();
            MessageBox.Show(a.name);
        }
    }
}
