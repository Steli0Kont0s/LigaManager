using Client.Framework;
using Client.ViewModels;
using Client.Views;
using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.Controller
{
	class WindowEditSeasonController
	{
		private WindowSeason mView;
		private WindowSeasonViewModel mViewModel;
		private WcfSeason Season;

		public WcfSeason EditSeason(WcfSeason season)
		{
			Season = season;
			mView = new WindowSeason();
			mViewModel = new WindowSeasonViewModel
			{
				Season = season,
				Matches = new ObservableCollection<WcfMatch>(),
				Teams = new ObservableCollection<TeamHelper>(),
				AllTeams = new ObservableCollection<WcfTeam>(),
				OkCommand = new RelayCommand(ExecuteOkCommand),
				CancelCommand = new RelayCommand(ExecuteCancelCommand),
				DeleteTeamCommand = new RelayCommand(ExecuteDeleteTeamCommand),
				AddTeamCommand = new RelayCommand(ExecuteAddTeamCommand),
				AddMatchCommand = new RelayCommand(ExecuteAddMatchCommand),
				EditMatchCommand = new RelayCommand(ExecuteEditMatchCommand),
				DeleteMatchCommand = new RelayCommand(ExecuteDeleteMatchCommand),
				GenerateMatchesCommand = new RelayCommand(ExecuteGenerateMatchesCommand)
			};
			ReloadMatches();
			ReloadAllTeams();
			ReloadTeams();
			mView.Title = season.Name;
			mView.DataContext = mViewModel;
			return mView.ShowDialog() == true ? mViewModel.Season : null;
		}

		private void ExecuteGenerateMatchesCommand(object obj)
		{
			WcfHelper.client.GenerateMatches(Season);
			ReloadMatches();
		}

		private void ExecuteOkCommand(object obj)
		{
			mView.DialogResult = true;
			mView.Close();
		}

		private void ExecuteCancelCommand(object obj)
		{
			mView.DialogResult = false;
			mView.Close();
		}

		private void ExecuteAddTeamCommand(object obj)
		{
			if(mViewModel.SelectedAllTeam != null)
			{
				WcfHelper.client.AddTeamToSeason(mViewModel.SelectedAllTeam, Season);
				ReloadTeams();
			}
		}

		private void ExecuteDeleteTeamCommand(object obj)
		{
			if(mViewModel.SelectedTeam != null)
			{
				WcfHelper.client.DeleteTeamFromSeason(mViewModel.SelectedTeam.GetTeam(), Season);
				mViewModel.SelectedTeam.Delete();
				ReloadTeams();
				ReloadMatches();
			}
		}

		private void ExecuteEditMatchCommand(object obj)
		{
			if(mViewModel.SelectedMatch != null)
			{
				EditMatch();
				ReloadMatches();
			}
		}

		private void ExecuteAddMatchCommand(object obj)
		{
			AddMatch();
			ReloadMatches();
		}

		private void ExecuteDeleteMatchCommand(object obj)
		{
			WcfHelper.client.DeleteMatch(mViewModel.SelectedMatch);
			ReloadMatches();
		}

		private void ReloadTeams()
		{
			mViewModel.Teams.Clear();
			foreach (WcfRelation relation in WcfHelper.client.GetRelationsBySeason(Season))
			{
				mViewModel.Teams.Add(new TeamHelper(relation));
			}
		}

		private void ReloadAllTeams()
		{
			mViewModel.AllTeams.Clear();
			foreach (WcfTeam team in WcfHelper.client.GetAllTeams())
			{
				mViewModel.AllTeams.Add(team);
			}
		}

		private void ReloadMatches()
		{
			mViewModel.Matches.Clear();
			foreach (WcfMatch match in WcfHelper.client.GetMatches(Season))
			{
				mViewModel.Matches.Add(match);
			}
		}

		private void EditMatch()
		{
			if(mViewModel.SelectedMatch != null)
			{
				WcfMatch EditedMatch = new WindowEditMatchController().EditMatch(mViewModel.SelectedMatch);
				if (EditedMatch != null)
				{
					WcfHelper.client.EditMatch(EditedMatch);
					ReloadMatches();
				}
			}
		}

		private void AddMatch()
		{
			WcfMatch AddMatch = new WindowAddMatchController().AddMatch(Season);
			if (AddMatch != null && (AddMatch.AwayTeamId != AddMatch.HomeTeamId))
			{
				WcfHelper.client.AddMatch(AddMatch);
				ReloadMatches();
			}
		}
	}
}
