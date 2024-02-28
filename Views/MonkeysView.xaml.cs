using MonkeyCollection.ViewModels;

namespace MonkeyCollection.Views;

public partial class MonkeysView : ContentPage
{
	public MonkeysView(MonkeysViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}
