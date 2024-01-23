

// Bankomat Form
using DataAccesLayer.Models;
using DataAccesLayer.Repositories;
using DataAccesLayer.Repository;
using Timer = System.Windows.Forms.Timer;

namespace Desktop.Bankomats
{
    public partial class Bankomat : Form
    {
        private readonly IUserInterface _userInterface;
        private readonly IClientInterface _clientInterface;
        private int SelectedUserId;
        private List<Shifokorlar> shifokorlar = new();
        private List<User> _users = new();
        private Shifokorlar _tanlangan;

        public Bankomat(IUserInterface userInterface, IClientInterface clientInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
            _clientInterface = clientInterface;
        }

        private void CheckSelected_Sh(object? sender, EventArgs e)
        {
            _tanlangan = shifokorlar.Where(sh => sh.IsSelected == true)
                                       .OrderByDescending(sh => sh.SelectedTime)
                                       .FirstOrDefault();
            if (_tanlangan != null)
            {
                tanlanganSh.Text = $"Tanlandi: {_tanlangan.FullName}";
            }
            else
            {
                tanlanganSh.Text = "";
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var users = await _userInterface.GetOnlineUsers();

            if (!users.Any() && _users.Any())
            {
                MainPanel.Controls.Clear();
                _users.Clear();
            }
            // comment
            var NoDiff = users.All(u => _users.Any(x => x.Id == u.Id));
            if ((!NoDiff || !_users.Any()))
            {
                var clientCount = _clientInterface.CountAllClient(SelectedUserId);

                MainPanel.Controls.Clear();

                foreach (var user in users)
                {
                    Shifokorlar shifokor = new Shifokorlar(user.Id, $"{user.FirstName} {user.LastName}", _userInterface, _clientInterface);


                    Timer timer2 = new();
                    timer2.Interval = 500;
                    timer2.Tick += CheckSelected_Sh;
                    timer2.Start();
                    MainPanel.Controls.Add(shifokor);
                    shifokorlar.Add(shifokor);
                    _users.Add(user);
                }
            }
        }

        private void Bankomat_Load(object sender, EventArgs e)
        {
            Timer timer1 = new();
            timer1.Interval = 1000;
            timer1.Tick += guna2Button1_Click;
            timer1.Start();
        }

        private async void NavbatBtn_Click(object sender, EventArgs e)
        {
            _tanlangan.IsSelected = false;
            await _clientInterface.Create(_tanlangan.UserId, DateTime.Now);
        }
    }
}

