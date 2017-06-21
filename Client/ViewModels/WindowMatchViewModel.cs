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
		private ObservableCollection<WcfTeam> mTeams;

		public WcfMatch Match { get; set; }
		
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public DateTime DateTime
		{
			get
			{
				return Match.Date;
			}

			set
			{
				Match.Date = value;
			}
		}

		public ObservableCollection<WcfTeam> Teams
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

		public WcfTeam SelectedHomeTeam
		{
			get
			{
				return mTeams.ToList().Find(team => team.Id == Match.HomeTeamId);
			}

			set
			{
				if (Match.HomeTeamId == value.Id)
					return;
				Match.HomeTeamId = value.Id;
				Match.HomeTeamName = value.Name;
				//OnPropertyChanged("SelectedHomeTeam");
			}
		}

		public WcfTeam SelectedAwayTeam
		{
			get
			{
				return mTeams.ToList().Find(team => team.Id == Match.AwayTeamId);
			}

			set
			{
				if (Match.AwayTeamId == value.Id)
					return;
				Match.AwayTeamId = value.Id;
				Match.AwayTeamName = value.Name;
				//OnPropertyChanged("SelectedAwayTeam");
			}
		}
	}
}
