using Client.Framework;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
	class WindowAddViewModel : ViewModelBase
	{
		public Bettor Model { get; set; }
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public string Firstname
		{
			get { return Model.Firstname; }

			set
			{
				if (Model.Firstname == value)
					return;
				Model.Firstname = value;
				OnPropertyChanged("Firstname");
			}
		}

		public string Lastname
		{
			get { return Model.Lastname; }

			set
			{
				if (Model.Lastname == value)
					return;
				Model.Lastname = value;
				OnPropertyChanged("Lastname");
			}
		}

		public string Nickname
		{
			get { return Model.Nickname; }

			set
			{
				if (Model.Nickname == value)
					return;
				Model.Nickname = value;
				OnPropertyChanged("Nickname");
			}
		}

		

	}
}
