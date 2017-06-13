using Client.Framework;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
	class MainWindowViewModel : ViewModelBase
	{
		private ObservableCollection<Bettor> mBettors;
		private Bettor mSelectedBettor;
		private ObservableCollection<Team> mTeams;
		private Team mSelectedTeam;
		private ObservableCollection<Season> mSeasons;
		private Season mSelectedSeason;

		public ICommand ButtonAdd { get; set; }
		public ICommand ButtonDelete { get; set; }
		public ICommand ButtonEdit { get; set; }

		// Bettor

		public ObservableCollection<Bettor> Bettors
		{
			get { return mBettors; }

			set
			{
				if (mBettors == value)
					return;
				mBettors = value;
				OnPropertyChanged("Bettors");
			}
		}

		public Bettor SelectedBettor
		{
			get { return mSelectedBettor; }

			set
			{
				if (mSelectedBettor == value)
					return;
				mSelectedBettor = value;
				OnPropertyChanged("SelectedBettor");
			}
		}

		// Team

		public ObservableCollection<Team> Teams
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

		public Team SelectedTeam
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

		// Season

		public ObservableCollection<Season> Seasons
		{
			get { return mSeasons; }

			set
			{
				if (mSeasons == value)
					return;
				mSeasons = value;
				OnPropertyChanged("Seasons");
			}
		}

		public Season SelectedSeason
		{
			get { return mSelectedSeason; }

			set
			{
				if (mSelectedSeason == value)
					return;
				mSelectedSeason = value;
				OnPropertyChanged("SelectedSeason");
			}
		}
	}
}
