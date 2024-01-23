using DataAccesLayer.Models;
using DataAccesLayer.Repository;

namespace Desktop.Bankomats;


public partial class Shifokorlar : UserControl
{
    public int UserId { get; set; }

    public string Fullname { get; set; }
    public bool IsSelected { get; set; }
    public DateTime SelectedTime { get; set; }

    public Shifokorlar(int userId, string fullName)
    {
        InitializeComponent();
        this.UserId = userId;
        this.Fullname = fullName;
    }

    private void Shifokorlar_Load(object sender, EventArgs e)
    {
        Ism.Text = Fullname;
    }

    private void guna2Panel1_Click(object sender, EventArgs e)
    {
        IsSelected = true;
        SelectedTime = DateTime.Now;
    }
}
