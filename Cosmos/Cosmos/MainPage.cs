using MetroFramework.Forms;
using System.Linq;
using System.Windows.Forms;

namespace Cosmos
{
    public partial class MainPage : MetroForm
    {
        public MainPage()
        {
            InitializeComponent();
            test();
        }

        public void test()
        {
            CosmosEntities cosmos = new CosmosEntities();
            var a = cosmos.Tables.Where(x => x.sample == "eros").FirstOrDefault();
            MessageBox.Show(a.sample);
        }
    }
}
