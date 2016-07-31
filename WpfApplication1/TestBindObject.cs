using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
	using System.ComponentModel;
	internal class TestBindObject : INotifyPropertyChanged
	{
		private int a;
		private int b;

		public int A
		{
			get { return a; }
			set
			{
				a = value;
				NotifyPropertyChanged("A");
			}
		}

		public int B
		{
			get { return b; }
			set
			{
				b = value;
				NotifyPropertyChanged("B");
			}
		}

		private void NotifyPropertyChanged(string parameter)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(parameter));
		}
		public event PropertyChangedEventHandler PropertyChanged = (s, e) => { };
	}
}
