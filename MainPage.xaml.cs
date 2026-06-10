using MauiFinalProject.ViewModels;

namespace MauiFinalProject;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new Person();
    }

    private async void OpenStudents_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }
}