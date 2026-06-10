using System.Xml;

namespace MauiFinalProject;

[QueryProperty(nameof(StudentName), "name")]
[QueryProperty(nameof(StudentCity), "city")]
public partial class StudentDetailPage : ContentPage
{
    public StudentDetailPage()
    {
        InitializeComponent();
    }

    public string StudentName
    {
        set
        {
            NameLabel.Text = value;
        }
    }

    public string StudentCity
    {
        set
        {
            CityLabel.Text = "City: " + value;
        }
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}