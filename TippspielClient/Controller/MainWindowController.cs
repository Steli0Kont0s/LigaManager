﻿using Client.Framework;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TippspielClient.ViewModels;
using TippspielClient.Views;

namespace TippspielClient.Controller
{
	class MainWindowController
	{
		private List<WcfMatch> SeasonMatches;
		private int MatchDays = 0;
		public MainWindow mView;
		public MainWindowViewModel mViewModel;

		public MainWindowController(WcfBettor bettor)
		{
			SeasonMatches = new List<WcfMatch>();
			mView = new MainWindow();
			mViewModel = new MainWindowViewModel
			{
				Bettor = bettor,
				Seasons = new ObservableCollection<WcfSeason>(),
				MatchDays = new ObservableCollection<MatchDay>(),
				Bets = new ObservableCollection<WcfBet>(),
				Teams = new List<TeamHelper>(),
				MatchIsNotOver = System.Windows.Visibility.Hidden,
				MatchIsOver = System.Windows.Visibility.Hidden,
				ShowBet = System.Windows.Visibility.Hidden,
				AddBetCommand = new RelayCommand(ExecuteAddBetCommand),
				EditBetCommand = new RelayCommand(ExecuteEditBetCommand),
				DeleteBetCommand = new RelayCommand(ExecuteDeleteBetCommand)
			};
			ReloadSeasons();
			ReloadBets();

			mView.DataContext = mViewModel;

			mView.ShowDialog();
		}


		private void ExecuteAddBetCommand(Object obj)
		{
			WcfBet newBet = new WcfBet();
			newBet.MatchId = mViewModel.SelectedMatch.Id;
			newBet.BettorId = mViewModel.Bettor.Id;
			newBet.HomeTeamScore = 0;
			newBet.AwayTeamScore = 0;
			newBet.Date = DateTime.Now;
			mViewModel.Bets.Add(newBet);
			WcfHelper.client.AddBet(newBet);
		}

		private void ExecuteEditBetCommand(Object obj)
		{
			if(mViewModel.SelectedBet != null)
				WcfHelper.client.EditBet(mViewModel.SelectedBet);
			ReloadBets();
		}

		private void ExecuteDeleteBetCommand(Object obj)
		{
			if (mViewModel.SelectedBet != null)
			{
				WcfHelper.client.DeleteBet(mViewModel.SelectedBet);
				mViewModel.Bets.Remove(mViewModel.SelectedBet);
			}
			ReloadBets();
		}


		private void ReloadSeasons()
		{
			mViewModel.Seasons.Clear();
			foreach(WcfSeason season in WcfHelper.client.GetAllSeasons())
			{
				mViewModel.Seasons.Add(season);
			}
			mViewModel.SelectedSeason = mViewModel.Seasons.First();
			ReloadMatches();
			ReloadTeams();
		}

		private void ReloadTeams()
		{ 
			if(mViewModel.SelectedSeason != null)
			{

				mViewModel.Teams.Clear();
				foreach (WcfRelation relation in WcfHelper.client.GetRelationsBySeason(mViewModel.SelectedSeason))
				{
					TeamHelper team = new TeamHelper(relation);

					foreach (WcfMatch match in SeasonMatches.Where(x => x.HomeTeamId == relation.TeamId))
					{
						team.NumberOfGames++;
						team.GoalsDifference = team.GoalsDifference + match.HomeTeamScore - match.AwayTeamScore;
						if (match.HomeTeamScore > match.AwayTeamScore) // Sieg
						{
							team.Points += 3;
							team.Wins++;
						}
						else if(match.HomeTeamScore < match.AwayTeamScore) // Niederlage
						{
							team.Defeats++;
						}
						else // Unentschieden
						{
							team.Points++;
							team.Draws++;
						}
					}

					foreach (WcfMatch match in SeasonMatches.Where(x => x.AwayTeamId == relation.TeamId))
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

					mViewModel.Teams.Add(team);
				}
				mViewModel.Teams = mViewModel.Teams.OrderByDescending(x => x.Points).ToList();
				int rank = 1;
				foreach(WcfTeam team in mViewModel.Teams)
				{
					team.Rank = rank;
					rank++;
				}
				
			}
		}

		private void ReloadMatches()
		{
			if(mViewModel.SelectedSeason != null)
			{
				SeasonMatches.Clear();
				foreach(WcfMatch match in WcfHelper.client.GetMatches(mViewModel.SelectedSeason))
				{
					SeasonMatches.Add(match);
				}
				MatchDays = SeasonMatches.OrderByDescending(match => match.MatchDay).First().MatchDay;
				ReloadMatchDays();
			}
		}

		private void ReloadMatchDays()
		{
			mViewModel.MatchDays.Clear();
			for(int i = 1; i <= MatchDays; i++)
			{
				mViewModel.MatchDays.Add(new MatchDay(SeasonMatches, i));
			}
		}

		private void ReloadBets()
		{
			mViewModel.Bets.Clear();
			foreach(WcfBet bet in WcfHelper.client.GetBets(mViewModel.Bettor))
			{
				mViewModel.Bets.Add(bet);
			}
		}
	}
}
