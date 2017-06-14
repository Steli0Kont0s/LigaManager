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
	class WindowTeamViewModel : ViewModelBase
	{
		public WcfTeam team { get; set; }
		public string Title { get; set; }
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public string Name
		{
			get { return team.Name; }

			set
			{
				if (team.Name == value)
					return;
				team.Name = value;
				OnPropertyChanged("Firstname");
			}
		}	

	}
}
