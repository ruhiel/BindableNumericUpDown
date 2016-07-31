using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new TestBindObject() { A = 10, B = 30 };
		}
		private void ButtonDispClick(object sender, RoutedEventArgs e)
		{
			var bindingData = DataContext as TestBindObject;
			if (bindingData != null)
			{
				MessageBox.Show("内部値は : " + bindingData.A.ToString());
			}
		}
		private void ButtonSetClick(object sender, RoutedEventArgs e)
		{
			var bindingData = DataContext as TestBindObject;
			if (bindingData != null)
			{
				bindingData.A = 100;
			}
		}
	}
}
