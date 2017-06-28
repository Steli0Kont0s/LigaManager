using Client.Framework;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
	class WindowAddSeasonViewModel : ViewModelBase
	{
		public WcfSeason Season { get; set; }
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public string Name
		{
			get { return Season.Name; }

			set
			{
				if (Season.Name == value)
					return;
				Season.Name = value;
			}
		}

		public string Description
		{
			get { return Season.Description; }

			set
			{
				if (Season.Description == value)
					return;
				Season.Description = value;
			}
		}
	}
}
