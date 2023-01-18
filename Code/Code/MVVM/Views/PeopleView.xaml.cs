namespace Code.MVVM.Views;

public partial class PeopleView : ContentPage
{
    public PeopleView()
    {
        InitializeComponent();
        BindingContext = new ViewModels.PeopleViewModel();
    }
}
