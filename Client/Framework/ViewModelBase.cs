using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Framework
{
	public delegate void MyEventHandler(object sender, EventArgs e);
	public abstract class ViewModelBase
	{
		public interface InotifyPropertyChanged
		{

		}

		public event MyEventHandler PropertyChanged;

		public void OnPropertyChanged(string propertyName)
		{
			if(PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
