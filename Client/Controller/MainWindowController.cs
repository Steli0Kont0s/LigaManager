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
	class MainWindowController
	{
		private MainWindowViewModel mViewModel;
		public void Initialize()
		{
			var view = new MainWindow();
			mViewModel = new MainWindowViewModel
			{
				SelectedTab = 0,
				Bettors = new ObservableCollection<WcfBettor>(),
				Teams = new ObservableCollection<WcfTeam>(),
				Seasons = new ObservableCollection<WcfSeason>(),
				ButtonAdd = new RelayCommand(AddCommandExecute),
				ButtonEdit = new RelayCommand(EditCommandExecute, CommandCanExecute),
				ButtonDelete = new RelayCommand(DeleteCommandExecute, CommandCanExecute)
			};
			view.DataContext = mViewModel;

			WcfHelper.Initialize(); // Erstelle Wcf Service

			// Daten Laden
			ReloadBettors();
			ReloadSeasons();
			ReloadTeams();	
			
			view.ShowDialog();
		}

		private void ReloadBettors()
		{
			mViewModel.Bettors.Clear();
			foreach (WcfBettor bettor in WcfHelper.client.GetAllBettors())
			{
				mViewModel.Bettors.Add(bettor);
			}
		}

		private void ReloadTeams()
		{
			mViewModel.Teams.Clear();
			foreach (WcfTeam team in WcfHelper.client.GetAllTeams())
			{
				mViewModel.Teams.Add(team);
			}
		}

		private void ReloadSeasons()
		{
			mViewModel.Seasons.Clear();
			foreach (WcfSeason season in WcfHelper.client.GetAllSeasons())
			{
				mViewModel.Seasons.Add(season);
			}
		}

		private void DeleteBettor()
		{
			if (mViewModel.SelectedBettor != null)
			{
				if (WcfHelper.client.GetBets(mViewModel.SelectedBettor).Count() == 0)
				{
					WcfHelper.client.DeleteBettor(mViewModel.SelectedBettor);
					mViewModel.Bettors.Remove(mViewModel.SelectedBettor);
					ReloadBettors();
				}
				else
				{
					// Bettor kann nicht gelöscht werden, da er noch bets besitzt
					MessageBox.Show("Can't delete Bettor while he still has bets.");
				}

			}
		}

		private void AddBettor()
		{
			var addedObject = new WindowAddBettorController().AddBettor();
			if (addedObject != null)
			{
				WcfHelper.client.AddBettor(addedObject);
				ReloadBettors();
			}
		}

		private void EditBettor()
		{
			if(mViewModel.SelectedBettor != null)
			{
				WcfBettor editedBettor = new WindowEditBettorController().EditBettor(mViewModel.SelectedBettor);
				if (editedBettor != null)
				{
					WcfHelper.client.EditBettor(editedBettor);
					ReloadBettors();
				}
			}
		}

		private void DeleteTeam()
		{
			if (mViewModel.SelectedTeam != null)
			{
				WcfHelper.client.DeleteTeam(mViewModel.SelectedTeam);
				mViewModel.Teams.Remove(mViewModel.SelectedTeam);
				ReloadTeams();
			}
		}

		private void AddTeam()
		{
			WcfTeam addedTeam = new WindowAddTeamController().AddTeam();
			if (addedTeam != null)
			{
				WcfHelper.client.AddTeam(addedTeam);
				ReloadTeams();
			}
		}

		private void EditTeam()
		{
			if (mViewModel.SelectedTeam != null)
			{
				WcfTeam editedTeam = new WindowEditTeamController().EditTeam(mViewModel.SelectedTeam);
				if (editedTeam != null)
				{
					WcfHelper.client.EditTeam(editedTeam);
					ReloadTeams();
				}
			}
		}

		private void EditSeason()
		{
			if (mViewModel.SelectedSeason != null)
			{
				WcfSeason editedSeason = new WindowEditSeasonController().EditSeason(mViewModel.SelectedSeason);
				if (editedSeason != null)
				{
					WcfHelper.client.EditSeason(editedSeason);
					ReloadSeasons();
				}
			}
		}

		private void AddSeason()
		{
			WcfSeason addedSeason = new WindowAddSeasonController().AddSeason();
			if (addedSeason != null)
			{
				WcfHelper.client.AddSeason(addedSeason);
				ReloadSeasons();
			}
		}

		private void DeleteSeason()
		{
			if(mViewModel.SelectedSeason != null)
			{
				WcfHelper.client.DeleteSeason(mViewModel.SelectedSeason);
				ReloadSeasons();
			}
		}

		// Button Add
		private void AddCommandExecute(object obj)
		{
			switch (mViewModel.SelectedTab)
			{
				case 0:		// Bettors     
					AddBettor();
					break;

				case 1:     // Teams
					AddTeam();
					break;

				case 2:     // Seasons
					AddSeason();
					break;
			}
		}

		// Button Edit
		private void EditCommandExecute(object obj)
		{
			switch (mViewModel.SelectedTab)
			{
				case 0:     // Bettors
					EditBettor();
					break;

				case 1:     // Teams
					EditTeam();
					break;

				case 2:     // Seasons
					EditSeason();
					break;
			}
		}

		// Button Delete
		private void DeleteCommandExecute(object obj)
		{
			switch (mViewModel.SelectedTab)
			{
				case 0:     // Bettors
					DeleteBettor();
					break;

				case 1:     // Teams
					DeleteTeam();
					break;

				case 2:     // Seasons
					DeleteSeason();
					break;
			}				
		}

		private bool CommandCanExecute(object obj)
		{
			switch (mViewModel.SelectedTab)
			{
				case 0:     // Bettors
					return mViewModel.SelectedBettor != null;
					break;

				case 1:     // Teams
					return mViewModel.SelectedTeam != null;
					break;

				case 2:     // Seasons
					return mViewModel.SelectedSeason != null;
					break;
			}
			return false;
		}
	}
}
