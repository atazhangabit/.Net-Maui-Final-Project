using MauiFinalProject.Models;
using MauiFinalProject.ViewModels;

namespace MauiFinalProject;

public partial class StudentsPage : ContentPage
{
    StudentsViewModel vm;

    public StudentsPage()
    {
        InitializeComponent();

        vm = new StudentsViewModel();
        BindingContext = vm;
    }

    private void AddStudent_Clicked(object sender, EventArgs e)
    {
        vm.AddStudent(NameEntry.Text, CityEntry.Text);

        NameEntry.Text = "";
        CityEntry.Text = "";
    }

    private async void StudentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
        {
            return;
        }

        Student student = (Student)e.CurrentSelection[0];

        await Shell.Current.GoToAsync($"{nameof(StudentDetailPage)}?name={student.Name}&city={student.City}");

        StudentsList.SelectedItem = null;
    }
}