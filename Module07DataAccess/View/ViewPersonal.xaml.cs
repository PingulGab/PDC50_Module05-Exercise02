using Module07DataAccess.Services;
using Module07DataAccess.ViewModel;

namespace Module07DataAccess.View;

public partial class ViewPersonal : ContentPage
{
	public ViewPersonal()
	{
		InitializeComponent();
		
		var employeeViewModel = new EmployeeViewModel();
		BindingContext = employeeViewModel;
	}

	private async void OnViewMainPageClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//MainPage");
    }
}