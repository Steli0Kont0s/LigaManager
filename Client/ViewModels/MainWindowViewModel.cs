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
	class MainWindowViewModel : ViewModelBase
	{
		private ObservableCollection<WcfBettor> mBettors;
		private WcfBettor mSelectedBettor;
		private ObservableCollection<WcfTeam> mTeams;
		private WcfTeam mSelectedTeam;
		private ObservableCollection<WcfSeason> mSeasons;
		private WcfSeason mSelectedSeason;
		private int mSelectedTab;

		public ICommand ButtonAdd { get; set; }
		public ICommand ButtonDelete { get; set; }
		public ICommand ButtonEdit { get; set; }

		// Selected Tab 0:Bettors 1:Teams 2:Seasons
		public int SelectedTab
		{
			get { return mSelectedTab; }

			set
			{
				if (mSelectedTab == value)
					return;
				mSelectedTab = value;
				OnPropertyChanged("SelectedTab");
			}
		}

		// Bettor
		public ObservableCollection<WcfBettor> Bettors
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

		public WcfBettor SelectedBettor
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

		public WcfTeam SelectedTeam
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

		public ObservableCollection<WcfSeason> Seasons
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

		public WcfSeason SelectedSeason
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
