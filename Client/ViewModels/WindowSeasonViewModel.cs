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
	class WindowSeasonViewModel : ViewModelBase
	{
		private TeamHelper mSelectedTeam;
		private ObservableCollection<TeamHelper> mTeams;

		private WcfTeam mSelectedAllTeam;
		private ObservableCollection<WcfTeam> mAllTeams;

		private WcfMatch mSelectedMatch;
		private ObservableCollection<WcfMatch> mMatches;

		public WcfSeason Season { get; set; }
		public ICommand OkCommand { get; set; }
		public ICommand CancelCommand { get; set; }
		public ICommand DeleteTeamCommand { get; set; }
		public ICommand AddTeamCommand { get; set; }
		public ICommand AddMatchCommand { get; set; }
		public ICommand EditMatchCommand { get; set; }
		public ICommand DeleteMatchCommand { get; set; }

		public string Name
		{
			get { return Season.Name; }

			set
			{
				if (Season.Name == value)
					return;
				Season.Name = value;
				OnPropertyChanged("Name");
			}
		}

		public string Description
		{
			get { return Season.Description; }

			set
			{
				if (Season.Description == value)
					return;
				Season.Description = value;
				OnPropertyChanged("Description");
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

		public TeamHelper SelectedTeam
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

		public ObservableCollection<WcfTeam> AllTeams
		{
			get { return mAllTeams; }

			set
			{
				if (mAllTeams == value)
					return;
				mAllTeams = value;
				OnPropertyChanged("AllTeams");
			}
		}

		public WcfTeam SelectedAllTeam
		{
			get { return mSelectedAllTeam; }

			set
			{
				if (mSelectedAllTeam == value)
					return;
				mSelectedAllTeam = value;
				OnPropertyChanged("SelectedAllTeam");
			}
		}

		public ObservableCollection<WcfMatch> Matches
		{
			get { return mMatches; }

			set
			{
				if (mMatches == value)
					return;
				mMatches = value;
				OnPropertyChanged("Matches");
			}
		}

		public WcfMatch SelectedMatch
		{
			get { return mSelectedMatch; }

			set
			{
				if (mSelectedMatch == value)
					return;
				mSelectedMatch = value;
				OnPropertyChanged("SelectedMatch");
			}
		}

	}
}
