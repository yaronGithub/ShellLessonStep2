using System.Windows.Input;

namespace ShellLessonStep2;

public partial class AppShell : Shell
{
	public AppShell()
	{
        this.BindingContext = this;
        InfoCommand = new Command(OnInfoClicked);
        InitializeComponent();
		
	}

	public ICommand InfoCommand { get; set; }
	private void OnInfoClicked()
	{
		DisplayAlert("Info", "This is a demo for using Shell!", "Ok");
	}
}
