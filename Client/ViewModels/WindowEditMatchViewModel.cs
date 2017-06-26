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
	class WindowEditMatchViewModel : ViewModelBase
	{
		private ObservableCollection<TeamHelper> mTeams;

		public WcfMatch Match { get; set; }
		
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }

		public int HomeTeamScore
		{
			get
			{
				return Match.HomeTeamScore;
			}

			set
			{
				Match.HomeTeamScore = value;
			}
		}

		public int AwayTeamScore
		{
			get
			{
				return Match.AwayTeamScore;
			}

			set
			{
				Match.AwayTeamScore = value;
			}
		}

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
	}
}
