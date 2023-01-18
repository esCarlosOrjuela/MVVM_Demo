using Code.MVVM.ViewModels;

namespace Code.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		BindingContext = new ConvertesViewModels();
	}
}
