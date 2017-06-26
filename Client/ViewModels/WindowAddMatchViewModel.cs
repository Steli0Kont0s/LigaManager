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
	class WindowAddMatchViewModel : ViewModelBase
	{
		private ObservableCollection<TeamHelper> mTeams;

		public WcfMatch Match { get; set; }
		
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public int MatchDay
		{
			get
			{
				return Match.MatchDay;
			}

			set
			{
				Match.MatchDay = value;
			}
		}

		public int Hour
		{
			get
			{
				return Match.Date.Hour;
			}

			set
			{
				if (value < 24)
					Match.Date = Match.Date.Date.Add(new TimeSpan(value, Minute, 0));
				else
					return;
			}
		}

		public int Minute
		{
			get
			{
				return Match.Date.Minute;
			}

			set
			{
				if (value < 60)
					Match.Date = Match.Date.Date.Add(new TimeSpan(Hour, value, 0));
				else
					return;
			}
		}

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

		public TeamHelper SelectedHomeTeam
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

		public TeamHelper SelectedAwayTeam
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
