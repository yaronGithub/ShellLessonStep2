using MonkeyCollection.ViewModels;

namespace MonkeyCollection.Views;

public partial class MonkeyDetailsView : ContentPage
{
	public MonkeyDetailsView(MonkeyDetailsViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}
