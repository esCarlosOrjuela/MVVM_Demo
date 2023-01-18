using Code.MVVM.ViewModels;

namespace Code.MVVM.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();
        BindingContext = new PersonViewModel();
    }
}
