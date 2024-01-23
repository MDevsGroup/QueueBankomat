using DataAccesLayer.Repositories;
using DataAccesLayer.Repository;

namespace Desktop.Bankomats;


public partial class Shifokorlar : UserControl
{
    private readonly IUserInterface _userInterface;
    private readonly IClientInterface _clientInterface;

    public int UserId { get; set; }
    public bool IsSelected { get; set; }
    public string FullName { get; set; } = string.Empty;   
    public DateTime SelectedTime { get; set; }

    public Shifokorlar(int userId, string fullName, IUserInterface userInterface, IClientInterface clientInterface)
    {
        InitializeComponent();
        this.UserId = userId;
        _userInterface = userInterface;
        _clientInterface = clientInterface;
        FullName = fullName;
    }

    private async void Shifokorlar_Load(object sender, EventArgs e)
    {
      
            FormLoad();

       
    }

    private void guna2Panel1_Click(object sender, EventArgs e)
    {
        IsSelected = true;
        SelectedTime = DateTime.Now;
    }


    private async void FormLoad()
    {
        var users = await _userInterface.GetOnlineUsers();
        var user = users.FirstOrDefault(i => i.Id == UserId);
        Ism.Text = user.FirstName + " " + user.LastName;
        level.Text = user.Lavozimi;
        count.Text = _clientInterface.CountAllClient(UserId).ToString();
    }
}
