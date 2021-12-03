using System.Windows.Forms;

namespace ImageColorAnalizer.UI
{
    public partial class ClientForm : Form
    {
        private readonly string _login;
        private readonly string _serverAddress;

        public ClientForm(string login, string server)
        {
            _login = login;
            _serverAddress = server;

            InitializeComponent();
        }
    }
}
