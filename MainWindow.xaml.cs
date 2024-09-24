using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Resourcess
{
	//Resources-->1)Dynamice and 2)Static
	//In Basics of wpf we had static resource
	//Static Resource-->resolved at compile time,value set when working with xaml
	//Dynamic Resource-->resolved at run time,value of object evaluated and stored in expression and the value is substituded at run time
	//Styles,templattes ets-->static
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Gray); // Default color
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Red);
		}
		private void button3_Click(object sender, RoutedEventArgs e)
		{
			this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Blue);
		}
	}
}