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
	class WindowBettorViewModel : ViewModelBase
	{
		public WcfBettor Bettor { get; set; }
		public string Title { get; set; }
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public string Firstname
		{
			get { return Bettor.Firstname; }

			set
			{
				if (Bettor.Firstname == value)
					return;
				Bettor.Firstname = value;
				OnPropertyChanged("Firstname");
			}
		}

		public string Lastname
		{
			get { return Bettor.Lastname; }

			set
			{
				if (Bettor.Lastname == value)
					return;
				Bettor.Lastname = value;
				OnPropertyChanged("Lastname");
			}
		}

		public string Nickname
		{
			get { return Bettor.Nickname; }

			set
			{
				if (Bettor.Nickname == value)
					return;
				Bettor.Nickname = value;
				OnPropertyChanged("Nickname");
			}
		}

		

	}
}
