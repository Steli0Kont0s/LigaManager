using Client.Framework;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TippspielClient.ViewModels
{
	class MainWindowViewModel : ViewModelBase
	{
		private WcfMatch mSelectedMatch;
		private MatchDay mSelectedMatchDay;

		public WcfBettor Bettor { get; set; }

		public List<WcfBet> Bets { get; set; }

		public WcfBet Bet { get; set; }

		public string FirstName
		{
			get
			{
				return Bettor.Firstname;
			}

			set
			{
				Bettor.Firstname = value;
			}
		}

		public string LastName
		{
			get
			{
				return Bettor.Lastname;
			}

			set
			{
				Bettor.Lastname = value;
			}
		}

		public string NickName
		{
			get
			{
				return Bettor.Nickname;
			}

			set
			{
				Bettor.Nickname = value;
			}
		}

		public List<WcfSeason> Seasons { get; set; }

		public WcfSeason SelectedSeason { get; set; }

		public List<MatchDay> MatchDays { get; set; }

		public MatchDay SelectedMatchDay
		{
			get
			{
				return mSelectedMatchDay;
			}

			set
			{
				if (mSelectedMatchDay == value)
					return;
				mSelectedMatchDay = value;
				OnPropertyChanged("SelectedMatchDay");
			}
		}

		public WcfMatch SelectedMatch
		{
			get { return mSelectedMatch; }
			set
			{
				mSelectedMatch = value;
				OnPropertyChanged("SelectedMatch");
				Bet = Bets.Where(bet => bet.MatchId == mSelectedMatch.Id).First();
				MessageBox.Show(Bet.MatchId.ToString());
			}
		}
	}
}
