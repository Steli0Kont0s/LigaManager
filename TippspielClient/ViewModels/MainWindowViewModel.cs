using TippspielClient.Framework;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TippspielClient.ViewModels
{
	class MainWindowViewModel : ViewModelBase
	{

		private WcfMatch mSelectedMatch;
		private MatchDay mSelectedMatchDay;
		private List<TeamHelper> mTeams;
		private WcfBet mSelectedBet;

		public ICommand AddBetCommand { get; set; }
		public ICommand EditBetCommand { get; set; }
		public ICommand DeleteBetCommand { get; set; }

		public WcfBettor Bettor { get; set; }

		public ObservableCollection<WcfBet> Bets { get; set; }

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

		public List<TeamHelper> Teams
		{
			get { return mTeams; }
			set
			{
				if (value == mTeams)
					return;
				mTeams = value;
				OnPropertyChanged("Teams");
			}
		}

		public ObservableCollection<WcfSeason> Seasons { get; set; }

		public WcfSeason SelectedSeason { get; set; }

		public ObservableCollection<MatchDay> MatchDays { get; set; }

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
				this.SelectedBet = Bets.Where(bet => bet.MatchId == mSelectedMatch.Id).First();
				if(DateTime.Compare(value.Date, DateTime.Now.AddMinutes(30)) > 0)
				{
					this.MatchIsOver = Visibility.Hidden;
					this.MatchIsNotOver = Visibility.Visible;
					this.BetIsEditable = true;
				}
				else
				{
					this.MatchIsOver = Visibility.Visible;
					this.MatchIsNotOver = Visibility.Hidden;
					this.BetIsEditable = false;
				}
				if(this.SelectedBet == null)
				{
					ShowBet = Visibility.Hidden;
				}
				else
				{
					ShowBet = Visibility.Visible;
				}
				OnPropertyChanged("SelectedMatch");
				OnPropertyChanged("MatchIsOver");
				OnPropertyChanged("MatchIsNotOver");
				OnPropertyChanged("ShowBet");
				OnPropertyChanged("BetIsEditable");
			}
		}

		public WcfBet SelectedBet
		{
			get { return mSelectedBet; }
			set
			{
				mSelectedBet = value;
				OnPropertyChanged("SelectedBet");
			}
		}

		public Visibility MatchIsOver { get; set; }
		public Visibility MatchIsNotOver { get; set; }
		public Visibility ShowBet { get; set; }
		public Boolean BetIsEditable { get; set; }
	}
}
