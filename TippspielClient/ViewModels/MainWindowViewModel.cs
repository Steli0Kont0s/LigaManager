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
		private WcfSeason mSelectedSeason;
		private List<WcfMatch> mSeasonMatches;
		private Visibility mMatchIsOver;
		private Visibility mMatchIsNotOver;
		private Visibility mShowBet;
		private Visibility mShowNotBet;
		private Boolean mBetIsEditable;

		public ICommand AddBetCommand { get; set; }
		public ICommand EditBetCommand { get; set; }
		public ICommand DeleteBetCommand { get; set; }
		

		public WcfBettor Bettor { get; set; }

		public ObservableCollection<WcfBet> Bets { get; set; }

		public List<WcfBettor> Bettors { get; set; }

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

		public WcfSeason SelectedSeason
		{
			get { return mSelectedSeason; }

			set
			{
				if (mSelectedSeason == value)
					return;
				mSelectedSeason = value;
				

				if (SelectedSeason != null)
				{
					mSeasonMatches = new List<WcfMatch>();
					foreach (WcfMatch match in WcfHelper.client.GetMatches(SelectedSeason))
					{
						mSeasonMatches.Add(match);
					}
					int NumberMatchDays = mSeasonMatches.OrderByDescending(match => match.MatchDay).First().MatchDay;

					MatchDays.Clear();
					for (int i = 1; i <= NumberMatchDays; i++)
					{
						MatchDays.Add(new MatchDay(mSeasonMatches, i));
					}


					Teams.Clear();
					foreach (WcfRelation relation in WcfHelper.client.GetRelationsBySeason(SelectedSeason))
					{
						TeamHelper team = new TeamHelper(relation);

						foreach (WcfMatch match in mSeasonMatches.Where(x => x.HomeTeamId == relation.TeamId))
						{
							team.NumberOfGames++;
							team.GoalsDifference = team.GoalsDifference + match.HomeTeamScore - match.AwayTeamScore;
							if (match.HomeTeamScore > match.AwayTeamScore) // Sieg
							{
								team.Points += 3;
								team.Wins++;
							}
							else if (match.HomeTeamScore < match.AwayTeamScore) // Niederlage
							{
								team.Defeats++;
							}
							else // Unentschieden
							{
								team.Points++;
								team.Draws++;
							}
						}

						foreach (WcfMatch match in mSeasonMatches.Where(x => x.AwayTeamId == relation.TeamId))
						{
							team.NumberOfGames++;
							team.GoalsDifference = team.GoalsDifference - match.HomeTeamScore + match.AwayTeamScore;
							if (match.HomeTeamScore < match.AwayTeamScore) // Sieg
							{
								team.Points += 3;
								team.Wins++;
							}
							else if (match.HomeTeamScore > match.AwayTeamScore) // Niederlage
							{
								team.Defeats++;
							}
							else // Unentschieden
							{
								team.Points++;
								team.Draws++;
							}
						}

						Teams.Add(team);
					}
					Teams = Teams.OrderByDescending(x => x.Points).ToList();
					int rank = 1;
					foreach (WcfTeam team in Teams)
					{
						team.Rank = rank;
						rank++;
					}

				}
			}

	
		}

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
				if(value != null)
				{
					mSelectedMatch = value;
					IEnumerable<WcfBet> listBets = Bets.Where(bet => bet.MatchId == mSelectedMatch.Id);
					if(listBets.Count() > 0)
					{
						mSelectedBet = listBets.First();
						if (DateTime.Compare(value.Date, DateTime.Now.AddMinutes(30)) > 0)
						{
							this.MatchIsOver = Visibility.Hidden;
							this.MatchIsNotOver = Visibility.Visible;
							this.BetIsEditable = true;
							ShowBet = Visibility.Visible;
							ShowNotBet = Visibility.Hidden;
						}
						else
						{
							this.MatchIsOver = Visibility.Visible;
							this.MatchIsNotOver = Visibility.Hidden;
							this.BetIsEditable = false;
							ShowBet = Visibility.Visible;
							ShowNotBet = Visibility.Hidden;
						}						
					}
					else
					{
						mSelectedBet = null;
						ShowBet = Visibility.Hidden;
						if (DateTime.Compare(value.Date, DateTime.Now.AddMinutes(30)) < 0)
							ShowNotBet = Visibility.Hidden;
						else
							ShowNotBet = Visibility.Visible;
					}
					
					OnPropertyChanged("SelectedBet");
					OnPropertyChanged("SelectedMatch");
					OnPropertyChanged("MatchIsOver");
					OnPropertyChanged("MatchIsNotOver");
					OnPropertyChanged("ShowBet");
					OnPropertyChanged("ShowNotBet");
					OnPropertyChanged("BetIsEditable");
				}
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

		public Visibility MatchIsOver
		{
			get { return mMatchIsOver; }
			set
			{
				mMatchIsOver = value;
				OnPropertyChanged("MatchIsOver");
			}
		}
		public Visibility MatchIsNotOver
		{
			get { return mMatchIsNotOver; }
			set
			{
				mMatchIsNotOver = value;
				OnPropertyChanged("MatchIsNotOver");
			}
		}
		public Visibility ShowBet
		{
			get { return mShowBet; }
			set
			{
				mShowBet = value;
				OnPropertyChanged("ShowBet");
			}
		}
		public Visibility ShowNotBet
		{
			get { return mShowNotBet; }
			set
			{
				mShowNotBet = value;
				OnPropertyChanged("ShowNotBet");
			}
		}
		public Boolean BetIsEditable
		{
			get { return mBetIsEditable; }
			set
			{
				mBetIsEditable = value;
				OnPropertyChanged("BetIsEditable");
			}
		}
	}
}
