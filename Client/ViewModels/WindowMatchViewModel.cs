using Client.Framework;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
	class WindowMatchViewModel : ViewModelBase
	{
		private TeamHelper mSelectedTeam;
		private ObservableCollection<TeamHelper> mTeams;

		public WcfMatch Match { get; set; }

		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public ObservableCollection<TeamHelper> Teams
		{
			get { return mTeams; }

			set
			{
				if (mTeams == value)
					return;
				mTeams = value;
				OnPropertyChanged("Teams");
			}
		}

		public TeamHelper SelectedTeam
		{
			get { return mSelectedTeam; }

			set
			{
				if (mSelectedTeam == value)
					return;
				mSelectedTeam = value;
				OnPropertyChanged("SelectedTeam");
			}
		}
	}
}
